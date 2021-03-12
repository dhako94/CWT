
namespace CWT
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.authors = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.Donate = new System.Windows.Forms.Label();
            this.web = new System.Windows.Forms.LinkLabel();
            this.informations = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // authors
            // 
            this.authors.AutoSize = true;
            this.authors.Location = new System.Drawing.Point(12, 17);
            this.authors.Margin = new System.Windows.Forms.Padding(8);
            this.authors.Name = "authors";
            this.authors.Size = new System.Drawing.Size(226, 13);
            this.authors.TabIndex = 0;
            this.authors.Text = "Authors: Mike Unckel and Dominik Hasenkopf";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(12, 38);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(48, 13);
            this.version.TabIndex = 1;
            this.version.Text = "Version: ";
            // 
            // Donate
            // 
            this.Donate.AutoSize = true;
            this.Donate.Location = new System.Drawing.Point(12, 59);
            this.Donate.Margin = new System.Windows.Forms.Padding(8);
            this.Donate.Name = "Donate";
            this.Donate.Size = new System.Drawing.Size(45, 13);
            this.Donate.TabIndex = 2;
            this.Donate.Text = "Donate:";
            // 
            // web
            // 
            this.web.AutoSize = true;
            this.web.Location = new System.Drawing.Point(55, 59);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(190, 13);
            this.web.TabIndex = 3;
            this.web.TabStop = true;
            this.web.Text = "http://unckel.de/tools/kalenderwoche\r\n";
            this.web.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.web_LinkClicked);
            // 
            // informations
            // 
            this.informations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informations.Location = new System.Drawing.Point(15, 84);
            this.informations.Name = "informations";
            this.informations.Size = new System.Drawing.Size(257, 68);
            this.informations.TabIndex = 4;
            this.informations.Text = "This is a hobby project.\r\nIf you have ideas or something doesn\'t work, please let" +
    " us know ;-)";
            this.informations.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.informations);
            this.Controls.Add(this.web);
            this.Controls.Add(this.Donate);
            this.Controls.Add(this.version);
            this.Controls.Add(this.authors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label authors;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label Donate;
        private System.Windows.Forms.LinkLabel web;
        private System.Windows.Forms.Label informations;
    }
}