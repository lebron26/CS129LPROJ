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
    public partial class frmSummarize : Form
    {
        Stream stream;
        ClassFolder folder;
        public frmSummarize(string entry)
        {
            InitializeComponent();
            this.get(entry);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();

        }

        private void get(string entry)
        {
    
            folder = new ClassFolder();
            string[] files = Directory.GetFiles(folder.getUser());
            foreach (var f in files)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(UserConcrete));

                stream= File.Open(f, FileMode.Open);
                UserConcrete user = (UserConcrete)serializer.Deserialize(stream);

                if (user.type == "Voter")
                {
                    if (user.entry == entry)
                    {
                        ListViewItem item = new ListViewItem(user.username);
                        item.SubItems.Add(user.firstname);

                        listView1.Items.Add(item);
                    }
                }

            }

            stream.Close();
        }
    }
}
