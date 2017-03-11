using System.Windows.Forms;

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
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblNameContest = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Winner is:";
            // 
            // txtwinner
            // 
            this.txtwinner.Enabled = false;
            this.txtwinner.Location = new System.Drawing.Point(135, 87);
            this.txtwinner.Name = "txtwinner";
            this.txtwinner.Size = new System.Drawing.Size(100, 26);
            this.txtwinner.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Votes:";
            // 
            // txtVotes
            // 
            this.txtVotes.Enabled = false;
            this.txtVotes.Location = new System.Drawing.Point(135, 125);
            this.txtVotes.Name = "txtVotes";
            this.txtVotes.Size = new System.Drawing.Size(100, 26);
            this.txtVotes.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Location = new System.Drawing.Point(40, 184);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(656, 169);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Entry";
            this.columnHeader1.Width = 194;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 223;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Votes";
            this.columnHeader3.Width = 96;
            // 
            // lblNameContest
            // 
            this.lblNameContest.AutoSize = true;
            this.lblNameContest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameContest.Location = new System.Drawing.Point(266, 23);
            this.lblNameContest.Name = "lblNameContest";
            this.lblNameContest.Size = new System.Drawing.Size(102, 37);
            this.lblNameContest.TabIndex = 5;
            this.lblNameContest.Text = "label3";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(212, 360);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(351, 66);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "TEMPORARY CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmSummarize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 438);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblNameContest);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtVotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtwinner);
            this.Controls.Add(this.label1);
            this.Name = "frmSummarize";
            this.Text = "frmSummarize";
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
        private System.Windows.Forms.ColumnHeader columnHeader3;
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