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
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.btnUsers.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUsers.Location = new System.Drawing.Point(31, 101);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(146, 58);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnVoters
            // 
            this.btnVoters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.btnVoters.FlatAppearance.BorderSize = 0;
            this.btnVoters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoters.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.btnVoters.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVoters.Location = new System.Drawing.Point(186, 167);
            this.btnVoters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVoters.Name = "btnVoters";
            this.btnVoters.Size = new System.Drawing.Size(146, 58);
            this.btnVoters.TabIndex = 1;
            this.btnVoters.Text = "Voter";
            this.btnVoters.UseVisualStyleBackColor = false;
            this.btnVoters.Click += new System.EventHandler(this.btnVoters_Click);
            // 
            // btnEntry
            // 
            this.btnEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.btnEntry.FlatAppearance.BorderSize = 0;
            this.btnEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntry.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.btnEntry.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEntry.Location = new System.Drawing.Point(31, 167);
            this.btnEntry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(146, 58);
            this.btnEntry.TabIndex = 2;
            this.btnEntry.Text = "Entry";
            this.btnEntry.UseVisualStyleBackColor = false;
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
            // 
            // btnResults
            // 
            this.btnResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.btnResults.FlatAppearance.BorderSize = 0;
            this.btnResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResults.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.btnResults.ForeColor = System.Drawing.SystemColors.Control;
            this.btnResults.Location = new System.Drawing.Point(186, 101);
            this.btnResults.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(146, 58);
            this.btnResults.TabIndex = 3;
            this.btnResults.Text = "Results";
            this.btnResults.UseVisualStyleBackColor = false;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.btnSetting.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSetting.Location = new System.Drawing.Point(31, 234);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(146, 58);
            this.btnSetting.TabIndex = 4;
            this.btnSetting.Text = "Settings";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // lblContestName
            // 
            this.lblContestName.AutoSize = true;
            this.lblContestName.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContestName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblContestName.Location = new System.Drawing.Point(128, 13);
            this.lblContestName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContestName.Name = "lblContestName";
            this.lblContestName.Size = new System.Drawing.Size(130, 26);
            this.lblContestName.TabIndex = 5;
            this.lblContestName.Text = "ContestName";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.lblDate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDate.Location = new System.Drawing.Point(90, 54);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 15);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Corbel", 9.75F);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogout.Location = new System.Drawing.Point(186, 234);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(146, 58);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmOrganizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(362, 327);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblContestName);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnResults);
            this.Controls.Add(this.btnEntry);
            this.Controls.Add(this.btnVoters);
            this.Controls.Add(this.btnUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmOrganizer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private Button btnLogout;

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

        public Button BtnVoters
        {
            get
            {
                return btnVoters;
            }

            set
            {
                btnVoters = value;
            }
        }

        public Button BtnSetting
        {
            get
            {
                return btnSetting;
            }

            set
            {
                btnSetting = value;
            }
        }

        public Label LblDate
        {
            get
            {
                return lblDate;
            }

            set
            {
                lblDate = value;
            }
        }

        public Button BtnEntry
        {
            get
            {
                return btnEntry;
            }

            set
            {
                btnEntry = value;
            }
        }

        public Button BtnUsers
        {
            get
            {
                return btnUsers;
            }

            set
            {
                btnUsers = value;
            }
        }
    }
}