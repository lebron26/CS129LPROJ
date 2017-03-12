using System.Windows.Forms;

namespace GenericVoting
{
    partial class EntryForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.lviEntry = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnADDEntry = new System.Windows.Forms.Button();
            this.btnDeleteEntry = new System.Windows.Forms.Button();
            this.txtEntry = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtDes = new System.Windows.Forms.RichTextBox();
            this.btnEntry = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(42, 224);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entry:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 9F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(13, 264);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            // 
            // lviEntry
            // 
            this.lviEntry.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lviEntry.Font = new System.Drawing.Font("Corbel", 9F);
            this.lviEntry.FullRowSelect = true;
            this.lviEntry.Location = new System.Drawing.Point(11, 80);
            this.lviEntry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lviEntry.Name = "lviEntry";
            this.lviEntry.Size = new System.Drawing.Size(425, 133);
            this.lviEntry.TabIndex = 2;
            this.lviEntry.UseCompatibleStateImageBehavior = false;
            this.lviEntry.View = System.Windows.Forms.View.Details;
            this.lviEntry.SelectedIndexChanged += new System.EventHandler(this.lviEntry_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Entry";
            this.columnHeader1.Width = 132;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 303;
            // 
            // btnADDEntry
            // 
            this.btnADDEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.btnADDEntry.FlatAppearance.BorderSize = 0;
            this.btnADDEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADDEntry.Font = new System.Drawing.Font("Corbel", 9F);
            this.btnADDEntry.ForeColor = System.Drawing.SystemColors.Control;
            this.btnADDEntry.Location = new System.Drawing.Point(121, 318);
            this.btnADDEntry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnADDEntry.Name = "btnADDEntry";
            this.btnADDEntry.Size = new System.Drawing.Size(97, 46);
            this.btnADDEntry.TabIndex = 3;
            this.btnADDEntry.Text = "Add Entry";
            this.btnADDEntry.UseVisualStyleBackColor = false;
            this.btnADDEntry.Click += new System.EventHandler(this.btnADDEntry_Click);
            // 
            // btnDeleteEntry
            // 
            this.btnDeleteEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.btnDeleteEntry.FlatAppearance.BorderSize = 0;
            this.btnDeleteEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEntry.Font = new System.Drawing.Font("Corbel", 9F);
            this.btnDeleteEntry.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteEntry.Location = new System.Drawing.Point(230, 318);
            this.btnDeleteEntry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteEntry.Name = "btnDeleteEntry";
            this.btnDeleteEntry.Size = new System.Drawing.Size(97, 46);
            this.btnDeleteEntry.TabIndex = 4;
            this.btnDeleteEntry.Text = "Delete Entry";
            this.btnDeleteEntry.UseVisualStyleBackColor = false;
            this.btnDeleteEntry.Click += new System.EventHandler(this.btnDeleteEntry_Click);
            // 
            // txtEntry
            // 
            this.txtEntry.Font = new System.Drawing.Font("Corbel", 9F);
            this.txtEntry.Location = new System.Drawing.Point(88, 221);
            this.txtEntry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEntry.Name = "txtEntry";
            this.txtEntry.Size = new System.Drawing.Size(68, 22);
            this.txtEntry.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Corbel", 9F);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(339, 318);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 46);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtDes
            // 
            this.txtDes.Font = new System.Drawing.Font("Corbel", 9F);
            this.txtDes.Location = new System.Drawing.Point(88, 250);
            this.txtDes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(282, 54);
            this.txtDes.TabIndex = 9;
            this.txtDes.Text = "";
            // 
            // btnEntry
            // 
            this.btnEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(71)))));
            this.btnEntry.FlatAppearance.BorderSize = 0;
            this.btnEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntry.Font = new System.Drawing.Font("Corbel", 9F);
            this.btnEntry.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEntry.Location = new System.Drawing.Point(11, 319);
            this.btnEntry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(97, 45);
            this.btnEntry.TabIndex = 10;
            this.btnEntry.Text = "New Entry";
            this.btnEntry.UseVisualStyleBackColor = false;
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.label5.Font = new System.Drawing.Font("Corbel", 26.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(163, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 42);
            this.label5.TabIndex = 13;
            this.label5.Text = "Entries";
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(447, 375);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEntry);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtEntry);
            this.Controls.Add(this.btnDeleteEntry);
            this.Controls.Add(this.btnADDEntry);
            this.Controls.Add(this.lviEntry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EntryForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lviEntry;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnADDEntry;
        private System.Windows.Forms.Button btnDeleteEntry;
        private System.Windows.Forms.TextBox txtEntry;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RichTextBox txtDes;
        private System.Windows.Forms.Button btnEntry;
        private Label label5;

        public Button BtnDeleteEntry
        {
            get
            {
                return btnDeleteEntry;
            }

            set
            {
                btnDeleteEntry = value;
            }
        }

        public Button BtnADDEntry
        {
            get
            {
                return btnADDEntry;
            }

            set
            {
                btnADDEntry = value;
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
    }
}