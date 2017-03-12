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
    public partial class frmContest : Form
    {

        ClassFolder folder;
        //string folder = @"C:\Users\dell pc\Documents\Visual Studio 2015\Projects\GenericVoting\Contest\";

        Contest contest;
        public frmContest()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            folder = new ClassFolder();
            contest = new Contest(txtContest.Text, richTextBox1.Text, datePicker1.Value, Convert.ToInt32(txtVotes.Text));

            Stream stream = File.Create(folder.getContest() + txtContest.Text + ".xml");

            XmlSerializer serialize = new XmlSerializer(typeof(Contest));
            serialize.Serialize(stream, contest);
            stream.Close();
            MessageBox.Show("Contest Created");

            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
