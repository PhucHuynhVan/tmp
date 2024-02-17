using Clean.WinF.Shared.Constants;
using Microsoft.Win32;
using System;

namespace Clean.WinF.Common.Utilities
{
    public static class RegUtility
    {
        public static void CreateRegistryKey(string parentKey, string name, string value)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(parentKey);
            if (key is null)
            {
                RegistryKey addKey = Registry.CurrentUser.CreateSubKey(parentKey);
                addKey.SetValue(name, value);
                addKey.Close();
            }
            else
            {
                key.SetValue(name, value);
                key.Close();
            }
        }

        public static bool IsExistingLicenseKey(string encryptKey, string encryptIV)
        {
            var result = false;

            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\\" + RegistryKeyConstants.OrganizationName + "\\" + RegistryKeyConstants.ProductName);
            if (key != null)
            {
                var usedDays = key.GetValue(RegistryKeyConstants.UsageOfDays);
                var trialKey = key.GetValue(RegistryKeyConstants.IsTrial);
                int.TryParse(EncryptUtility.DecryptString(usedDays.ToString(), encryptKey, encryptIV), out int validDays);
                int.TryParse(EncryptUtility.DecryptString(trialKey.ToString(), encryptKey, encryptIV), out int isTrialLicense);

                if (validDays > 0 || isTrialLicense >= 0)
                    return true;

                key.Close();
            }
            return result;
        }

        public static bool IsInvalidLicense(string encryptKey, string encryptIV)
        {
            var result = false;
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\\" + RegistryKeyConstants.OrganizationName + "\\" + RegistryKeyConstants.ProductName);
            if (key != null)
            {
                var currDate = DateTime.Now;
                var installedDate = key.GetValue(RegistryKeyConstants.RegisteredDate);
                var usedDays = key.GetValue(RegistryKeyConstants.UsageOfDays);
                var trialKey = key.GetValue(RegistryKeyConstants.IsTrial);

                DateTime.TryParse(EncryptUtility.DecryptString(installedDate.ToString(), encryptKey, encryptIV), out DateTime installedDateValue);
                int.TryParse(EncryptUtility.DecryptString(usedDays.ToString(), encryptKey, encryptIV), out int validDays);
                int.TryParse(EncryptUtility.DecryptString(trialKey.ToString(), encryptKey, encryptIV), out int isTrialLicense);

                TimeSpan duration = currDate - installedDateValue;
                int numberOfDays = duration.Days;

                if (isTrialLicense > 0)
                {
                    if (numberOfDays <= validDays)
                        return true;
                }
                else
                {
                    var licenseKey = key.GetValue(RegistryKeyConstants.LicenseKey);
                    if (licenseKey != null && licenseKey.ToString().Length > 0)
                    {
                        if (numberOfDays <= validDays)
                            return true;
                    }
                }

                key.Close();
            }
            return false;
        }

        public static bool IsTrialLicenseKey(string encryptKey, string encryptIV)
        {
            var result = false;

            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\\" + RegistryKeyConstants.OrganizationName + "\\" + RegistryKeyConstants.ProductName);
            if (key != null)
            {
                var trialKey = key.GetValue(RegistryKeyConstants.IsTrial);
                int.TryParse(EncryptUtility.DecryptString(trialKey.ToString(), encryptKey, encryptIV), out int isTrialLicense);
                if (isTrialLicense > 0)
                {
                    result = true;
                }
                key.Close();
            }

            return result;
        }

        public static string GetRemainingDaysTrial(string encryptKey, string encryptIV)
        {
            var result = string.Empty;

            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\\" + RegistryKeyConstants.OrganizationName + "\\" + RegistryKeyConstants.ProductName);
            if (key != null)
            {
                var currDate = DateTime.Now;

                var installedDate = key.GetValue(RegistryKeyConstants.RegisteredDate);
                var usedDays = key.GetValue(RegistryKeyConstants.UsageOfDays);
                var trialKey = key.GetValue(RegistryKeyConstants.IsTrial);

                DateTime.TryParse(EncryptUtility.DecryptString(installedDate.ToString(), encryptKey, encryptIV), out DateTime installedDateValue);
                int.TryParse(EncryptUtility.DecryptString(usedDays.ToString(), encryptKey, encryptIV), out int validDays);
                int.TryParse(EncryptUtility.DecryptString(trialKey.ToString(), encryptKey, encryptIV), out int isTrialLicense);

                var duration = currDate - installedDateValue;
                int numberOfDays = duration.Days;
                result = ((validDays - numberOfDays) + 1) > 1 ? (validDays - numberOfDays).ToString() : "0";
                key.Close();
            }

            return result;
        }

        public static string GetLicenseKey(string encryptKey, string encryptIV)
        {
            var result = string.Empty;

            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\\" + RegistryKeyConstants.OrganizationName + "\\" + RegistryKeyConstants.ProductName);
            if (key != null)
            {
                result = EncryptUtility.DecryptString(key.GetValue(RegistryKeyConstants.LicenseKey).ToString(), encryptKey, encryptIV);
                key.Close();
            }

            return result;
        }
    }
}
