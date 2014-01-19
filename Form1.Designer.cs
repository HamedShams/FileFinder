namespace FileFinder
{
    partial class Form1
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
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.Txt_Ext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.Lbl_Copyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(12, 12);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(244, 29);
            this.Txt_Name.TabIndex = 0;
            this.Txt_Name.TextChanged += new System.EventHandler(this.Txt_Text_TextChanged);
            // 
            // Txt_Ext
            // 
            this.Txt_Ext.Location = new System.Drawing.Point(281, 12);
            this.Txt_Ext.Name = "Txt_Ext";
            this.Txt_Ext.Size = new System.Drawing.Size(48, 29);
            this.Txt_Ext.TabIndex = 1;
            this.Txt_Ext.TextChanged += new System.EventHandler(this.Txt_Ext_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = ".";
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 21;
            this.ListBox.Location = new System.Drawing.Point(12, 56);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(317, 298);
            this.ListBox.Sorted = true;
            this.ListBox.TabIndex = 3;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // Lbl_Copyright
            // 
            this.Lbl_Copyright.AutoSize = true;
            this.Lbl_Copyright.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Copyright.Location = new System.Drawing.Point(12, 359);
            this.Lbl_Copyright.Name = "Lbl_Copyright";
            this.Lbl_Copyright.Size = new System.Drawing.Size(310, 13);
            this.Lbl_Copyright.TabIndex = 4;
            this.Lbl_Copyright.Text = "Developed by Hamed Shams - Hamed.Shams40@Gmail.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(341, 51);
            this.Controls.Add(this.Lbl_Copyright);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Ext);
            this.Controls.Add(this.Txt_Name);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(357, 420);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(357, 90);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "File Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.TextBox Txt_Ext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Label Lbl_Copyright;
    }
}

