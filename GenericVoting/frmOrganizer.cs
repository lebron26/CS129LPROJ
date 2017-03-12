﻿using System;
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

        ClassFolder folder;
        //string folder = @"C:\Users\dell pc\Documents\Visual Studio 2015\Projects\GenericVoting\Contest\";
        //  static string entryfolder = @"C:\Users\dell pc\Documents\Visual Studio 2015\Projects\GenericVoting\Entry\";
        string username1;
        string type1;
        public frmOrganizer(string name,string username,string type)
        {
            InitializeComponent();
            username1 = username;
            type1 = type;
        //    this.timer(name);
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
            EntryForm entry = new EntryForm(username1);
            if (type1 == "Entry")
            {
                entry.BtnDeleteEntry.Enabled = false;
                entry.BtnADDEntry.Enabled = true;
                entry.BtnEntry.Enabled = true;
            }
            else
            {
                entry.BtnADDEntry.Enabled = false;
                entry.BtnEntry.Enabled = false;
                entry.BtnDeleteEntry.Enabled = true;
            }
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
        
    }
}
