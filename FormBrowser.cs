using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroBuilderV2
{
    public partial class FormBrowser : Form
    {
        private readonly FormMain _formMain;
        public FormBrowser(FormMain formMain)
        {
            _formMain = formMain;
            InitializeComponent();
            txtBoxBrowserOutput.Text = formMain.webBrowser.DocumentText;
        }

        private void FormBrowser_Load(object sender, EventArgs e)
        {

        }
    }
}
