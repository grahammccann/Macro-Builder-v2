using System.Windows.Forms;

namespace MacroBuilderV2
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadTheMacroFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearFormElementsMacroOutputTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxUrlNavigation = new System.Windows.Forms.GroupBox();
            this.BtnAutoFill = new System.Windows.Forms.Button();
            this.comboBoxAutoFillAccount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.BtnGoToUrl = new System.Windows.Forms.Button();
            this.txtBoxNavigateToUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listViewMain = new System.Windows.Forms.ListView();
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIdentifier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMacro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxLoginAndPost = new System.Windows.Forms.GroupBox();
            this.txtBoxUploadLoginAndPostMacro = new System.Windows.Forms.TextBox();
            this.groupBoxRegister = new System.Windows.Forms.GroupBox();
            this.txtBoxUploadRegisterMacro = new System.Windows.Forms.TextBox();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.chkBoxUpdateServerMacros = new System.Windows.Forms.CheckBox();
            this.btnLoadMacros = new System.Windows.Forms.Button();
            this.comboBoxLoadMacros = new System.Windows.Forms.ComboBox();
            this.btnUploadMacroToServer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxPurpose = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxPlatform = new System.Windows.Forms.TextBox();
            this.lblRootUrl = new System.Windows.Forms.Label();
            this.txtBoxRootUrl = new System.Windows.Forms.TextBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxUrlNavigation.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.groupBoxLoginAndPost.SuspendLayout();
            this.groupBoxRegister.SuspendLayout();
            this.groupBoxSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(984, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadTheMacroFilesToolStripMenuItem,
            this.clearFormElementsMacroOutputTableToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // reloadTheMacroFilesToolStripMenuItem
            // 
            this.reloadTheMacroFilesToolStripMenuItem.Name = "reloadTheMacroFilesToolStripMenuItem";
            this.reloadTheMacroFilesToolStripMenuItem.Size = new System.Drawing.Size(317, 22);
            this.reloadTheMacroFilesToolStripMenuItem.Text = "Reload macro files ...";
            this.reloadTheMacroFilesToolStripMenuItem.Click += new System.EventHandler(this.ReloadTheMacroFilesToolStripMenuItem_Click);
            // 
            // clearFormElementsMacroOutputTableToolStripMenuItem
            // 
            this.clearFormElementsMacroOutputTableToolStripMenuItem.Name = "clearFormElementsMacroOutputTableToolStripMenuItem";
            this.clearFormElementsMacroOutputTableToolStripMenuItem.Size = new System.Drawing.Size(317, 22);
            this.clearFormElementsMacroOutputTableToolStripMenuItem.Text = "Clear form elements / macro output table ...";
            this.clearFormElementsMacroOutputTableToolStripMenuItem.Click += new System.EventHandler(this.ClearFormElementsMacroOutputTableToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 539);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(984, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(16, 17);
            this.statusLabel.Text = "...";
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.webBrowser.Location = new System.Drawing.Point(0, 179);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(984, 360);
            this.webBrowser.TabIndex = 2;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowser_DocumentCompleted);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ImageList = this.imageList;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(984, 155);
            this.tabControl.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBoxUrlNavigation);
            this.tabPage2.ImageIndex = 0;
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 127);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "NAVIGATION / MACRO SETTINGS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBoxUrlNavigation
            // 
            this.groupBoxUrlNavigation.Controls.Add(this.BtnAutoFill);
            this.groupBoxUrlNavigation.Controls.Add(this.comboBoxAutoFillAccount);
            this.groupBoxUrlNavigation.Controls.Add(this.label1);
            this.groupBoxUrlNavigation.Controls.Add(this.comboBoxMode);
            this.groupBoxUrlNavigation.Controls.Add(this.lblMode);
            this.groupBoxUrlNavigation.Controls.Add(this.BtnGoToUrl);
            this.groupBoxUrlNavigation.Controls.Add(this.txtBoxNavigateToUrl);
            this.groupBoxUrlNavigation.Controls.Add(this.lblUrl);
            this.groupBoxUrlNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxUrlNavigation.Location = new System.Drawing.Point(3, 3);
            this.groupBoxUrlNavigation.Name = "groupBoxUrlNavigation";
            this.groupBoxUrlNavigation.Size = new System.Drawing.Size(970, 121);
            this.groupBoxUrlNavigation.TabIndex = 0;
            this.groupBoxUrlNavigation.TabStop = false;
            this.groupBoxUrlNavigation.Text = "URL Navigation:";
            // 
            // BtnAutoFill
            // 
            this.BtnAutoFill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAutoFill.Location = new System.Drawing.Point(772, 62);
            this.BtnAutoFill.Name = "BtnAutoFill";
            this.BtnAutoFill.Size = new System.Drawing.Size(75, 23);
            this.BtnAutoFill.TabIndex = 7;
            this.BtnAutoFill.Text = "AutoFill";
            this.BtnAutoFill.UseVisualStyleBackColor = true;
            this.BtnAutoFill.Click += new System.EventHandler(this.BtnAutoFill_Click);
            // 
            // comboBoxAutoFillAccount
            // 
            this.comboBoxAutoFillAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAutoFillAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAutoFillAccount.FormattingEnabled = true;
            this.comboBoxAutoFillAccount.Location = new System.Drawing.Point(341, 62);
            this.comboBoxAutoFillAccount.Name = "comboBoxAutoFillAccount";
            this.comboBoxAutoFillAccount.Size = new System.Drawing.Size(425, 23);
            this.comboBoxAutoFillAccount.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "AutoFill Form:";
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Items.AddRange(new object[] {
            "mode_register",
            "mode_login_and_post"});
            this.comboBoxMode.Location = new System.Drawing.Point(62, 62);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(182, 23);
            this.comboBoxMode.TabIndex = 4;
            this.toolTip.SetToolTip(this.comboBoxMode, "Which mode are we to use?");
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(13, 65);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(43, 15);
            this.lblMode.TabIndex = 3;
            this.lblMode.Text = "Mode:";
            // 
            // BtnGoToUrl
            // 
            this.BtnGoToUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGoToUrl.Image = global::MacroBuilderV2.Properties.Resources.ico_browser;
            this.BtnGoToUrl.Location = new System.Drawing.Point(848, 35);
            this.BtnGoToUrl.Name = "BtnGoToUrl";
            this.BtnGoToUrl.Size = new System.Drawing.Size(50, 50);
            this.BtnGoToUrl.TabIndex = 2;
            this.toolTip.SetToolTip(this.BtnGoToUrl, "Navigate to the URL.");
            this.BtnGoToUrl.UseVisualStyleBackColor = true;
            this.BtnGoToUrl.Click += new System.EventHandler(this.BtnGoToUrl_Click);
            // 
            // txtBoxNavigateToUrl
            // 
            this.txtBoxNavigateToUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNavigateToUrl.Location = new System.Drawing.Point(62, 36);
            this.txtBoxNavigateToUrl.Name = "txtBoxNavigateToUrl";
            this.txtBoxNavigateToUrl.Size = new System.Drawing.Size(783, 23);
            this.txtBoxNavigateToUrl.TabIndex = 1;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(25, 39);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(31, 15);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Text = "URL:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listViewMain);
            this.tabPage1.ImageIndex = 1;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 211);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "FORM HTML ELEMENTS / MACRO OUTPUT";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listViewMain
            // 
            this.listViewMain.CheckBoxes = true;
            this.listViewMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colType,
            this.colIdentifier,
            this.colValue,
            this.colMacro});
            this.listViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMain.Location = new System.Drawing.Point(3, 3);
            this.listViewMain.Name = "listViewMain";
            this.listViewMain.Size = new System.Drawing.Size(970, 205);
            this.listViewMain.TabIndex = 0;
            this.listViewMain.UseCompatibleStateImageBehavior = false;
            this.listViewMain.View = System.Windows.Forms.View.Details;
            // 
            // colType
            // 
            this.colType.Text = "HTML ELEMENT TYPE";
            this.colType.Width = 150;
            // 
            // colIdentifier
            // 
            this.colIdentifier.Text = "HTML ELEMENT ID or NAME";
            this.colIdentifier.Width = 180;
            // 
            // colValue
            // 
            this.colValue.Text = "HTML ELEMENT VALUE";
            this.colValue.Width = 200;
            // 
            // colMacro
            // 
            this.colMacro.Text = "MACRO AUTO PREDICT";
            this.colMacro.Width = 350;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel);
            this.tabPage3.Controls.Add(this.groupBoxSettings);
            this.tabPage3.ImageIndex = 2;
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 211);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "UPLOAD / SAVE MACRO CODE";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.groupBoxLoginAndPost, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.groupBoxRegister, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(716, 205);
            this.tableLayoutPanel.TabIndex = 4;
            // 
            // groupBoxLoginAndPost
            // 
            this.groupBoxLoginAndPost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLoginAndPost.Controls.Add(this.txtBoxUploadLoginAndPostMacro);
            this.groupBoxLoginAndPost.Location = new System.Drawing.Point(361, 3);
            this.groupBoxLoginAndPost.Name = "groupBoxLoginAndPost";
            this.groupBoxLoginAndPost.Size = new System.Drawing.Size(352, 199);
            this.groupBoxLoginAndPost.TabIndex = 5;
            this.groupBoxLoginAndPost.TabStop = false;
            this.groupBoxLoginAndPost.Text = "Login And Post Macro:";
            // 
            // txtBoxUploadLoginAndPostMacro
            // 
            this.txtBoxUploadLoginAndPostMacro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxUploadLoginAndPostMacro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxUploadLoginAndPostMacro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtBoxUploadLoginAndPostMacro.Location = new System.Drawing.Point(3, 19);
            this.txtBoxUploadLoginAndPostMacro.Multiline = true;
            this.txtBoxUploadLoginAndPostMacro.Name = "txtBoxUploadLoginAndPostMacro";
            this.txtBoxUploadLoginAndPostMacro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxUploadLoginAndPostMacro.Size = new System.Drawing.Size(346, 177);
            this.txtBoxUploadLoginAndPostMacro.TabIndex = 0;
            // 
            // groupBoxRegister
            // 
            this.groupBoxRegister.Controls.Add(this.txtBoxUploadRegisterMacro);
            this.groupBoxRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRegister.Location = new System.Drawing.Point(3, 3);
            this.groupBoxRegister.Name = "groupBoxRegister";
            this.groupBoxRegister.Size = new System.Drawing.Size(352, 199);
            this.groupBoxRegister.TabIndex = 4;
            this.groupBoxRegister.TabStop = false;
            this.groupBoxRegister.Text = "Register Macro:";
            // 
            // txtBoxUploadRegisterMacro
            // 
            this.txtBoxUploadRegisterMacro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxUploadRegisterMacro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxUploadRegisterMacro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtBoxUploadRegisterMacro.Location = new System.Drawing.Point(3, 19);
            this.txtBoxUploadRegisterMacro.Multiline = true;
            this.txtBoxUploadRegisterMacro.Name = "txtBoxUploadRegisterMacro";
            this.txtBoxUploadRegisterMacro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxUploadRegisterMacro.Size = new System.Drawing.Size(346, 177);
            this.txtBoxUploadRegisterMacro.TabIndex = 0;
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSettings.Controls.Add(this.chkBoxUpdateServerMacros);
            this.groupBoxSettings.Controls.Add(this.btnLoadMacros);
            this.groupBoxSettings.Controls.Add(this.comboBoxLoadMacros);
            this.groupBoxSettings.Controls.Add(this.btnUploadMacroToServer);
            this.groupBoxSettings.Controls.Add(this.label6);
            this.groupBoxSettings.Controls.Add(this.txtBoxPurpose);
            this.groupBoxSettings.Controls.Add(this.label5);
            this.groupBoxSettings.Controls.Add(this.txtBoxPlatform);
            this.groupBoxSettings.Controls.Add(this.lblRootUrl);
            this.groupBoxSettings.Controls.Add(this.txtBoxRootUrl);
            this.groupBoxSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxSettings.Location = new System.Drawing.Point(719, 3);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(254, 205);
            this.groupBoxSettings.TabIndex = 3;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings:";
            // 
            // chkBoxUpdateServerMacros
            // 
            this.chkBoxUpdateServerMacros.AutoSize = true;
            this.chkBoxUpdateServerMacros.Location = new System.Drawing.Point(13, 148);
            this.chkBoxUpdateServerMacros.Name = "chkBoxUpdateServerMacros";
            this.chkBoxUpdateServerMacros.Size = new System.Drawing.Size(149, 19);
            this.chkBoxUpdateServerMacros.TabIndex = 10;
            this.chkBoxUpdateServerMacros.Text = "Update server macros.";
            this.chkBoxUpdateServerMacros.UseVisualStyleBackColor = true;
            this.chkBoxUpdateServerMacros.CheckedChanged += new System.EventHandler(this.ChkBoxUpdateServerMacros_CheckedChanged);
            // 
            // btnLoadMacros
            // 
            this.btnLoadMacros.Location = new System.Drawing.Point(178, 173);
            this.btnLoadMacros.Name = "btnLoadMacros";
            this.btnLoadMacros.Size = new System.Drawing.Size(61, 23);
            this.btnLoadMacros.TabIndex = 9;
            this.btnLoadMacros.Text = "Load";
            this.toolTip.SetToolTip(this.btnLoadMacros, "Load the selected macro file.");
            this.btnLoadMacros.UseVisualStyleBackColor = true;
            this.btnLoadMacros.Click += new System.EventHandler(this.BtnLoadMacros_Click);
            // 
            // comboBoxLoadMacros
            // 
            this.comboBoxLoadMacros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoadMacros.FormattingEnabled = true;
            this.comboBoxLoadMacros.Location = new System.Drawing.Point(13, 173);
            this.comboBoxLoadMacros.Name = "comboBoxLoadMacros";
            this.comboBoxLoadMacros.Size = new System.Drawing.Size(159, 23);
            this.comboBoxLoadMacros.TabIndex = 8;
            // 
            // btnUploadMacroToServer
            // 
            this.btnUploadMacroToServer.Location = new System.Drawing.Point(177, 146);
            this.btnUploadMacroToServer.Name = "btnUploadMacroToServer";
            this.btnUploadMacroToServer.Size = new System.Drawing.Size(61, 23);
            this.btnUploadMacroToServer.TabIndex = 7;
            this.btnUploadMacroToServer.Text = "Upload";
            this.toolTip.SetToolTip(this.btnUploadMacroToServer, "Upload or update the macro code server side.");
            this.btnUploadMacroToServer.UseVisualStyleBackColor = true;
            this.btnUploadMacroToServer.Click += new System.EventHandler(this.BtnUploadMacroToServer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Purpose:";
            // 
            // txtBoxPurpose
            // 
            this.txtBoxPurpose.Location = new System.Drawing.Point(13, 117);
            this.txtBoxPurpose.Name = "txtBoxPurpose";
            this.txtBoxPurpose.Size = new System.Drawing.Size(224, 23);
            this.txtBoxPurpose.TabIndex = 4;
            this.txtBoxPurpose.Text = "Creates a ...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Platform:";
            // 
            // txtBoxPlatform
            // 
            this.txtBoxPlatform.Location = new System.Drawing.Point(13, 74);
            this.txtBoxPlatform.Name = "txtBoxPlatform";
            this.txtBoxPlatform.Size = new System.Drawing.Size(224, 23);
            this.txtBoxPlatform.TabIndex = 2;
            this.txtBoxPlatform.Text = "article_rank_jester";
            // 
            // lblRootUrl
            // 
            this.lblRootUrl.AutoSize = true;
            this.lblRootUrl.Location = new System.Drawing.Point(13, 13);
            this.lblRootUrl.Name = "lblRootUrl";
            this.lblRootUrl.Size = new System.Drawing.Size(31, 15);
            this.lblRootUrl.TabIndex = 1;
            this.lblRootUrl.Text = "URL:";
            // 
            // txtBoxRootUrl
            // 
            this.txtBoxRootUrl.Location = new System.Drawing.Point(13, 31);
            this.txtBoxRootUrl.Name = "txtBoxRootUrl";
            this.txtBoxRootUrl.Size = new System.Drawing.Size(224, 23);
            this.txtBoxRootUrl.TabIndex = 0;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "ico-settings.png");
            this.imageList.Images.SetKeyName(1, "ico-macro-output.png");
            this.imageList.Images.SetKeyName(2, "ico-upload.png");
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Macro Builder v2 - [ rankjester.com ] - graham23s@hotmail.com";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBoxUrlNavigation.ResumeLayout(false);
            this.groupBoxUrlNavigation.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.groupBoxLoginAndPost.ResumeLayout(false);
            this.groupBoxLoginAndPost.PerformLayout();
            this.groupBoxRegister.ResumeLayout(false);
            this.groupBoxRegister.PerformLayout();
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.GroupBox groupBoxUrlNavigation;
        private System.Windows.Forms.Button BtnGoToUrl;
        private System.Windows.Forms.TextBox txtBoxNavigateToUrl;
        private System.Windows.Forms.Label lblUrl;
        private TabPage tabPage1;
        private ListView listViewMain;
        private ColumnHeader colType;
        private ColumnHeader colIdentifier;
        private ColumnHeader colValue;
        private ColumnHeader colMacro;
        private TabPage tabPage3;
        private ComboBox comboBoxMode;
        private Label lblMode;
        private GroupBox groupBoxSettings;
        private CheckBox chkBoxUpdateServerMacros;
        private Button btnLoadMacros;
        private ComboBox comboBoxLoadMacros;
        private Button btnUploadMacroToServer;
        private Label label6;
        private TextBox txtBoxPurpose;
        private Label label5;
        private TextBox txtBoxPlatform;
        private Label lblRootUrl;
        private TextBox txtBoxRootUrl;
        private GroupBox groupBoxLoginAndPost;
        private TextBox txtBoxUploadLoginAndPostMacro;
        private GroupBox groupBoxRegister;
        private TextBox txtBoxUploadRegisterMacro;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem reloadTheMacroFilesToolStripMenuItem;
        public ToolStripStatusLabel statusLabel;
        private TableLayoutPanel tableLayoutPanel;
        public WebBrowser webBrowser;
        public ToolTip toolTip;
        private Button BtnAutoFill;
        private ComboBox comboBoxAutoFillAccount;
        private Label label1;
        private ToolStripMenuItem clearFormElementsMacroOutputTableToolStripMenuItem;
    }
}

