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

namespace GenericVoting
{
    public partial class frmResults : Form
    {
        static string folder = @"C:\Users\dell pc\Documents\Visual Studio 2015\Projects\GenericVoting\Entry\";
        //string userfolder = @"C:\Users\dell pc\Documents\Visual Studio 2015\Projects\GenericVoting\Users\";

        string[] files = Directory.GetFiles(folder);
        public frmResults()
        {
            InitializeComponent();
            this.get();
        }

        private void get()
        {
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
        }
    }
}
