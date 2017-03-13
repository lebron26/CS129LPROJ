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
using System.Xml;

namespace GenericVoting
{
    public partial class EntryForm : Form
    {
        public ClassFolder folder;
         string getname;
        string userstatus;
        public EntryForm(string name)
        {
            InitializeComponent();
            getname = name;
            this.get();
        }
        private void get()
        {
            folder = new ClassFolder();
            string[] files = Directory.GetFiles(folder.getEntry());
            foreach (var f in files)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Entry));

                Stream stream = File.Open(f, FileMode.Open);
                Entry entry = (Entry)serializer.Deserialize(stream);

                ListViewItem item = new ListViewItem(entry.entry);
             
                item.SubItems.Add(entry.description);
                lviEntry.Items.Add(item);

                stream.Close();

            }
        }

        private void btnADDEntry_Click(object sender, EventArgs e)
        {
            folder = new ClassFolder();
            if (txtEntry.Text == "" || txtDes.Text == "")
                MessageBox.Show("Please complete all the fields required to register.");
            else {

                if (File.Exists(folder.getEntry() + txtEntry.Text + ".xml"))
                {
                    MessageBox.Show("This Entry is already registered. Please try again.");
                }
                else
                {
                    XmlSerializer serializer2 = new XmlSerializer(typeof(UserConcrete));
                    Stream stream2 = File.Open(folder.getUser() +getname + ".xml", FileMode.Open);

                    UserConcrete user = (UserConcrete)serializer2.Deserialize(stream2);

                    
                    Entry entry = new Entry();
                    /*
                    entry.entry = txtEntry.Text;
                    entry.description = txtDes.Text;
              
                    entry.entryuser = getname;

                    */

                    entry.AddEntry(txtEntry.Text, txtDes.Text, txtEntry.Text);



                    if (!user.status)
                    {
                        Stream stream = File.Create(folder.getEntry() + entry.entry + ".xml");
                        /*
                        XmlSerializer serialize = new XmlSerializer(typeof(Entry));
                        serialize.Serialize(stream, entry);
                        stream.Close();*/
                        entry.Serialize(stream, entry);
                        foreach (ListViewItem item in lviEntry.Items)
                        {
                            item.SubItems[0].Text = txtEntry.Text;
                            item.SubItems[1].Text = txtDes.Text;
                        }

                        userstatus = "true";

                        XmlDocument xmlDoc = new XmlDocument();

                        stream2.Position = 0;
                        xmlDoc.Load(stream2);
                       
                        XmlNode node = xmlDoc.SelectSingleNode("/UserConcrete/status") as XmlElement;
                        if (node != null)

                            node.InnerText = userstatus;
                        stream2.Position = 0;
                        stream2.SetLength(0);
                        xmlDoc.Save(stream2);
                        stream2.Close();

                        lviEntry.Items.Clear();
                        this.get();

                    }
                    else
                        MessageBox.Show("Entry should be 1");

                    stream2.Close();
                }
            }
        }

        private void btnDeleteEntry_Click(object sender, EventArgs e)
        {
            folder = new ClassFolder();
            if (lviEntry.Items.Count == 0)
                MessageBox.Show("No more items to erase");

            foreach (ListViewItem item in lviEntry.Items)
            {
                if (item.Selected)
                {
                    lviEntry.Items.Remove(item);
                    File.Delete(folder.getEntry() + item.SubItems[0].Text + ".xml");
                }
                else
                    MessageBox.Show("Select Item to Remove");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void lviEntry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lviEntry.SelectedItems.Count == 1) // handle it some other way if you have multiselect.
            {
                ListViewItem item = lviEntry.SelectedItems[0];
                if (item != null)
                {
                   txtEntry.Text = item.SubItems[0].Text;
                   txtEntry.Enabled = false;
                   txtDes.Text = item.SubItems[1].Text;
                   txtDes.Enabled = false;
                }
            }
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {

            txtEntry.Enabled = true;
             txtDes.Enabled = true;

            txtEntry.Text=null;
            txtDes.Text=null;


        }
    }
}
