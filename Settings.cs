using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace CWT
{
    public partial class Settings : Form
    {

        private RegKey RegKey = new RegKey();


        public class ComboboxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        public ComboboxItem GetItem(ComboBox Country, string RegKyCulture)
        {
            CultureInfo CustomCulture = new CultureInfo(Int16.Parse(RegKyCulture));

            foreach (ComboboxItem i in Country.Items)
            {

                if (i.Value == CustomCulture.LCID)
                {
                    return (i);
                }
            }
            return null;

        }

        public Settings()
        {
            InitializeComponent();
            GetSettings();


        }

        private void GetSettings()
        {


            Color FontColor = System.Drawing.ColorTranslator.FromHtml(RegKey.GetRegKey("FontColor"));
            Color BgColor = System.Drawing.ColorTranslator.FromHtml(RegKey.GetRegKey("BgColor"));
            CurrentFontColor.BackColor = FontColor;
            CurrentBackgroundColor.BackColor = BgColor;
            FontColorDialog.Color = FontColor;
            BackgroundColorDialog.Color = BgColor;
            CurrentCulture.Text = CultureInfo.CurrentCulture.EnglishName;

            foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = ci.EnglishName;
                item.Value = ci.LCID;
                Country.Items.Add(item);
            }



            if (RegKey.GetRegKey("TransparentBackground") == "1")
            {
                TransparentBackground.Checked = true;
            }
            else {
                TransparentBackground.Checked = false;
            }

            if (RegKey.GetRegKey("Autorun") == "1")
            {
                Autorun.Text = "Autorun is Enabled";
                Autorun.Checked = true;

            }
            else
            {
                Autorun.Text = "Autorun is Disabled";
            }

            if (RegKey.CheckRegKey("CustomCulture"))
            {
                ChangeCulture.Checked = true;
            }

        }


        private void ChangeBackgroundColor_Click(object sender, EventArgs e)
        {
            if (BackgroundColorDialog.ShowDialog() == DialogResult.OK)
            {
                CurrentBackgroundColor.BackColor = BackgroundColorDialog.Color;

            }
        }

        private void ChangeFontColor_Click(object sender, EventArgs e)
        {
            if (FontColorDialog.ShowDialog() == DialogResult.OK)
            {
                CurrentFontColor.BackColor = FontColorDialog.Color;

            }
        }



        private void SaveColors_Click(object sender, EventArgs e)
        {
            RegKey.SetRegKey("FontColor", "#" + (FontColorDialog.Color.ToArgb() & 0x00FFFFFF).ToString("X6"));
            RegKey.SetRegKey("BgColor", "#" + (BackgroundColorDialog.Color.ToArgb() & 0x00FFFFFF).ToString("X6"));

            if (TransparentBackground.Checked == true)
            {
                RegKey.SetRegKey("TransparentBackground", "1");
            }
            else
            {
                RegKey.SetRegKey("TransparentBackground", "0");
            }

            MessageBox.Show(" Color Settings were changed", "Information",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void RestoreDefault_Click(object sender, EventArgs e)
        {
            RegKey.SetRegKey("FontColor", "#000");
            RegKey.SetRegKey("BgColor", "#fff");
            RegKey.SetRegKey("TransparentBackground", "0");
            GetSettings();
            MessageBox.Show("Default Color Settings were changed", "Information",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void SaveAutorun_Click(object sender, EventArgs e)
        {
            if (Autorun.Checked == true)
            {
                RegKey.SetRegKey("Autorun", "1");
            }
            else
            {
                RegKey.SetRegKey("Autorun", "0");
            }
            GetSettings();
            MessageBox.Show(" Autorun Settings were changed", "Information",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }





        private void ChangeCulture_CheckedChanged(object sender, EventArgs e)
        {
            if (ChangeCulture.Checked == true)
            {
                Country.Visible = true;
                if (RegKey.CheckRegKey("CustomCulture"))
                {
                    Country.SelectedItem = GetItem(Country, RegKey.GetRegKey("CustomCulture"));

                }
                else
                {
                    Country.SelectedItem = GetItem(Country, CultureInfo.CurrentCulture.LCID.ToString());

                }

            }
            else
            {
                Country.Visible = false;
            }
        }

        private void SaveCulture_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChangeCulture.Checked == false)
                {
                    RegKey.DeleteRegKey("CustomCulture");
                }
                else
                {
                    RegKey.SetRegKey("CustomCulture", (Country.SelectedItem as ComboboxItem).Value.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong :-(", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MessageBox.Show(" Time Settings were changed", "Information",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}

