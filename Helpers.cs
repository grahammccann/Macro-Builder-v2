using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroBuilderV2
{
    class Helpers
    {
        public const string app_title = "Macro Builder v2 - [ rankjester.com ]";

        /// <summary>
        /// This function returns all messages generically.
        /// </summary>
        /// <param name="message"></param>
        public static void ReturnMessage(string message)
        {
            MessageBox.Show(message, app_title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// This function tries to predict what the 4th value in the macro might be.
        /// </summary>
        /// <param name="inputValue"></param>
        /// <returns></returns>
        public static string PredictValue(string inputValue)
        {
            //ReturnMessage(inputValue);
            string returnValue = "";
            inputValue = inputValue.ToLower();

            Dictionary<string, string> values = new Dictionary<string, string>();

            var lines = File.ReadAllLines(@"LogicFiles\rj-ai-fields.txt");
            for (var i = 0; i < lines.Length - 1; i++)
            {
                string line = lines[i];
                if (line.StartsWith("#"))
                {
                    string[] keys = line.Remove(0, 1).Split('|');
                    string value = lines[i + 1];
                    foreach (string key in keys)
                    {
                        values.Add(key, value);
                    }
                }
            }

            var foundKey = values.Keys.FirstOrDefault(key => inputValue.Contains(key));
            if (foundKey != null)
                returnValue = values[foundKey];

            return returnValue;
        }

        /// <summary>
        /// This function gets the root of the url.
        /// </summary>
        /// <param name="inputDomain"></param>
        /// <returns></returns>
        public static string GetRootUrl(string inputDomain)
        {
            var uri = new Uri(inputDomain);
            return uri.Host.Replace("www.", "");
        }

        /// <summary>
        /// This function tries to fill in using real credentials the form when AutoFill is pressed.
        /// </summary>
        /// <param name="account"></param>
        /// <param name="inputValue"></param>
        /// <returns></returns>
        public static string GetAccountDetails(string account, string inputValue)
        {
            string[] macro = account.Split('|');
            var u = macro[0];
            var p = macro[1];
            var e = macro[2];
            string r;

            if (inputValue == "USERNAME")
            {
                r = u;
            }
            else if (inputValue == "PASSWORD")
            {
                r = p;
            }
            else if (inputValue == "EMAIL")
            {
                r = e;
            }
            else {
                r = "";
            }
            return r;
        }

    } // end.

} // end.
