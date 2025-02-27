using Microsoft.Win32;

namespace RegSetting;

public static class RegistrySetting
{
    public static string CurrentUserKey;

    public static string GetRegistryValue(string subkey)
    {
        RegistryKey pgmSetting = Registry.CurrentUser.OpenSubKey(CurrentUserKey, true);
        if (pgmSetting != null)
        {
            string[] subKeyNames = pgmSetting.GetSubKeyNames();
            if (subKeyNames.Contains(subkey))
                return pgmSetting.GetValue(subkey)?.ToString();
            else
                return null;
        }
        else
            return null;
    }

    public static string SetRegistryValue(string subkey, string val)
    {
        RegistryKey pgmSetting = Registry.CurrentUser.OpenSubKey(CurrentUserKey, true);
        if (pgmSetting == null)
        {
            pgmSetting = Registry.CurrentUser;
            pgmSetting.CreateSubKey(CurrentUserKey);
            pgmSetting = Registry.CurrentUser.OpenSubKey(CurrentUserKey, true);
            pgmSetting.CreateSubKey(subkey);
        }
        else
        {
            string[] subKeyNames = pgmSetting.GetSubKeyNames();
            if (!subKeyNames.Contains(subkey))
            {
                pgmSetting = Registry.CurrentUser;
                pgmSetting.CreateSubKey(CurrentUserKey);
                pgmSetting = Registry.CurrentUser.OpenSubKey(CurrentUserKey, true);
                pgmSetting.CreateSubKey(subkey);
            }
        }
        pgmSetting.SetValue(subkey, val);
        return val;
    }
}
