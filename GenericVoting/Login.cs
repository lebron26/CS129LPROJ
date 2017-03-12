﻿using System;
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
        Contest contest;
        string getname;
        string entryname;
        string namecontest;
        bool ok;
        int votes;
        string type;
        bool fa=false;
        Stream stream;
        ClassFolder folder;
        string contest1;
        string expires;
        public Login()
        {
            InitializeComponent();
            this.timer();            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {            
            folder= new ClassFolder();
            XmlSerializer serializer = new XmlSerializer(typeof(UserConcrete));

            if (File.Exists(folder.getUser() + txtUser.Text + ".xml") || File.Exists(folder.getAdmin() + txtUser.Text + ".xml"))
            {
                Stream stream;
                if (txtUser.Text == "glenn")
                    stream = File.Open(folder.getAdmin() + txtUser.Text + ".xml", FileMode.Open);
                else
                    stream = File.Open(folder.getUser() + txtUser.Text + ".xml", FileMode.Open);

                UserConcrete user = (UserConcrete)serializer.Deserialize(stream);
                if (user.password == txtPass.Text)
                {
                    if (user.type == "Voter")
                    {
                        if (ok == true)
                        {
                            stream.Close();
                            frmSummarize sum = new frmSummarize(entryname);
                            sum.LblNameContest.Text = namecontest;
                            sum.Txtwinner.Text = entryname;
                            sum.TxtVotes.Text = votes.ToString();
                            sum.Show();
                            this.Hide();
                        }
                        else { 
                            stream.Close();
                            MessageBox.Show("Welcome "+user.Display());
                            frmVoter voteform = new frmVoter(txtUser.Text);
                            voteform.TxtName.Text = user.firstname + " " + user.lastname;
                            voteform.TxtUser.Text = user.username;
                            voteform.TxtUser.Enabled = false;
                            voteform.TxtName.Enabled = false;
                            voteform.Show();
                            this.Hide();
                        }
                    }
                    else if (user.type == "Entry")
                    {
                        if (ok == true)
                        {
                            stream.Close();
                            frmSummarize sum = new frmSummarize(entryname);
                            sum.LblNameContest.Text = namecontest;
                            sum.Txtwinner.Text = entryname;
                            sum.TxtVotes.Text = votes.ToString();
                            sum.Show();
                            this.Hide();
                        }
                        else
                        {
                            frmOrganizer organform;
                            string[] files = Directory.GetFiles(folder.getContest());
                            foreach (var f in files)
                            {
                                if (File.Exists(f))
                                {
                                    XmlSerializer serializer1 = new XmlSerializer(typeof(Contest));
                                    Stream conteststream = File.Open(f, FileMode.Open);
                                    Contest contest = (Contest)serializer1.Deserialize(conteststream);


                                    expires = contest.specificDate.ToLongDateString() + contest.specificDate.ToLongTimeString();
                                    contest1 = contest.contest;
                                    conteststream.Close();
                                }
                                else
                                    MessageBox.Show("No Contest");
                            }
                            MessageBox.Show("Welcome " + user.Display());
                            getname = user.username;
                            type = user.type;
                            organform = new frmOrganizer(contest1,getname,type);
                          
                            organform.LblContestName.Text = contest1;
                            organform.BtnSetting.Enabled = false;
                            organform.BtnVoters.Enabled = false;
                            organform.BtnUsers.Enabled = false;
                     
                            organform.LblDate.Text = expires;
                            organform.Show();
                        }
                    }
                    else
                    {
                        if (ok == true)
                        {
                            stream.Close();
                            frmSummarize sum = new frmSummarize(entryname);
                            sum.LblNameContest.Text = namecontest;
                            sum.Txtwinner.Text = entryname;
                            sum.TxtVotes.Text = votes.ToString();
                            sum.Show();
                            this.Hide();
                        }
                        else
                        {
                            frmOrganizer organform;


                            string[] files = Directory.GetFiles(folder.getContest());
                           
                            foreach (var f in files)
                            {
                                XmlSerializer serializer1 = new XmlSerializer(typeof(Contest));
                                Stream conteststream = File.Open(f, FileMode.Open);
                                Contest contest = (Contest)serializer1.Deserialize(conteststream);

                                expires = contest.specificDate.ToLongDateString() + contest.specificDate.ToLongTimeString();
                                contest1 = contest.contest;
                                conteststream.Close();
                                fa = true;

                            }
                            if (!checkfile(fa))
                            {
                                frmContest contest = new frmContest();
                                contest.Show();
                                this.Hide();
                            }
                            else {
                                MessageBox.Show("Welcome " + user.Display());
                                organform = new frmOrganizer(contest1, getname, type);
                                organform.LblContestName.Text = contest1;
                                organform.BtnSetting.Enabled = true;
                                organform.BtnVoters.Enabled = true;
                                organform.BtnUsers.Enabled = true;
                                organform.LblDate.Text = expires;
                                organform.Show();
                                this.Hide();
                            }
                        }
                           
                        }
                    }
                stream.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        public bool checkfile(bool fa)
        {
            if (fa==true)
                return true;
            else
                return false;        
        }
 
        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            this.Hide();
        }
        public void timer()
        {
            folder = new ClassFolder();

            string[] files = Directory.GetFiles(folder.getEntry());

            string[] contestfiles = Directory.GetFiles(folder.getContest());

            XmlSerializer serializer1 = new XmlSerializer(typeof(Entry));


            XmlSerializer serializer = new XmlSerializer(typeof(Contest));
            
            foreach (var c in contestfiles)
            {
                 stream = File.Open(c, FileMode.Open);
            }
            if (stream != null)
            {
                contest = (Contest)serializer.Deserialize(stream);

                /**/
                foreach (var f in files)
                {
                    Stream stream1 = File.Open(f, FileMode.Open);

                    Entry entry = (Entry)serializer1.Deserialize(stream1);

                    if (contest.WinVotes(entry.vote, contest.maxVote) == true)
                    {
                        ok = contest.WinVotes(entry.vote, contest.maxVote);
                        entryname = entry.entry;
                        namecontest = contest.contest;

                        votes = entry.vote;

                    }

                    stream1.Close();
                }
           
                /**/
                DateTime dt = contest.specificDate;

                TimeSpan time = new TimeSpan(dt.Ticks);

                if (contest.IsExpired(dt) == false)
                {
                    // lblDate.Text = "Expires:\n" + dt.ToLongDateString() + " " + dt.ToLongTimeString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
