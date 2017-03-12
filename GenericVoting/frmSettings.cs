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
    public partial class frmSettings : Form
    {
        ClassFolder folder;
        int algovote=0;
        string algoentry;
        public frmSettings()
        {
            InitializeComponent();
            this.get();
        }
        private void get()
        {
            folder = new ClassFolder();
            Stream stream;
            string[] contestfiles = Directory.GetFiles(folder.getContest());
            XmlSerializer serializer = new XmlSerializer(typeof(Contest));
            foreach (var f in contestfiles)
            {
                stream = File.Open(f, FileMode.Open);
                Contest Contest = (Contest)serializer.Deserialize(stream);

                txtnamecontest.Text = Contest.contest;
                txtVotes.Text = Contest.maxVote.ToString();
                richTextBox1.Text = Contest.description;
              //  DateTime date;
                dateTimePicker1.Text = Contest.specificDate.ToLongDateString();
                dateTimePicker2.Text = Contest.specificDate.ToShortTimeString();

                txtnamecontest.Enabled = false;
                txtVotes.Enabled = false;
                richTextBox1.Enabled = false;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                stream.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            folder = new ClassFolder();
            string[] files = Directory.GetFiles(folder.getEntry());
            XmlSerializer serializer = new XmlSerializer(typeof(Entry));

            Stream stream;
            foreach (var f in files)
            {
                stream = File.Open(f, FileMode.Open);

                Entry get= (Entry)serializer.Deserialize(stream);

                if (get.vote>algovote)
                {
                    algovote = get.vote;
                    algoentry = get.entry;


                }
                stream.Close();
            }
            frmSummarize sum = new frmSummarize(algoentry);
            sum.Txtwinner.Text = algoentry;
            sum.TxtVotes.Text = algovote.ToString();
            sum.Show();

       
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

        }
    }
}
