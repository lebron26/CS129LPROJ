using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using Generic_Library;
using System.Xml.Linq;

namespace GenericVoting
{
    public partial class ManageVoter : Form
    {
        string folder = @"C:\Users\dell pc\Documents\Visual Studio 2015\Projects\GenericVoting\Users\";
        string first;
        string last;
        public ManageVoter()
        {
            InitializeComponent();
            txtStatus.Text = "Not Finished";

            this.get();
        }
        
        private void get()
        {
            string[] files = Directory.GetFiles(folder);
            foreach (var f in files)
            {
                
                XmlSerializer serializer = new XmlSerializer(typeof(UserConcrete));

                Stream stream = File.Open(f, FileMode.Open);
                UserConcrete user = (UserConcrete)serializer.Deserialize(stream);

                if (user.type == "Voter")
                {
                    ListViewItem item = new ListViewItem(user.username);
                    item.SubItems.Add(user.firstname + " " + user.lastname);
                 
                    item.SubItems.Add(user.password);
                    if (user.status == true)
                    {
                        item.SubItems.Add("Finished");

                        txtStatus.Text = "Finished";
                    }
                    else
                    {

                        item.SubItems.Add("Not Finished");
                        txtStatus.Text = "Not Finished";
                    }
                    lviVoter.Items.Add(item);

                    
                }
                stream.Close();
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ( txtFirst.Text == "" || txtLast.Text == "" || txtUser.Text == "" || txtPass.Text == "")
                MessageBox.Show("Please complete all the fields required to register.");
            else {
              
                if (File.Exists(folder + txtUser.Text + ".xml"))
                {
                    MessageBox.Show("This username is already registered. Please try again.");
                }
                else
                {
                    UserConcrete userconcrete = new UserConcrete { username = txtUser.Text, password = txtPass.Text, firstname = txtFirst.Text, lastname = txtLast.Text, type = "Voter", status=false ,entry="null"};

                    UserDecorator decorate;
                    decorate = new Voter(userconcrete);
                    
                    Stream stream = File.Create(folder + userconcrete.username + ".xml");

                    XmlSerializer serialize = new XmlSerializer(typeof(UserConcrete));
                    serialize.Serialize(stream, userconcrete);
                    stream.Close();
                    MessageBox.Show(userconcrete.Display());
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (lviVoter.Items.Count == 0)
                MessageBox.Show("No more items to erase");

            foreach (ListViewItem item in lviVoter.Items)
            {
                if (item.Selected)
                {
                   lviVoter.Items.Remove(item);
                     File.Delete(folder + item.SubItems[0].Text + ".xml");
                }
                else
                    MessageBox.Show("Select Item to Remove");
            }

            
        }

        private void lviVoter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lviVoter.SelectedItems.Count == 1) // handle it some other way if you have multiselect.
            {
                ListViewItem item = lviVoter.SelectedItems[0];
                if (item != null)
                {
                    txtUser.Text = item.SubItems[0].Text;
                    txtUser.Enabled = false;
                    txtPass.Text = item.SubItems[2].Text;
                    txtPass.Enabled = false;

                    string[] size=item.SubItems[1].Text.Split(' ');

                    txtFirst.Text = size[0];
                    txtFirst.Enabled = false;
                    txtLast.Text = size[1];
                    txtLast.Enabled = false;
                    txtStatus.Text = item.SubItems[3].Text;
                    

                    // = item.SubItems[4].Text;
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtFirst.Enabled = true;
            txtPass.Enabled = true;
            txtUser.Enabled = true;
            txtLast.Enabled = true;
            txtStatus.Enabled = true;
            txtFirst.Text = null;
            txtLast.Text = null;
            txtPass.Text = null;
            txtUser.Text = null;
            txtStatus.Text = "Not Finished";
            txtStatus.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
