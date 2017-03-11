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
    public partial class EntryForm : Form
    {
        string folder = @"C:\Users\dell pc\Documents\Visual Studio 2015\Projects\GenericVoting\Entry\";

        public EntryForm()
        {
            InitializeComponent();
            this.get();
        }
        private void get()
        {
            string[] files = Directory.GetFiles(folder);
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
            
            if (txtEntry.Text == "" || txtDes.Text=="")
                MessageBox.Show("Please complete all the fields required to register.");
            else {

                if (File.Exists(folder + txtEntry.Text + ".xml"))
                {
                    MessageBox.Show("This Entry is already registered. Please try again.");
                }
                else
                {
                    Entry entry = new Entry();
                    entry.entry = txtEntry.Text;
                    entry.description = txtDes.Text;
                    
                    Stream stream = File.Create(folder + entry.entry + ".xml");
                    XmlSerializer serialize = new XmlSerializer(typeof(Entry));
                    serialize.Serialize(stream, entry);
                     stream.Close();
                   }      
            }
        }

        private void btnDeleteEntry_Click(object sender, EventArgs e)
        {
            if (lviEntry.Items.Count == 0)
                MessageBox.Show("No more items to erase");

            foreach (ListViewItem item in lviEntry.Items)
            {
                if (item.Selected)
                {
                    lviEntry.Items.Remove(item);
                    File.Delete(folder + item.SubItems[0].Text + ".xml");
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
    }
}
