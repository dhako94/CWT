
namespace CWT
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabColors = new System.Windows.Forms.TabPage();
            this.RestoreDefault = new System.Windows.Forms.Button();
            this.TransparentBackground = new System.Windows.Forms.CheckBox();
            this.SaveColors = new System.Windows.Forms.Button();
            this.CurrentBackgroundColor = new System.Windows.Forms.Label();
            this.ChangeBackgroundColor = new System.Windows.Forms.Button();
            this.ChangeFontColor = new System.Windows.Forms.Button();
            this.CurrentFontColor = new System.Windows.Forms.Label();
            this.tabTimeSettings = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.ComboBox();
            this.SaveCulture = new System.Windows.Forms.Button();
            this.ChangeCulture = new System.Windows.Forms.CheckBox();
            this.CurrentCulture = new System.Windows.Forms.Label();
            this.CurrentCultureInfo = new System.Windows.Forms.Label();
            this.tabAutorun = new System.Windows.Forms.TabPage();
            this.SaveAutorun = new System.Windows.Forms.Button();
            this.Autorun = new System.Windows.Forms.CheckBox();
            this.FontColorDialog = new System.Windows.Forms.ColorDialog();
            this.BackgroundColorDialog = new System.Windows.Forms.ColorDialog();
            this.tabControl1.SuspendLayout();
            this.tabColors.SuspendLayout();
            this.tabTimeSettings.SuspendLayout();
            this.tabAutorun.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabColors);
            this.tabControl1.Controls.Add(this.tabTimeSettings);
            this.tabControl1.Controls.Add(this.tabAutorun);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(410, 263);
            this.tabControl1.TabIndex = 0;
            // 
            // tabColors
            // 
            this.tabColors.Controls.Add(this.RestoreDefault);
            this.tabColors.Controls.Add(this.TransparentBackground);
            this.tabColors.Controls.Add(this.SaveColors);
            this.tabColors.Controls.Add(this.CurrentBackgroundColor);
            this.tabColors.Controls.Add(this.ChangeBackgroundColor);
            this.tabColors.Controls.Add(this.ChangeFontColor);
            this.tabColors.Controls.Add(this.CurrentFontColor);
            this.tabColors.Location = new System.Drawing.Point(4, 22);
            this.tabColors.Name = "tabColors";
            this.tabColors.Padding = new System.Windows.Forms.Padding(3);
            this.tabColors.Size = new System.Drawing.Size(402, 237);
            this.tabColors.TabIndex = 0;
            this.tabColors.Text = "Colors";
            this.tabColors.UseVisualStyleBackColor = true;
            // 
            // RestoreDefault
            // 
            this.RestoreDefault.Location = new System.Drawing.Point(278, 186);
            this.RestoreDefault.Name = "RestoreDefault";
            this.RestoreDefault.Size = new System.Drawing.Size(91, 23);
            this.RestoreDefault.TabIndex = 8;
            this.RestoreDefault.Text = "Restore Default";
            this.RestoreDefault.UseVisualStyleBackColor = true;
            this.RestoreDefault.Click += new System.EventHandler(this.RestoreDefault_Click);
            // 
            // TransparentBackground
            // 
            this.TransparentBackground.AutoSize = true;
            this.TransparentBackground.Location = new System.Drawing.Point(19, 108);
            this.TransparentBackground.Name = "TransparentBackground";
            this.TransparentBackground.Size = new System.Drawing.Size(144, 17);
            this.TransparentBackground.TabIndex = 7;
            this.TransparentBackground.Text = "Transparent Background";
            this.TransparentBackground.UseVisualStyleBackColor = true;
            // 
            // SaveColors
            // 
            this.SaveColors.Location = new System.Drawing.Point(19, 186);
            this.SaveColors.Name = "SaveColors";
            this.SaveColors.Size = new System.Drawing.Size(75, 23);
            this.SaveColors.TabIndex = 6;
            this.SaveColors.Text = "Save";
            this.SaveColors.UseVisualStyleBackColor = true;
            this.SaveColors.Click += new System.EventHandler(this.SaveColors_Click);
            // 
            // CurrentBackgroundColor
            // 
            this.CurrentBackgroundColor.Location = new System.Drawing.Point(179, 68);
            this.CurrentBackgroundColor.Margin = new System.Windows.Forms.Padding(10);
            this.CurrentBackgroundColor.Name = "CurrentBackgroundColor";
            this.CurrentBackgroundColor.Size = new System.Drawing.Size(73, 27);
            this.CurrentBackgroundColor.TabIndex = 5;
            // 
            // ChangeBackgroundColor
            // 
            this.ChangeBackgroundColor.Location = new System.Drawing.Point(19, 65);
            this.ChangeBackgroundColor.Margin = new System.Windows.Forms.Padding(10);
            this.ChangeBackgroundColor.Name = "ChangeBackgroundColor";
            this.ChangeBackgroundColor.Size = new System.Drawing.Size(140, 30);
            this.ChangeBackgroundColor.TabIndex = 4;
            this.ChangeBackgroundColor.Text = "Change Background Color";
            this.ChangeBackgroundColor.UseVisualStyleBackColor = true;
            this.ChangeBackgroundColor.Click += new System.EventHandler(this.ChangeBackgroundColor_Click);
            // 
            // ChangeFontColor
            // 
            this.ChangeFontColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeFontColor.Location = new System.Drawing.Point(19, 20);
            this.ChangeFontColor.Margin = new System.Windows.Forms.Padding(10);
            this.ChangeFontColor.Name = "ChangeFontColor";
            this.ChangeFontColor.Size = new System.Drawing.Size(140, 30);
            this.ChangeFontColor.TabIndex = 1;
            this.ChangeFontColor.Text = "Change Font Color";
            this.ChangeFontColor.UseVisualStyleBackColor = true;
            this.ChangeFontColor.Click += new System.EventHandler(this.ChangeFontColor_Click);
            // 
            // CurrentFontColor
            // 
            this.CurrentFontColor.Location = new System.Drawing.Point(179, 23);
            this.CurrentFontColor.Margin = new System.Windows.Forms.Padding(10);
            this.CurrentFontColor.Name = "CurrentFontColor";
            this.CurrentFontColor.Size = new System.Drawing.Size(73, 27);
            this.CurrentFontColor.TabIndex = 0;
            // 
            // tabTimeSettings
            // 
            this.tabTimeSettings.Controls.Add(this.label1);
            this.tabTimeSettings.Controls.Add(this.Country);
            this.tabTimeSettings.Controls.Add(this.SaveCulture);
            this.tabTimeSettings.Controls.Add(this.ChangeCulture);
            this.tabTimeSettings.Controls.Add(this.CurrentCulture);
            this.tabTimeSettings.Controls.Add(this.CurrentCultureInfo);
            this.tabTimeSettings.Location = new System.Drawing.Point(4, 22);
            this.tabTimeSettings.Name = "tabTimeSettings";
            this.tabTimeSettings.Size = new System.Drawing.Size(402, 237);
            this.tabTimeSettings.TabIndex = 3;
            this.tabTimeSettings.Text = "Time Settings";
            this.tabTimeSettings.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "This value is used to calculate the calendar week";
            // 
            // Country
            // 
            this.Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Country.FormattingEnabled = true;
            this.Country.Location = new System.Drawing.Point(19, 90);
            this.Country.Margin = new System.Windows.Forms.Padding(5);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(362, 21);
            this.Country.Sorted = true;
            this.Country.TabIndex = 6;
            this.Country.Visible = false;
            // 
            // SaveCulture
            // 
            this.SaveCulture.Location = new System.Drawing.Point(19, 186);
            this.SaveCulture.Name = "SaveCulture";
            this.SaveCulture.Size = new System.Drawing.Size(75, 23);
            this.SaveCulture.TabIndex = 5;
            this.SaveCulture.Text = "Save";
            this.SaveCulture.UseVisualStyleBackColor = true;
            this.SaveCulture.Click += new System.EventHandler(this.SaveCulture_Click);
            // 
            // ChangeCulture
            // 
            this.ChangeCulture.AutoSize = true;
            this.ChangeCulture.Location = new System.Drawing.Point(20, 63);
            this.ChangeCulture.Margin = new System.Windows.Forms.Padding(5);
            this.ChangeCulture.Name = "ChangeCulture";
            this.ChangeCulture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChangeCulture.Size = new System.Drawing.Size(99, 17);
            this.ChangeCulture.TabIndex = 2;
            this.ChangeCulture.Text = "Change Culture";
            this.ChangeCulture.UseVisualStyleBackColor = true;
            this.ChangeCulture.CheckedChanged += new System.EventHandler(this.ChangeCulture_CheckedChanged);
            // 
            // CurrentCulture
            // 
            this.CurrentCulture.AutoSize = true;
            this.CurrentCulture.Location = new System.Drawing.Point(149, 40);
            this.CurrentCulture.Margin = new System.Windows.Forms.Padding(2, 0, 3, 0);
            this.CurrentCulture.Name = "CurrentCulture";
            this.CurrentCulture.Size = new System.Drawing.Size(0, 13);
            this.CurrentCulture.TabIndex = 1;
            // 
            // CurrentCultureInfo
            // 
            this.CurrentCultureInfo.AutoSize = true;
            this.CurrentCultureInfo.Location = new System.Drawing.Point(19, 40);
            this.CurrentCultureInfo.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.CurrentCultureInfo.Name = "CurrentCultureInfo";
            this.CurrentCultureInfo.Size = new System.Drawing.Size(127, 13);
            this.CurrentCultureInfo.TabIndex = 0;
            this.CurrentCultureInfo.Text = "Current System Culture is:";
            // 
            // tabAutorun
            // 
            this.tabAutorun.Controls.Add(this.SaveAutorun);
            this.tabAutorun.Controls.Add(this.Autorun);
            this.tabAutorun.Location = new System.Drawing.Point(4, 22);
            this.tabAutorun.Name = "tabAutorun";
            this.tabAutorun.Size = new System.Drawing.Size(402, 237);
            this.tabAutorun.TabIndex = 4;
            this.tabAutorun.Text = "Autorun";
            this.tabAutorun.UseVisualStyleBackColor = true;
            // 
            // SaveAutorun
            // 
            this.SaveAutorun.Location = new System.Drawing.Point(19, 186);
            this.SaveAutorun.Name = "SaveAutorun";
            this.SaveAutorun.Size = new System.Drawing.Size(75, 23);
            this.SaveAutorun.TabIndex = 1;
            this.SaveAutorun.Text = "Save";
            this.SaveAutorun.UseVisualStyleBackColor = true;
            this.SaveAutorun.Click += new System.EventHandler(this.SaveAutorun_Click);
            // 
            // Autorun
            // 
            this.Autorun.Location = new System.Drawing.Point(19, 20);
            this.Autorun.Name = "Autorun";
            this.Autorun.Size = new System.Drawing.Size(352, 24);
            this.Autorun.TabIndex = 0;
            this.Autorun.UseVisualStyleBackColor = true;
            // 
            // FontColorDialog
            // 
            this.FontColorDialog.AnyColor = true;
            this.FontColorDialog.FullOpen = true;
            // 
            // BackgroundColorDialog
            // 
            this.BackgroundColorDialog.AnyColor = true;
            this.BackgroundColorDialog.FullOpen = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 261);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.tabControl1.ResumeLayout(false);
            this.tabColors.ResumeLayout(false);
            this.tabColors.PerformLayout();
            this.tabTimeSettings.ResumeLayout(false);
            this.tabTimeSettings.PerformLayout();
            this.tabAutorun.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabColors;
        private System.Windows.Forms.TabPage tabTimeSettings;
        private System.Windows.Forms.TabPage tabAutorun;
        private System.Windows.Forms.Label CurrentFontColor;
        private System.Windows.Forms.Button ChangeFontColor;
        private System.Windows.Forms.Button ChangeBackgroundColor;
        private System.Windows.Forms.Label CurrentBackgroundColor;
        private System.Windows.Forms.ColorDialog FontColorDialog;
        private System.Windows.Forms.ColorDialog BackgroundColorDialog;
        private System.Windows.Forms.Button SaveColors;
        private System.Windows.Forms.CheckBox TransparentBackground;
        private System.Windows.Forms.Button RestoreDefault;
        private System.Windows.Forms.CheckBox Autorun;
        private System.Windows.Forms.Button SaveAutorun;
        private System.Windows.Forms.Label CurrentCulture;
        private System.Windows.Forms.Label CurrentCultureInfo;
        private System.Windows.Forms.CheckBox ChangeCulture;
        private System.Windows.Forms.Button SaveCulture;
        private System.Windows.Forms.ComboBox Country;
        private System.Windows.Forms.Label label1;
    }
}