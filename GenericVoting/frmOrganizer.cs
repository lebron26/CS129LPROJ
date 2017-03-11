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
    public partial class frmOrganizer : Form
    {
        string folder = @"C:\Users\dell pc\Documents\Visual Studio 2015\Projects\GenericVoting\Contest\";
        static string entryfolder = @"C:\Users\dell pc\Documents\Visual Studio 2015\Projects\GenericVoting\Entry\";

        string[] files = Directory.GetFiles(entryfolder);
        public frmOrganizer(string name)
        {
            InitializeComponent();
            this.timer(name);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.ShowDialog();
            reg.Hide();
        }

        private void btnVoters_Click(object sender, EventArgs e)
        {
            ManageVoter manVote = new ManageVoter();
            manVote.ShowDialog();
            manVote.Hide();
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            EntryForm entry = new EntryForm();
            entry.ShowDialog();
            entry.Hide();
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            frmResults result = new frmResults();
            result.ShowDialog();
            result.Hide();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
       
        }
        public void timer(string name)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Contest));

            Stream stream = File.Open(folder + name+".xml", FileMode.Open);
            Contest contest = (Contest)serializer.Deserialize(stream);

            /**/
            foreach (var f in files)
            {
                XmlSerializer serializer1 = new XmlSerializer(typeof(Entry));

                Stream stream1 = File.Open(f,FileMode.Open);
                Entry entry = (Entry)serializer1.Deserialize(stream1);

                if (entry.vote == contest.maxVote)
                {
                    frmSummarize sum = new frmSummarize();

                    sum.ShowDialog();

                }
                
               stream1.Close();
            }

            /**/
            DateTime dt = contest.specificDate;

            TimeSpan time = new TimeSpan(dt.Ticks);

            if (contest.IsExpired(dt) == false)
            {
                lblDate.Text = "Expires:\n" + dt.ToLongDateString() + " " + dt.ToLongTimeString();
                // MessageBox.Show(dt.ToLongDateString()+" "+ dt.ToLongTimeString());

            }
            else
            {
                /*   WINNER    */

                // MessageBox.Show("Not this time");
            }
            stream.Close();
        }
    }
}
