using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Generic_Library;
using System.IO;
using System.Xml.Serialization;

namespace GenericVoting
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            this.get();
        }

        ClassFolder folder;
   
        private void get()
        {
            folder = new ClassFolder();
            string[] files = Directory.GetFiles(folder.getUser());
            foreach (var f in files)
            {

                XmlSerializer serializer = new XmlSerializer(typeof(UserConcrete));

                Stream stream = File.Open(f, FileMode.Open);
                UserConcrete user = (UserConcrete)serializer.Deserialize(stream);

                if (user.type != "Voter")
                {
                    ListViewItem item = new ListViewItem(user.username);
                    
                    item.SubItems.Add(user.password);
                    item.SubItems.Add(user.firstname + " " + user.lastname);
                    item.SubItems.Add(user.type);              
                    lviUsers.Items.Add(item);

                    //Color
                    if (user.type == "Organizer")
                        item.BackColor = Color.LightGoldenrodYellow;
                    else
                        item.BackColor = Color.LightBlue;
                }
                stream.Close();
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            folder = new ClassFolder();
            if (txtFirst.Text == "" || txtLast.Text == "" || txtUser.Text == "" || txtPass.Text == "")
                MessageBox.Show("Please complete all the fields required to register.");
            else {
                string combo = cmbSelect.SelectedItem.ToString();

                if (File.Exists(folder.getUser() + txtUser.Text + ".xml"))
                {
                    MessageBox.Show("This username is already registered. Please try again.");
                }
                else
                { 
                    UserConcrete userconcrete = new UserConcrete { username = txtUser.Text, password = txtPass.Text, firstname = txtFirst.Text, lastname = txtLast.Text, type = combo };

                    UserDecorator decorate;
                    if (combo == "Voter")
                    {
                        decorate = new Voter(userconcrete);
                    }
                    else if (combo == "Entry")
                    {
                        decorate = new Entry(userconcrete);
                    }
                    else
                    {
                        decorate = new Organizer(userconcrete);
                    }

                    Stream stream = File.Create(folder.getUser() + userconcrete.username + ".xml");

                    XmlSerializer serialize = new XmlSerializer(typeof(UserConcrete));
                    serialize.Serialize(stream, userconcrete);
                    stream.Close();
                    MessageBox.Show(userconcrete.Display());
                }
            }
            lviUsers.Items.Clear();
            this.get();



        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtFirst.Enabled = true;
            txtPass.Enabled = true;
            txtUser.Enabled = true;
            txtLast.Enabled = true;

            txtFirst.Text = null;
            txtLast.Text = null;
            txtPass.Text = null;
            txtUser.Text = null;

            cmbSelect.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
       
        }

        private void lviUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lviUsers.SelectedItems.Count == 1) // handle it some other way if you have multiselect.
            {
                ListViewItem item = lviUsers.SelectedItems[0];
                if (item != null)
                {
                    txtUser.Text = item.SubItems[0].Text;
                    txtUser.Enabled = false;
                    txtPass.Text = item.SubItems[1].Text;
                    txtPass.Enabled = false;

                    string[] size = item.SubItems[2].Text.Split(' ');

                    txtFirst.Text = size[0];
                    txtFirst.Enabled = false;
                    txtLast.Text = size[1];
                    txtLast.Enabled = false;
                    cmbSelect.Text = item.SubItems[3].Text;

                }
            }
        }

       
    }
}
