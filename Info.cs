using System.Windows.Forms;

namespace CWT
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();

            version.Text = "Version: " + System.Reflection.Assembly.GetEntryAssembly().GetName().Version;

        }

        private void web_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://unckel.de/tools/kalenderwoche");
        }
    }
}
