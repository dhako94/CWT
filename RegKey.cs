using Microsoft.Win32;

namespace CWT
{
    class RegKey
    {

        public void CreateRegKeys()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
            key.CreateSubKey("CWT");
            key = key.OpenSubKey("CWT", true);

            if (key.GetValue("FontColor", null) == null)
            {
                key.SetValue("FontColor", "#000");
            }

            if (key.GetValue("BgColor", null) == null)
            {
                key.SetValue("BgColor", "#fff");
            }

            if (key.GetValue("TransparentBackground", null) == null)
            {
                key.SetValue("TransparentBackground", "0");
            }

            if (key.GetValue("Autorun", null) == null)
            {
                key.SetValue("Autorun", "1");
            }







        }

        // Get RegKey
        public string GetRegKey(string KeyName)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true).OpenSubKey("CWT", true);
            return (key.GetValue(KeyName).ToString());

        }

        // Check Regkey
        public bool CheckRegKey(string KeyName)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true).OpenSubKey("CWT", true);

            if ((key.GetValue(KeyName, null)) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void SetRegKey(string KeyName, string val)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
            key.CreateSubKey("CWT");
            key = key.OpenSubKey("CWT", true);
            key.SetValue(KeyName, val);


        }

        public void DeleteRegKey(string KeyName)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
            key.CreateSubKey("CWT");
            key = key.OpenSubKey("CWT", true);
            if (key.GetValue(KeyName, null) != null)
            {
                key.DeleteValue(KeyName);
            }
        }


    }
}
