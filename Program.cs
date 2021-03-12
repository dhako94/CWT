using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Threading;


namespace CWT
{
    //Run Programm
    static class Program
    {


        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Mutex mutex = new System.Threading.Mutex(false, "CWT");
            try
            {
                if (mutex.WaitOne(0, false))
                {
                    // Run the application
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new CWTNotify());
                }
                else
                {
                    MessageBox.Show("An instance of the application is already running.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            finally
            {
                if (mutex != null)
                {
                    mutex.Close();
                    mutex = null;
                }
            }

        }
    }


    //NotifyIcon Programm
    public class CWTNotify : ApplicationContext
    {
        //Variables
        private NotifyIcon trayIcon;
        private RegKey RegKey = new RegKey();
        private Autorun Autorun = new Autorun();
        private System.Windows.Forms.Timer timer1;
        private Color FontColor;
        private Color BgColor;
        private CultureInfo Culture;


        private void GetSettings()
        {

            FontColor = System.Drawing.ColorTranslator.FromHtml(RegKey.GetRegKey("FontColor"));

            if (RegKey.GetRegKey("TransparentBackground") == "1")
            {
                BgColor = Color.Transparent;
            }
            else
            {
                BgColor = System.Drawing.ColorTranslator.FromHtml(RegKey.GetRegKey("BgColor"));
            }

            if (RegKey.GetRegKey("Autorun") == "1")
            {
                Autorun.EnableAutorun();
            }
            else
            {
                Autorun.DisableAutorun();
            }

            if (RegKey.CheckRegKey("CustomCulture"))
            {


                try
                {
                    Culture = new CultureInfo(Int16.Parse(RegKey.GetRegKey("CustomCulture")));

                }
                catch
                {
                    RegKey.DeleteRegKey("CustomCulture");
                    Culture = CultureInfo.CurrentCulture;
                }

            }
            else
            {

                Culture = CultureInfo.CurrentCulture;
            }



        }

        //StartNotify
        public CWTNotify()
        {


            // Initialize Tray Icon
            trayIcon = new NotifyIcon()
            {

                ContextMenu = new ContextMenu(new MenuItem[] {
                new MenuItem("Settings", Settings),
                new MenuItem("Info", Info),
                new MenuItem("Exit", Exit)

            }),
                Visible = true
            };

            // Create the CWT Reg Key
            RegKey.CreateRegKeys();
            //Get ICON Settings
            GetSettings();

            //Create ICON
            CreateTextIcon(GetWeekNum(), FontColor, BgColor);

            //Initalize Timer
            InitTimer();
            trayIcon.Text = "Current calendar week";






        }



        //Update TextIcon Timer
        private void InitTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(UpdateTextIcon);
            timer1.Interval = 2000; // in miliseconds
            timer1.Start();
        }

        //Update Text Icon
        private void UpdateTextIcon(object sender, EventArgs e)
        {
            //Get ICON Settings
            GetSettings();
            //Create ICON
            CreateTextIcon(GetWeekNum(), FontColor, BgColor);
        }


        //Get Week Number
        private string GetWeekNum()
        {
            // Gets the Calendar instance associated with a CultureInfo.

            CultureInfo myCI = Culture;
            Calendar myCal = myCI.Calendar;

            // Gets the DTFI properties required by GetWeekOfYear.
            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;

            // Displays the number of the current week relative to the beginning of the year.
            return (myCal.GetWeekOfYear(DateTime.Now, myCWR, myFirstDOW).ToString());
        }


        // Create Icon
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool DestroyIcon(IntPtr hIcon);

        private void CreateTextIcon(string text, Color FontColor, Color BackgroundColor)
        {

            Font fontToUse = new Font("Microsoft Sans Serif", 12, FontStyle.Regular, GraphicsUnit.Pixel);
            Brush brushToUse = new SolidBrush(FontColor);
            Bitmap bitmapText = new Bitmap(16, 16);
            Graphics g = System.Drawing.Graphics.FromImage(bitmapText);
            IntPtr hIcon;
            g.Clear(BackgroundColor);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;

            if (text.Length == 1)
            {
                text = "0" + text;
            }
  
            g.DrawString(text, fontToUse, brushToUse, -1, -1);
            hIcon = (bitmapText.GetHicon());
            if (trayIcon.Icon != null)
            {
                trayIcon.Icon.Dispose();
            }
            trayIcon.Icon = System.Drawing.Icon.FromHandle(hIcon);
            DestroyIcon(hIcon);

        }


        // Loead Forms
        void Settings(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Settings"] as Settings) == null)
            {

                Settings settingsForm = new Settings();
                settingsForm.Show();
            }
            else
            {
                Application.OpenForms["Settings"].Focus();
            }
        }



        void Info(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Info"] as Info) == null)
            {
                Info InfoForm = new Info();
                InfoForm.Show();
            }
            else
            {
                Application.OpenForms["Info"].Focus();
            }
        }


        void Exit(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            trayIcon.Visible = false;
            Application.Exit();
        }

    }
}