using HtmlAgilityPack;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroBuilderV2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ReLoadMacroFiles()
        {
            comboBoxLoadMacros.Items.Clear();
            string[] txt_files = Directory.GetFiles(@"Macros\", "*.txt");

            foreach (string macro_file in txt_files)
            {
                comboBoxLoadMacros.Items.Add(Path.GetFileName(macro_file));
            }
        }

        public void UseLatestIE() {
            // use the latest version of IE ...
            int BrowserVer, RegVal;

            // get the installed IE version ...
            using (WebBrowser Wb = new WebBrowser())
                BrowserVer = Wb.Version.Major;

            // set the appropriate IE version ...
            if (BrowserVer >= 11)
                RegVal = 11001;
            else if (BrowserVer == 10)
                RegVal = 10001;
            else if (BrowserVer == 9)
                RegVal = 9999;
            else if (BrowserVer == 8)
                RegVal = 8888;
            else
                RegVal = 7000;

            // set the actual key ...
            using (RegistryKey Key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", RegistryKeyPermissionCheck.ReadWriteSubTree))
                if (Key.GetValue(System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe") == null)
                    Key.SetValue(System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe", RegVal, RegistryValueKind.DWord);

            // set initial navigation url ...
            webBrowser.Navigate("");
            webBrowser.ScriptErrorsSuppressed = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // the usual stuff :) ...
            Text = $@"Macro Builder v2 - [ rankjester.com ] - graham23s@hotmail.com - v{Application.ProductVersion} - graham23s@Hotmail.com";

            // use the latest ie ...
            UseLatestIE();

            // load the macros into the combobox ...
            comboBoxLoadMacros.Items.Clear();
            string[] txt_files = Directory.GetFiles(@"Macros\", "*.txt");

            foreach (string macro_file in txt_files)
            {
                comboBoxLoadMacros.Items.Add(Path.GetFileName(macro_file));
            }

            comboBoxAutoFillAccount.Items.AddRange(File.ReadAllLines(@"LogicFiles\rj-accounts.txt"));
            comboBoxAutoFillAccount.SelectedIndex = 0;
        }

        private void BtnGoToUrl_Click(object sender, EventArgs e)
        {
            // make sure a mode is selected ...
            if (string.IsNullOrEmpty(comboBoxMode.Text)) {
                Helpers.ReturnMessage("No mode has been selected!");
                return;
            }

            // get the root i.e. site.com of the url ...
            if (string.IsNullOrEmpty(txtBoxRootUrl.Text))
            {
                txtBoxRootUrl.Text = Helpers.GetRootUrl(txtBoxNavigateToUrl.Text);
            }

            // navigate to the entered url ...
            webBrowser.Navigate(txtBoxNavigateToUrl.Text);
        }

        public void WriteToAIFile(string findThis, string writeThis)
        {
            var fileContent = File.ReadAllLines(@"LogicFiles\rj-ai-fields.txt");
            using (var output = File.CreateText(@"LogicFiles\rj-ai-fields.txt"))
            {
                for (int i = 1; i < fileContent.Length; ++i)
                {
                    if (fileContent[i] == findThis)
                    {
                        output.WriteLine(fileContent[i - 1] + "|" + writeThis);
                    }
                    else
                    {
                        output.WriteLine(fileContent[i - 1]);
                    }
                }
                output.WriteLine(fileContent[fileContent.Length - 1]);
            }
        }

        private void FillFields(string type, HtmlNode form)
        {
            try {

                // process ...
                // loop and extract all [ input/textarea/select/checkbox fields from the selected form ...

                var nodes = form.SelectNodes("//form" + type);

                if (nodes != null)
                {
                    foreach (HtmlNode elem in nodes)
                    {

                        // empty eleSL must be set here as 0 ...
                        var elePR = "";
                        var eleSL = "0";
                        var eleVA = "";
                        var eleNW = "";

                        var eleTY = elem.Attributes["type"] == null ? elem.Name.ToString() : elem.Attributes["type"].Value;
                        var eleNM = elem.Attributes["id"] == null ?
                                    elem.Attributes["name"] == null ? "" : "name"
                                    : "id";
                        var eleVU = elem.Attributes["id"] == null ?
                                    elem.Attributes["name"] == null ? "" : elem.Attributes["name"].Value
                                : elem.Attributes["id"].Value;

                        // try and get a value returned first ...
                        elePR = Helpers.PredictValue(eleVU);

                        // do not add hidden type fields these are of no use ...
                        if (eleTY != "hidden") {

                            // check for select fields, here we can enter some visible text from the dropdown ...
                            if (eleTY == "select")
                            {
                                var fi = new FormInput(this, eleTY, eleVU, "USER_FILL_SELECT", "")
                                {
                                    Value = "0"  // set initial value from main form ...
                                };
                                if (fi.ShowDialog() == DialogResult.OK)
                                {
                                    eleSL = fi.Value; // get input value back to main form ...
                                }
                            }

                            // check for Helpers.PredictValue(eleVU) values that are empty, we may be able to fill these in
                            // and add to the rj-ai-fields.txt file.
                            if (string.IsNullOrEmpty(elePR))
                            {
                                var fi = new FormInput(this, eleTY, eleVU, "USER_FILL_MACRO", "")
                                {
                                    Value = "0"
                                };
                                if (fi.ShowDialog() == DialogResult.OK)
                                {
                                    elePR = fi.ValueCombobox;
                                    eleVA = fi.ValueAIField;
                                    // update the .txt file ...
                                    WriteToAIFile(elePR, eleVA);
                                }
                            }

                            // check for "submit" buttons that use class_name or another identifier ...
                            if (eleTY == "submit" || eleTY == "Submit") {
                                var fi = new FormInput(this, eleTY, eleVU, "USER_FILL_SUBMIT", elem.OuterHtml)
                                {
                                    Value = "0"
                                };
                                if (fi.ShowDialog() == DialogResult.OK)
                                {
                                    eleNW = fi.ValueSubmitCombobox;
                                }
                            }

                            var completeMacro = "";

                            // do not add to the listViewMain if the elePR is empty ...
                            if (!string.IsNullOrEmpty(elePR) || !string.IsNullOrEmpty(eleNW)) {

                                if (!string.IsNullOrEmpty(eleNW)) {
                                    completeMacro = eleNW;
                                } else {
                                    completeMacro = eleNM + "|" + eleVU + "|" + eleSL + "|" + elePR;
                                }

                                // first checked id then name ...
                                listViewMain.Items.Add(new ListViewItem(new string[] {
                                elem.Attributes["type"]==null? elem.Name.ToString():elem.Attributes["type"].Value
                                ,
                                elem.Attributes["id"]==null?
                                    elem.Attributes["name"]==null? "":"name"
                                    :"id"
                                ,
                                elem.Attributes["id"]==null?
                                    elem.Attributes["name"]==null?"": elem.Attributes["name"].Value
                                : elem.Attributes["id"].Value
                                ,
                                completeMacro
                                }));

                            }

                            // check the mode and append to it ...
                            if (comboBoxMode.Text == "mode_register")
                            {
                                if (!string.IsNullOrEmpty(elePR) || !string.IsNullOrEmpty(eleNW))
                                {
                                    txtBoxUploadRegisterMacro.AppendText(completeMacro + Environment.NewLine);
                                }
                            }

                            // check the mode and append to it ...
                            if (comboBoxMode.Text == "mode_login_and_post")
                            {
                                if (!string.IsNullOrEmpty(elePR) || !string.IsNullOrEmpty(eleNW))
                                {
                                    txtBoxUploadLoginAndPostMacro.AppendText(completeMacro + Environment.NewLine);
                                }
                            }

                        } // if (eleTY != "hidden") { 

                    }
                }
            } catch (Exception) {
                // handle ...
            }
        }

        public static string TruncateForm(string value, int maxLength)
        {
            if (!string.IsNullOrEmpty(value) && value.Length > maxLength)
            {
                return value.Substring(0, maxLength);
            }
            return value;
        }

        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            // browser ...
            WebBrowser browser = (WebBrowser)sender;

            // current url we are viewing ...
            var current_url = browser.Url.AbsoluteUri;

            // update? ...
            txtBoxNavigateToUrl.Text = current_url;

            if (e.Url.AbsolutePath != (sender as WebBrowser).Url.AbsolutePath)
            {
                return;
            }
            else
            {
                // we are loaded, now continue ...
                try
                {

                    var doc = new HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(browser.DocumentText);

                    // loop each <form found on the page ...
                    foreach (HtmlNode form in doc.DocumentNode.SelectNodes("//form")) {

                        DialogResult dialogResult = MessageBox.Show("Extract this <form></form>?\n\n" + TruncateForm(form.OuterHtml, 250), "Macro Builder v2 - rankjester.com", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            // check for the mode success flag ...
                            if (comboBoxMode.Text == "mode_register")
                            {
                                listViewMain.Items.Add(new ListViewItem(new string[] { "url", "", "", txtBoxNavigateToUrl.Text + "|0|0|URL" }));
                                txtBoxUploadRegisterMacro.AppendText(txtBoxNavigateToUrl.Text + "|0|0|URL" + Environment.NewLine);

                                FillFields("//input", form);
                                FillFields("//textarea", form);
                                FillFields("//select", form);
                                FillFields("//checkbox", form);

                                if (browser.DocumentText.Contains("google.com/recaptcha/api.js"))
                                {
                                    listViewMain.Items.Add(new ListViewItem(new string[] { "recaptcha_v2", "", "", txtBoxNavigateToUrl.Text + "|0|0|RECAPTCHA_V2" }));
                                    txtBoxUploadRegisterMacro.AppendText(txtBoxNavigateToUrl.Text + "|0|0|RECAPTCHA_V2" + Environment.NewLine);
                                }

                                FillFields("//button", form);

                                listViewMain.Items.Add(new ListViewItem(new string[] { "R_SUCCESS_FLAG", "", "", "You have successfully created your account!|0|0|R_SUCCESS_FLAG" }));
                                txtBoxUploadRegisterMacro.AppendText("You have successfully created your account!|0|0|R_SUCCESS_FLAG" + Environment.NewLine);
                            }
                            else if (comboBoxMode.Text == "mode_login_and_post")
                            {
                                listViewMain.Items.Add(new ListViewItem(new string[] { "url", "", "", txtBoxNavigateToUrl.Text + "|0|0|URL" }));
                                txtBoxUploadLoginAndPostMacro.AppendText(txtBoxNavigateToUrl.Text + "|0|0|URL" + Environment.NewLine);

                                FillFields("//input", form);
                                FillFields("//textarea", form);
                                FillFields("//select", form);
                                FillFields("//checkbox", form);

                                if (browser.DocumentText.Contains("google.com/recaptcha/api.js"))
                                {
                                    listViewMain.Items.Add(new ListViewItem(new string[] { "recaptcha_v2", "", "", txtBoxNavigateToUrl.Text + "|0|0|RECAPTCHA_V2" }));
                                    txtBoxUploadLoginAndPostMacro.AppendText(txtBoxNavigateToUrl.Text + "|0|0|RECAPTCHA_V2" + Environment.NewLine);
                                }

                                FillFields("//button", form);

                                // check if the txtBoxUploadLoginAndPostMacro.Text contains L_SUCCESS_FLAG if it does we need P_SUCCESS_FLAG
                                var successFlag = txtBoxUploadLoginAndPostMacro.Text.Contains("L_SUCCESS_FLAG") ? "P" : "L";

                                listViewMain.Items.Add(new ListViewItem(new string[] { successFlag + "_SUCCESS_FLAG", "", "", "logout.php|0|0|" + successFlag + "_SUCCESS_FLAG" }));
                                txtBoxUploadLoginAndPostMacro.AppendText("logout.php|0|0|" + successFlag + "_SUCCESS_FLAG" + Environment.NewLine);

                            }
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            // ...
                        }

                    }

                }
                catch (Exception)
                {
                    // handle ...
                }
            }
        }

        private void BtnLoadMacros_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBoxLoadMacros.Text))
            {
                chkBoxUpdateServerMacros.Checked = true;
                btnUploadMacroToServer.ForeColor = Color.Green;
                btnUploadMacroToServer.Text = "Update";
                txtBoxUploadRegisterMacro.Text = "";
                txtBoxUploadLoginAndPostMacro.Text = "";
                txtBoxRootUrl.Text = "";
                txtBoxPlatform.Text = "";
                txtBoxPurpose.Text = "";

                var textFile = File.ReadAllText(@"Macros\" + comboBoxLoadMacros.Text);

                string[] sepstr = { "--> mode_register", "--> mode_login_and_post", "-->" };
                string[] macros = textFile.Split(sepstr, System.StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    if (!string.IsNullOrEmpty(macros[0].Trim()))
                    {
                        txtBoxUploadRegisterMacro.Text = macros[0].Trim();
                    }
                    if (!string.IsNullOrEmpty(macros[1].Trim()))
                    {
                        txtBoxUploadLoginAndPostMacro.Text = macros[1].Trim();
                    }
                    if (!string.IsNullOrEmpty(macros[2].Trim()))
                    {
                        if (macros[2].Trim().StartsWith("http"))
                        {
                            txtBoxRootUrl.Text = Helpers.GetRootUrl(macros[2].Trim());
                        }
                        else
                        {
                            txtBoxRootUrl.Text = macros[2].Trim();
                        }
                    }
                    if (!string.IsNullOrEmpty(macros[3].Trim()))
                    {
                        txtBoxPlatform.Text = macros[3].Trim();
                    }
                    if (!string.IsNullOrEmpty(macros[4].Trim()))
                    {
                        txtBoxPurpose.Text = macros[4].Trim();
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        private void BtnUploadMacroToServer_Click(object sender, EventArgs e)
        {

            // check no empty fields ...
            if (string.IsNullOrEmpty(txtBoxRootUrl.Text) || string.IsNullOrEmpty(txtBoxUploadRegisterMacro.Text) || string.IsNullOrEmpty(txtBoxUploadLoginAndPostMacro.Text) || string.IsNullOrEmpty(txtBoxPlatform.Text) || string.IsNullOrEmpty(txtBoxPurpose.Text))
            {
                Helpers.ReturnMessage("Oops! some fields not ready for upload to the server.");
                return;
            }

            // check success flags ...
            if (!txtBoxUploadRegisterMacro.Text.Contains("SUCCESS_FLAG"))
            {
                Helpers.ReturnMessage("'mode_register' has no success flags!");
                return;
            }

            // check success flags ...
            if (!txtBoxUploadLoginAndPostMacro.Text.Contains("SUCCESS_FLAG"))
            {
                Helpers.ReturnMessage("'mode_login_and_post' has no success flags!");
                return;
            }

            // overwrite macro .txt file with updated code ...
            if (chkBoxUpdateServerMacros.Checked == true)
            {
                var htmlText = "";
                using (WebClient wc = new WebClient())
                {
                    htmlText = wc.DownloadString(string.Format("https://www.rankjester.com/api.php?submitUpdateMacroTemplate=1&macroName={0}&macro-r={1}&macro-lp={2}&macroPlatform={3}&macroPurpose={4}", txtBoxRootUrl.Text, txtBoxUploadRegisterMacro.Text.Trim(), txtBoxUploadLoginAndPostMacro.Text.Trim(), txtBoxPlatform.Text, txtBoxPurpose.Text));
                }
                //Clipboard.SetText(string.Format("https://www.rankjester.com/api.php?submitUpdateMacroTemplate=1&macroName={0}&macro-r={1}&macro-lp={2}&macroPlatform={3}&macroPurpose={4}", txtBoxRootUrl.Text, txtBoxUploadRegisterMacro.Text.Trim(), txtBoxUploadLoginAndPostMacro.Text.Trim(), txtBoxPlatform.Text, txtBoxPurpose.Text));

                if (htmlText.Contains("DONE!"))
                {
                    // save macros for further tweaking later on ...
                    if (File.Exists(@"Macros\" + comboBoxLoadMacros.Text))
                    {
                        File.WriteAllText(@"Macros\" + comboBoxLoadMacros.Text, "--> mode_register\r\n" + txtBoxUploadRegisterMacro.Text.Trim() + "\r\n--> mode_login_and_post\r\n" + txtBoxUploadLoginAndPostMacro.Text.Trim() + "\r\n--> " + txtBoxRootUrl.Text + "\r\n--> " + txtBoxPlatform.Text + "\r\n--> " + txtBoxPurpose.Text);
                    }
                    Helpers.ReturnMessage("Done! macro updated successfully!");
                    return;
                }
                else
                {
                    Helpers.ReturnMessage(htmlText);
                }
            }

            // insert new macro code ...
            var html = "";
            using (WebClient wc = new WebClient())
            {
                html = wc.DownloadString(string.Format("https://www.rankjester.com/api.php?addNewMacroTemplate=1&macroName={0}&macro-r={1}&macro-lp={2}&macroPlatform={3}&macroPurpose={4}", txtBoxRootUrl.Text, txtBoxUploadRegisterMacro.Text.Trim(), txtBoxUploadLoginAndPostMacro.Text.Trim(), txtBoxPlatform.Text, txtBoxPurpose.Text));
            }

            if (html.Contains("DONE!"))
            {
                // save macros for further tweaking later on ...
                if (!File.Exists(@"Macros\" + txtBoxRootUrl.Text + ".txt"))
                {
                    File.WriteAllText(@"Macros\" + txtBoxRootUrl.Text + ".txt", "--> mode_register\r\n" + txtBoxUploadRegisterMacro.Text.Trim() + "\r\n--> mode_login_and_post\r\n" + txtBoxUploadLoginAndPostMacro.Text.Trim() + "\r\n--> " + txtBoxRootUrl.Text + "\r\n--> " + txtBoxPlatform.Text + "\r\n--> " + txtBoxPurpose.Text);
                }
                Helpers.ReturnMessage("Done! new macro added successfully!");
                return;
            }
            else
            {
                Helpers.ReturnMessage(html);
            }
            //Clipboard.SetText(string.Format("https://www.rankjester.com/api.php?addNewMacroTemplate=1&macroName={0}&macro-r={1}&macro-lp={2}&macroPlatform={3}&macroPurpose={4}", txtBoxRootUrl.Text, txtBoxUploadRegisterMacro.Text, txtBoxUploadLoginAndPostMacro.Text, txtBoxPlatform.Text, txtBoxPurpose.Text));
        }

        private void ChkBoxUpdateServerMacros_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxUpdateServerMacros.Checked == false)
            {
                btnUploadMacroToServer.ForeColor = Color.Black;
                btnUploadMacroToServer.Text = "Upload";
            }

            if (chkBoxUpdateServerMacros.Checked == true)
            {
                btnUploadMacroToServer.ForeColor = Color.Green;
                btnUploadMacroToServer.Text = "Update";
            }
        }

        private void ReloadTheMacroFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // reload the macro files in the folder ...
            ReLoadMacroFiles();
        }

        private void BtnAutoFill_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in listViewMain.Items)
            {
                string macros = eachItem.SubItems[3].Text;
                string[] macro_fields = macros.Split('|');

                if (macro_fields[0] == "id")
                {
                    webBrowser.Document.GetElementById(macro_fields[1]).SetAttribute("value", Helpers.GetAccountDetails(comboBoxAutoFillAccount.Text, macro_fields[3]));
                }

                if (macro_fields[0] == "name")
                {
                    foreach (HtmlElement id in webBrowser.Document.All.GetElementsByName(macro_fields[1]))
                    {
                        id.SetAttribute("value", Helpers.GetAccountDetails(comboBoxAutoFillAccount.Text, macro_fields[3]));
                    }
                }
            }
        }

        private void ClearFormElementsMacroOutputTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewMain.Items.Clear();
        }

    } // end.

} // end.
