using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroBuilderV2
{
    public partial class FormInput : Form
    {
        FormMain _formMain;
        public string fillMode;
        public string rawHtml;
        public FormInput(FormMain formMain, string eleType, string eleName, string fillModeSelected, string rawFieldHtml)
        {
            _formMain = formMain;
            fillMode = fillModeSelected;
            rawHtml = rawFieldHtml;
            InitializeComponent();
            lblTypeInput.Text = eleType;
            lblNameInput.Text = eleName;
            txtBoxAIInput.Text = eleName;
            txtBoxRawHtmlField.Text = rawHtml;
        }

        public string Value
        {
            get => txtBoxInput.Text;
            set => txtBoxInput.Text = value;
        }

        public string ValueAIField
        {
            get => txtBoxAIInput.Text;
            set => txtBoxAIInput.Text = value;
        }

        public string ValueCombobox
        {
            get => comboBoxAISelections.Text;
            set => comboBoxAISelections.Text = value;
        }

        public string ValueSubmitCombobox
        {
            get => txtBoxExtractedByFormat.Text;
            set => txtBoxExtractedByFormat.Text = value;
        }

        private void BtnInput_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormInput_Load(object sender, EventArgs e)
        {
            // USER_FILL_SELECT_VISIBLE_TEXT
            // USER_FILL_MACRO_COMMAND_TO_TEXT

            // setup ...
            _formMain.toolTip.SetToolTip(BtnInputSelect, "Add this value to the macro.");
            _formMain.toolTip.SetToolTip(BtnInputAdd, "Add this value to the rj-ai-fields.txt.");
            comboBoxAISelections.Items.AddRange(File.ReadAllLines(@"LogicFiles\rj-macros.txt"));

            if (fillMode == "USER_FILL_SELECT") {
                groupBoxAIFields.Enabled = false;
                groupBoxSubmit.Enabled = false;
            }

            if (fillMode == "USER_FILL_MACRO") {
                groupBoxSubmit.Enabled = false;
                groupBoxSelectInputRequired.Enabled = false;
                comboBoxAISelections.SelectedIndex = 0;
            }

            if (fillMode == "USER_FILL_SUBMIT")
            {
                groupBoxSelectInputRequired.Enabled = false;
                groupBoxAIFields.Enabled = false;
            }

        }

        private void ComboBoxExtractBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxExtractBy.Text == "CLASS_NAME") {
                Match token_m = Regex.Match(txtBoxRawHtmlField.Text, @"class=""(.*?)""", RegexOptions.IgnoreCase);
                if (token_m.Success)
                {
                    txtBoxExtractedByFormat.Text = "css_name|" + token_m.Groups[1].Value + "|0|BUTTON_CLICK";
                }
            }

            if (comboBoxExtractBy.Text == "XPATH")
            {
                txtBoxExtractedByFormat.Text = "xpath|" + txtBoxXpath.Text + "|0|BUTTON_CLICK";
            }
        }

    } // end.

} // end.
