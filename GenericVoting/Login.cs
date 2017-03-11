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
    public partial class Login : Form
    {
        ClassFolder folder;
       // string folder = @"C:\Users\dell pc\Documents\Visual Studio 2015\Projects\GenericVoting\Users\";
      //  string contestfolder = @"C:\Users\dell pc\Documents\Visual Studio 2015\Projects\GenericVoting\Contest\";

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            folder= new ClassFolder();
            XmlSerializer serializer = new XmlSerializer(typeof(UserConcrete));

            if (File.Exists(folder.getUser() + txtUser.Text + ".xml"))
            {
                Stream stream = File.Open(folder.getUser() + txtUser.Text + ".xml", FileMode.Open);
                UserConcrete user = (UserConcrete)serializer.Deserialize(stream);
              

                if (user.password == txtPass.Text)
                {
                    if (user.type == "Voter")
                    {

                        stream.Close();
                        MessageBox.Show(user.Display());
                        frmVoter voteform = new frmVoter(txtUser.Text);
                        voteform.TxtName.Text = user.firstname+" "+user.lastname;
                        voteform.TxtUser.Text = user.username;
                        voteform.TxtUser.Enabled = false;
                        voteform.TxtName.Enabled = false;
                        voteform.Show();
                        this.Hide();
                    }
                    else
                    {

                        string[] files = Directory.GetFiles(folder.getContest());
                        foreach (var f in files)
                        {
                            if (File.Exists(f))
                            {
                                XmlSerializer serializer1 = new XmlSerializer(typeof(Contest));
                                Stream conteststream = File.Open(f, FileMode.Open);
                                Contest contest = (Contest)serializer1.Deserialize(conteststream);


                                conteststream.Close();
                                MessageBox.Show("Welcome Organizer!");
                                frmOrganizer organform = new frmOrganizer(contest.contest);
                                organform.LblContestName.Text = contest.contest;
                          
                                organform.Show();
                                this.Hide();
                            }
                            else
                                MessageBox.Show("Create Contest");
                           
                        }
                    }
                }
                stream.Close();
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            this.Hide();
        }

     
    }
}
