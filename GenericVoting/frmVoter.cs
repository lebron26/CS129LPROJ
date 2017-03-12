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
using System.Xml;

using System.Security;
namespace GenericVoting
{
    public partial class frmVoter : Form
    {
        ClassFolder folder;

        //static string folder = @"C:\Users\dell pc\Documents\Visual Studio 2015\Projects\GenericVoting\Entry\";
        //string userfolder = @"C:\Users\dell pc\Documents\Visual Studio 2015\Projects\GenericVoting\Users\";

        public frmVoter(string user)
        {
            
            InitializeComponent();
            this.get(user);
        }
        private void btnVote_Click(object sender, EventArgs e)
        {
            folder = new ClassFolder();
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Selected)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(UserConcrete));
                    Stream stream = File.Open(folder.getUser() + txtUser.Text + ".xml", FileMode.Open);
                   
                    UserConcrete user = (UserConcrete)serializer.Deserialize(stream);

                    if (user.status == false)
                    {

                        string entry1 = item.SubItems[0].Text;
                      
                        if(item.Text==item.SubItems[0].Text)
                        {
                            item.BackColor = Color.LightBlue;
                       
                        }
                        XmlSerializer entryserializer = new XmlSerializer(typeof(Entry));
                        Stream entrystream = File.Open(folder.getEntry() + entry1 + ".xml", FileMode.Open);
                        Entry entry = (Entry)entryserializer.Deserialize(entrystream);

                        user.entry = entry1;
                        user.status = true;
                        entry.vote += 1;
                        /*          FOr STATUS             */
                        
                        XmlDocument xmlDoc = new XmlDocument();

                        stream.Position = 0;
                        xmlDoc.Load(stream);
                        string status = user.status.ToString().ToLower();
                        XmlNode node = xmlDoc.SelectSingleNode("/UserConcrete/status") as XmlElement;
                        XmlNode node1 = xmlDoc.SelectSingleNode("/UserConcrete/entry") as XmlElement;
                        if (node!=null)

                        node.InnerText = status;
                 //Enttry
                          node1.InnerText = user.entry;
                        stream.Position = 0;
                        stream.SetLength(0);
                        
                        xmlDoc.Save(stream);
                        stream.Close();
                        

                        /*      ////////////            */

                        /*            FOR VOTES          */

                        XmlDocument xmlDoc1 = new XmlDocument();
                        if (entrystream.Position > 0)
                        {
                                entrystream.Position = 0;
                            }
                            xmlDoc1.Load(entrystream);

                            xmlDoc1.SelectSingleNode("Entry/vote").InnerText = entry.vote.ToString();

                        entrystream.Position = 0;
                        entrystream.SetLength(0);
                        xmlDoc1.Save(entrystream);
                        xmlDoc1 = null;
                        entrystream.Close();

                        /*      ////////////            */
                        listView1.Items.Clear();
                        this.get(txtUser.Text);

                    }
                        else
                            MessageBox.Show("You Cannot Vote");
                    btnCancel.Enabled = true;

                    btnVote.Enabled = false;

                    listView1.Enabled = false;

                }

            }
        }
    

        private void get(string use)
        {
            folder = new ClassFolder();
            XmlSerializer serializer2 = new XmlSerializer(typeof(UserConcrete));
            Stream stream2 = File.Open(folder.getUser() + use + ".xml", FileMode.Open);

            UserConcrete user = (UserConcrete)serializer2.Deserialize(stream2);


            string[] files = Directory.GetFiles(folder.getEntry());

            foreach (var f in files)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Entry));

                Stream stream = File.Open(f, FileMode.Open);
                Entry entry = (Entry)serializer.Deserialize(stream);

                ListViewItem item = new ListViewItem(entry.entry);
                
                item.SubItems.Add(entry.description);
                item.SubItems.Add(entry.vote.ToString());
                listView1.Items.Add(item);
                stream.Close();
            }
            
            if (user.status == true)
            {
                foreach (ListViewItem lvi in listView1.Items)
                {
                    if (lvi.SubItems[0].Text == user.entry)
                    {
                        txtEntry.Text = lvi.SubItems[0].Text;
                        lvi.SubItems[0].BackColor = Color.LightBlue;
                    }

                }
                btnCancel.Enabled = true;

                btnVote.Enabled = false;
                txtEntry.Enabled = false;
                listView1.Enabled = false;
            }
            else
            {
                listView1.Enabled = true;
                foreach (ListViewItem lvi in listView1.Items)
                {
                    txtEntry.Text = lvi.SubItems[0].Text;
                    lvi.SubItems[0].BackColor = Color.White;
 
                }
                txtEntry.Enabled = false;
                btnCancel.Enabled = false;

                btnVote.Enabled = true;

            }
            
                stream2.Close(); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            folder = new ClassFolder();
            foreach (ListViewItem item in listView1.Items)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(UserConcrete));
                using (Stream stream = File.Open(folder.getUser() + TxtUser.Text + ".xml", FileMode.Open))
                {
                    UserConcrete user = (UserConcrete)serializer.Deserialize(stream);

                    //Nakapagvote na is true
                    if (user.status == true)
                    {
                        string entry1 = txtEntry.Text;

                        if (entry1 == item.SubItems[0].Text)
                        {

                            item.BackColor = Color.White;
                        }
                        XmlSerializer entryserializer = new XmlSerializer(typeof(Entry));
                        Stream entrystream = File.Open(folder.getEntry() + entry1 + ".xml", FileMode.Open);
                        Entry entry = (Entry)entryserializer.Deserialize(entrystream);

                        user.entry = "null";
                        user.status = false;
                        entry.vote -= 1;
                        /*          FOr STATUS             */

                        XmlDocument xmlDoc = new XmlDocument();

                        stream.Position = 0;
                        xmlDoc.Load(stream);
                        string status = user.status.ToString().ToLower();
                        XmlNode node = xmlDoc.SelectSingleNode("/UserConcrete/status") as XmlElement;
                        if (node != null)

                            node.InnerText = status;

                        stream.Position = 0;
                        stream.SetLength(0);

                        xmlDoc.Save(stream);
                        stream.Close();


                        /*      ////////////            */

                        /*            FOR VOTES          */

                        XmlDocument xmlDoc1 = new XmlDocument();
                        if (entrystream.Position > 0)
                        {
                            entrystream.Position = 0;
                        }
                        xmlDoc1.Load(entrystream);

                        xmlDoc1.SelectSingleNode("Entry/vote").InnerText = entry.vote.ToString();

                        entrystream.Position = 0;
                        entrystream.SetLength(0);
                        xmlDoc1.Save(entrystream);
                        xmlDoc1 = null;
                        entrystream.Close();

                        /*      ////////////            */
                        listView1.Items.Clear();
                        this.get(txtUser.Text);
                    }
                    else
                        MessageBox.Show("You Minus Vote");

                    btnCancel.Enabled = false;

                    btnVote.Enabled = true;
                }




                listView1.Enabled = true;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1) // handle it some other way if you have multiselect.
            {
                ListViewItem item = listView1.SelectedItems[0];
                if (item != null)
                {
                    txtEntry.Text = item.SubItems[0].Text;
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            Login login = new Login();
            login.ShowDialog();
           
        }
    }
}
