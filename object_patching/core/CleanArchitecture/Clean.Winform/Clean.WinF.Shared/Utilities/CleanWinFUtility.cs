using System;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Clean.WinF.Common.Utilities
{
    public static class CleanWinFUtility
    {
        public static string accessToken = string.Empty;
        public static string userNTID = string.Empty;
        public static string[] ConvertStringToArray(string inputValue, string operatorValue)
        {
            string[] arrRet = null;
            string[] arrOperator = { operatorValue };

            if (!string.IsNullOrEmpty(inputValue))
                arrRet = inputValue.Split(arrOperator, StringSplitOptions.None);

            return arrRet;
        }

        public static string GetFullNameAndDepartmentFromLDAPUser(string ldapUserDisplayName, bool isDepartment)
        {
            string nameRet = string.Empty;

            if (!string.IsNullOrEmpty(ldapUserDisplayName))
            {
                var arrDepartName = ConvertStringToArray(ldapUserDisplayName, "(");
                if (arrDepartName != null && arrDepartName.Length > 1)
                {
                    if (isDepartment)
                        nameRet = arrDepartName[1].Trim().Replace("(", string.Empty).Replace(")", string.Empty);
                    else
                        nameRet = arrDepartName[0].Trim();
                }
            }

            return nameRet;
        }

        public static bool HasSpecialCharacters(string inputValue)
        {
            bool result = false;

            var withoutSpecial = new string(inputValue.Where(c => Char.IsLetterOrDigit(c)
                                            || Char.IsWhiteSpace(c)).ToArray());

            if (inputValue != withoutSpecial)
                result = true;

            return result;
        }


        public static bool CheckSpecialCharacter(string text)
        {
            //just allow white space, dot, question symbol, comma, colon, equal, plus and minus characters            
            string pattern = @"[~`@!#$%^&*(){}|\\;/<>\[\]\""']";
            var regex = new Regex(pattern);
            var result = regex.IsMatch(text);
            return result;
        }

        public static string RemoveSpecialCharacter(string text)
        {
            string result = string.Empty;
            //remove special characters in the current text            
            string pattern = @"[^a-zA-Z0-9\-]";
            result = Regex.Replace(text, pattern, string.Empty);
            return result;
        }

        public static bool IsValidEmailAddress(string emailAddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailAddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }




    }
}
