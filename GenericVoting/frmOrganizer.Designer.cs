using System.Windows.Forms;

namespace GenericVoting
{
    partial class frmOrganizer
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
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnVoters = new System.Windows.Forms.Button();
            this.btnEntry = new System.Windows.Forms.Button();
            this.btnResults = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.lblContestName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(284, 93);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(226, 73);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnVoters
            // 
            this.btnVoters.Location = new System.Drawing.Point(118, 199);
            this.btnVoters.Name = "btnVoters";
            this.btnVoters.Size = new System.Drawing.Size(226, 71);
            this.btnVoters.TabIndex = 1;
            this.btnVoters.Text = "Voter";
            this.btnVoters.UseVisualStyleBackColor = true;
            this.btnVoters.Click += new System.EventHandler(this.btnVoters_Click);
            // 
            // btnEntry
            // 
            this.btnEntry.Location = new System.Drawing.Point(118, 314);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(226, 79);
            this.btnEntry.TabIndex = 2;
            this.btnEntry.Text = "Entry";
            this.btnEntry.UseVisualStyleBackColor = true;
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
            // 
            // btnResults
            // 
            this.btnResults.Location = new System.Drawing.Point(466, 198);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(173, 72);
            this.btnResults.TabIndex = 3;
            this.btnResults.Text = "Results";
            this.btnResults.UseVisualStyleBackColor = true;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(466, 317);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(173, 72);
            this.btnSetting.TabIndex = 4;
            this.btnSetting.Text = "Settings";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // lblContestName
            // 
            this.lblContestName.AutoSize = true;
            this.lblContestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContestName.Location = new System.Drawing.Point(277, 27);
            this.lblContestName.Name = "lblContestName";
            this.lblContestName.Size = new System.Drawing.Size(100, 37);
            this.lblContestName.TabIndex = 5;
            this.lblContestName.Text = "label1";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(575, 40);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(51, 20);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "label1";
            // 
            // frmOrganizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 405);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblContestName);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnResults);
            this.Controls.Add(this.btnEntry);
            this.Controls.Add(this.btnVoters);
            this.Controls.Add(this.btnUsers);
            this.Name = "frmOrganizer";
            this.Text = "frmOrganizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnVoters;
        private System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Label lblContestName;
        private System.Windows.Forms.Label lblDate;

        public Label LblContestName
        {
            get
            {
                return lblContestName;
            }

            set
            {
                lblContestName = value;
            }
        }
    }
}