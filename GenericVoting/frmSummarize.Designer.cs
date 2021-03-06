﻿using System.Windows.Forms;

namespace GenericVoting
{
    partial class frmSummarize
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtwinner = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVotes = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblNameContest = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(143, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Winner is:";
            // 
            // txtwinner
            // 
            this.txtwinner.Enabled = false;
            this.txtwinner.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwinner.Location = new System.Drawing.Point(234, 56);
            this.txtwinner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtwinner.Name = "txtwinner";
            this.txtwinner.Size = new System.Drawing.Size(147, 31);
            this.txtwinner.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(166, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Votes:";
            // 
            // txtVotes
            // 
            this.txtVotes.Enabled = false;
            this.txtVotes.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.txtVotes.Location = new System.Drawing.Point(234, 230);
            this.txtVotes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVotes.Name = "txtVotes";
            this.txtVotes.Size = new System.Drawing.Size(59, 23);
            this.txtVotes.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.listView1.Location = new System.Drawing.Point(46, 97);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(424, 111);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Voter";
            this.columnHeader1.Width = 194;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Full Name:";
            this.columnHeader2.Width = 223;
            // 
            // lblNameContest
            // 
            this.lblNameContest.AutoSize = true;
            this.lblNameContest.Font = new System.Drawing.Font("Corbel", 26.25F);
            this.lblNameContest.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNameContest.Location = new System.Drawing.Point(129, 3);
            this.lblNameContest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameContest.Name = "lblNameContest";
            this.lblNameContest.Size = new System.Drawing.Size(254, 42);
            this.lblNameContest.TabIndex = 5;
            this.lblNameContest.Text = "Result Summary";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(147, 266);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(234, 43);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Restart Contest";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmSummarize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(518, 317);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblNameContest);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtVotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtwinner);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmSummarize";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtwinner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVotes;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lblNameContest;
        private Button btnClose;

        public Label LblNameContest
        {
            get
            {
                return lblNameContest;
            }

            set
            {
                lblNameContest = value;
            }
        }

        public TextBox TxtVotes
        {
            get
            {
                return txtVotes;
            }

            set
            {
                txtVotes = value;
            }
        }

        public TextBox Txtwinner
        {
            get
            {
                return txtwinner;
            }

            set
            {
                txtwinner = value;
            }
        }
    }
}