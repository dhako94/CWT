using Microsoft.Win32;
using System;
using System.IO;
using System.Windows.Forms;

namespace CWT
{
    class Autorun
    {


        public void EnableAutorun()
        {
         string exePath = Application.ExecutablePath;
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            if (key.GetValue("CWT", null) == null)
            {
                key.SetValue("CWT", exePath);
            }



        }

        public void DisableAutorun()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            if (key.GetValue("CWT", null) != null)
            {
                key.DeleteValue("CWT");
            }

        }


    }
}
