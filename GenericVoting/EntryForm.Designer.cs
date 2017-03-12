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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entry:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // lviEntry
            // 
            this.lviEntry.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lviEntry.FullRowSelect = true;
            this.lviEntry.Location = new System.Drawing.Point(41, 35);
            this.lviEntry.Name = "lviEntry";
            this.lviEntry.Size = new System.Drawing.Size(498, 203);
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
            this.btnADDEntry.Location = new System.Drawing.Point(83, 370);
            this.btnADDEntry.Name = "btnADDEntry";
            this.btnADDEntry.Size = new System.Drawing.Size(131, 57);
            this.btnADDEntry.TabIndex = 3;
            this.btnADDEntry.Text = "ADD ENTRY";
            this.btnADDEntry.UseVisualStyleBackColor = true;
            this.btnADDEntry.Click += new System.EventHandler(this.btnADDEntry_Click);
            // 
            // btnDeleteEntry
            // 
            this.btnDeleteEntry.Location = new System.Drawing.Point(243, 370);
            this.btnDeleteEntry.Name = "btnDeleteEntry";
            this.btnDeleteEntry.Size = new System.Drawing.Size(123, 57);
            this.btnDeleteEntry.TabIndex = 4;
            this.btnDeleteEntry.Text = "Delete Entry";
            this.btnDeleteEntry.UseVisualStyleBackColor = true;
            this.btnDeleteEntry.Click += new System.EventHandler(this.btnDeleteEntry_Click);
            // 
            // txtEntry
            // 
            this.txtEntry.Location = new System.Drawing.Point(147, 244);
            this.txtEntry.Name = "txtEntry";
            this.txtEntry.Size = new System.Drawing.Size(100, 26);
            this.txtEntry.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(416, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 57);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(147, 276);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(354, 64);
            this.txtDes.TabIndex = 9;
            this.txtDes.Text = "";
            // 
            // btnEntry
            // 
            this.btnEntry.Location = new System.Drawing.Point(2, 370);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(75, 56);
            this.btnEntry.TabIndex = 10;
            this.btnEntry.Text = "New Entry";
            this.btnEntry.UseVisualStyleBackColor = true;
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 439);
            this.Controls.Add(this.btnEntry);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtEntry);
            this.Controls.Add(this.btnDeleteEntry);
            this.Controls.Add(this.btnADDEntry);
            this.Controls.Add(this.lviEntry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EntryForm";
            this.Text = "EntryForm";
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