namespace MacroBuilderV2
{
    partial class FormInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInput));
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.groupBoxSelectInputRequired = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNameInput = new System.Windows.Forms.Label();
            this.lblFieldName = new System.Windows.Forms.Label();
            this.lblTypeInput = new System.Windows.Forms.Label();
            this.lblFieldType = new System.Windows.Forms.Label();
            this.BtnInputSelect = new System.Windows.Forms.Button();
            this.groupBoxAIFields = new System.Windows.Forms.GroupBox();
            this.lblCreateNew = new System.Windows.Forms.Label();
            this.txtBoxAddNewAIField = new System.Windows.Forms.TextBox();
            this.comboBoxAISelections = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxAIInput = new System.Windows.Forms.TextBox();
            this.BtnInputAdd = new System.Windows.Forms.Button();
            this.groupBoxSubmit = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxXpath = new System.Windows.Forms.TextBox();
            this.txtBoxExtractedByFormat = new System.Windows.Forms.TextBox();
            this.comboBoxExtractBy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxRawHtmlField = new System.Windows.Forms.TextBox();
            this.BtnInputSubmit = new System.Windows.Forms.Button();
            this.groupBoxSelectInputRequired.SuspendLayout();
            this.groupBoxAIFields.SuspendLayout();
            this.groupBoxSubmit.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Location = new System.Drawing.Point(108, 22);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(288, 23);
            this.txtBoxInput.TabIndex = 0;
            // 
            // groupBoxSelectInputRequired
            // 
            this.groupBoxSelectInputRequired.Controls.Add(this.label1);
            this.groupBoxSelectInputRequired.Controls.Add(this.lblNameInput);
            this.groupBoxSelectInputRequired.Controls.Add(this.lblFieldName);
            this.groupBoxSelectInputRequired.Controls.Add(this.lblTypeInput);
            this.groupBoxSelectInputRequired.Controls.Add(this.lblFieldType);
            this.groupBoxSelectInputRequired.Controls.Add(this.txtBoxInput);
            this.groupBoxSelectInputRequired.Controls.Add(this.BtnInputSelect);
            this.groupBoxSelectInputRequired.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSelectInputRequired.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSelectInputRequired.Name = "groupBoxSelectInputRequired";
            this.groupBoxSelectInputRequired.Size = new System.Drawing.Size(475, 102);
            this.groupBoxSelectInputRequired.TabIndex = 2;
            this.groupBoxSelectInputRequired.TabStop = false;
            this.groupBoxSelectInputRequired.Text = "<select>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Field Value:";
            // 
            // lblNameInput
            // 
            this.lblNameInput.AutoSize = true;
            this.lblNameInput.ForeColor = System.Drawing.Color.Green;
            this.lblNameInput.Location = new System.Drawing.Point(105, 67);
            this.lblNameInput.Name = "lblNameInput";
            this.lblNameInput.Size = new System.Drawing.Size(16, 15);
            this.lblNameInput.TabIndex = 5;
            this.lblNameInput.Text = "...";
            // 
            // lblFieldName
            // 
            this.lblFieldName.AutoSize = true;
            this.lblFieldName.Location = new System.Drawing.Point(32, 67);
            this.lblFieldName.Name = "lblFieldName";
            this.lblFieldName.Size = new System.Drawing.Size(73, 15);
            this.lblFieldName.TabIndex = 4;
            this.lblFieldName.Text = "Field Name:";
            // 
            // lblTypeInput
            // 
            this.lblTypeInput.AutoSize = true;
            this.lblTypeInput.ForeColor = System.Drawing.Color.Green;
            this.lblTypeInput.Location = new System.Drawing.Point(105, 49);
            this.lblTypeInput.Name = "lblTypeInput";
            this.lblTypeInput.Size = new System.Drawing.Size(16, 15);
            this.lblTypeInput.TabIndex = 3;
            this.lblTypeInput.Text = "...";
            // 
            // lblFieldType
            // 
            this.lblFieldType.AutoSize = true;
            this.lblFieldType.Location = new System.Drawing.Point(39, 49);
            this.lblFieldType.Name = "lblFieldType";
            this.lblFieldType.Size = new System.Drawing.Size(66, 15);
            this.lblFieldType.TabIndex = 2;
            this.lblFieldType.Text = "Field Type:";
            // 
            // BtnInputSelect
            // 
            this.BtnInputSelect.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnInputSelect.Image = global::MacroBuilderV2.Properties.Resources.ico_add;
            this.BtnInputSelect.Location = new System.Drawing.Point(402, 21);
            this.BtnInputSelect.Name = "BtnInputSelect";
            this.BtnInputSelect.Size = new System.Drawing.Size(50, 50);
            this.BtnInputSelect.TabIndex = 1;
            this.BtnInputSelect.UseVisualStyleBackColor = true;
            this.BtnInputSelect.Click += new System.EventHandler(this.BtnInput_Click);
            // 
            // groupBoxAIFields
            // 
            this.groupBoxAIFields.Controls.Add(this.lblCreateNew);
            this.groupBoxAIFields.Controls.Add(this.txtBoxAddNewAIField);
            this.groupBoxAIFields.Controls.Add(this.comboBoxAISelections);
            this.groupBoxAIFields.Controls.Add(this.label3);
            this.groupBoxAIFields.Controls.Add(this.label2);
            this.groupBoxAIFields.Controls.Add(this.txtBoxAIInput);
            this.groupBoxAIFields.Controls.Add(this.BtnInputAdd);
            this.groupBoxAIFields.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxAIFields.Location = new System.Drawing.Point(0, 102);
            this.groupBoxAIFields.Name = "groupBoxAIFields";
            this.groupBoxAIFields.Size = new System.Drawing.Size(475, 129);
            this.groupBoxAIFields.TabIndex = 3;
            this.groupBoxAIFields.TabStop = false;
            this.groupBoxAIFields.Text = "<rj-ai-fields.txt>";
            // 
            // lblCreateNew
            // 
            this.lblCreateNew.AutoSize = true;
            this.lblCreateNew.Location = new System.Drawing.Point(23, 80);
            this.lblCreateNew.Name = "lblCreateNew";
            this.lblCreateNew.Size = new System.Drawing.Size(77, 15);
            this.lblCreateNew.TabIndex = 13;
            this.lblCreateNew.Text = "Create New:";
            // 
            // txtBoxAddNewAIField
            // 
            this.txtBoxAddNewAIField.Location = new System.Drawing.Point(102, 77);
            this.txtBoxAddNewAIField.Name = "txtBoxAddNewAIField";
            this.txtBoxAddNewAIField.Size = new System.Drawing.Size(294, 23);
            this.txtBoxAddNewAIField.TabIndex = 12;
            // 
            // comboBoxAISelections
            // 
            this.comboBoxAISelections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAISelections.FormattingEnabled = true;
            this.comboBoxAISelections.Location = new System.Drawing.Point(102, 52);
            this.comboBoxAISelections.Name = "comboBoxAISelections";
            this.comboBoxAISelections.Size = new System.Drawing.Size(294, 23);
            this.comboBoxAISelections.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Add To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Field Name:";
            // 
            // txtBoxAIInput
            // 
            this.txtBoxAIInput.Location = new System.Drawing.Point(102, 27);
            this.txtBoxAIInput.Name = "txtBoxAIInput";
            this.txtBoxAIInput.Size = new System.Drawing.Size(294, 23);
            this.txtBoxAIInput.TabIndex = 7;
            // 
            // BtnInputAdd
            // 
            this.BtnInputAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnInputAdd.Image = global::MacroBuilderV2.Properties.Resources.ico_add;
            this.BtnInputAdd.Location = new System.Drawing.Point(402, 26);
            this.BtnInputAdd.Name = "BtnInputAdd";
            this.BtnInputAdd.Size = new System.Drawing.Size(50, 50);
            this.BtnInputAdd.TabIndex = 8;
            this.BtnInputAdd.UseVisualStyleBackColor = true;
            // 
            // groupBoxSubmit
            // 
            this.groupBoxSubmit.Controls.Add(this.label6);
            this.groupBoxSubmit.Controls.Add(this.label4);
            this.groupBoxSubmit.Controls.Add(this.txtBoxXpath);
            this.groupBoxSubmit.Controls.Add(this.txtBoxExtractedByFormat);
            this.groupBoxSubmit.Controls.Add(this.comboBoxExtractBy);
            this.groupBoxSubmit.Controls.Add(this.label5);
            this.groupBoxSubmit.Controls.Add(this.txtBoxRawHtmlField);
            this.groupBoxSubmit.Controls.Add(this.BtnInputSubmit);
            this.groupBoxSubmit.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSubmit.Location = new System.Drawing.Point(0, 231);
            this.groupBoxSubmit.Name = "groupBoxSubmit";
            this.groupBoxSubmit.Size = new System.Drawing.Size(475, 134);
            this.groupBoxSubmit.TabIndex = 4;
            this.groupBoxSubmit.TabStop = false;
            this.groupBoxSubmit.Text = "<submit>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Return:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "CSS / Xpath:";
            // 
            // txtBoxXpath
            // 
            this.txtBoxXpath.Location = new System.Drawing.Point(232, 52);
            this.txtBoxXpath.Name = "txtBoxXpath";
            this.txtBoxXpath.Size = new System.Drawing.Size(164, 23);
            this.txtBoxXpath.TabIndex = 12;
            // 
            // txtBoxExtractedByFormat
            // 
            this.txtBoxExtractedByFormat.Location = new System.Drawing.Point(102, 77);
            this.txtBoxExtractedByFormat.Name = "txtBoxExtractedByFormat";
            this.txtBoxExtractedByFormat.Size = new System.Drawing.Size(294, 23);
            this.txtBoxExtractedByFormat.TabIndex = 11;
            // 
            // comboBoxExtractBy
            // 
            this.comboBoxExtractBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExtractBy.FormattingEnabled = true;
            this.comboBoxExtractBy.Items.AddRange(new object[] {
            "CLASS_NAME",
            "XPATH"});
            this.comboBoxExtractBy.Location = new System.Drawing.Point(102, 52);
            this.comboBoxExtractBy.Name = "comboBoxExtractBy";
            this.comboBoxExtractBy.Size = new System.Drawing.Size(128, 23);
            this.comboBoxExtractBy.TabIndex = 10;
            this.comboBoxExtractBy.SelectedIndexChanged += new System.EventHandler(this.ComboBoxExtractBy_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Field Name:";
            // 
            // txtBoxRawHtmlField
            // 
            this.txtBoxRawHtmlField.Location = new System.Drawing.Point(102, 27);
            this.txtBoxRawHtmlField.Name = "txtBoxRawHtmlField";
            this.txtBoxRawHtmlField.Size = new System.Drawing.Size(294, 23);
            this.txtBoxRawHtmlField.TabIndex = 7;
            // 
            // BtnInputSubmit
            // 
            this.BtnInputSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnInputSubmit.Image = global::MacroBuilderV2.Properties.Resources.ico_add;
            this.BtnInputSubmit.Location = new System.Drawing.Point(402, 26);
            this.BtnInputSubmit.Name = "BtnInputSubmit";
            this.BtnInputSubmit.Size = new System.Drawing.Size(50, 50);
            this.BtnInputSubmit.TabIndex = 8;
            this.BtnInputSubmit.UseVisualStyleBackColor = true;
            // 
            // FormInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 360);
            this.Controls.Add(this.groupBoxSubmit);
            this.Controls.Add(this.groupBoxAIFields);
            this.Controls.Add(this.groupBoxSelectInputRequired);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teach AI Fields ...";
            this.Load += new System.EventHandler(this.FormInput_Load);
            this.groupBoxSelectInputRequired.ResumeLayout(false);
            this.groupBoxSelectInputRequired.PerformLayout();
            this.groupBoxAIFields.ResumeLayout(false);
            this.groupBoxAIFields.PerformLayout();
            this.groupBoxSubmit.ResumeLayout(false);
            this.groupBoxSubmit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.Button BtnInputSelect;
        private System.Windows.Forms.GroupBox groupBoxSelectInputRequired;
        private System.Windows.Forms.Label lblNameInput;
        private System.Windows.Forms.Label lblFieldName;
        private System.Windows.Forms.Label lblTypeInput;
        private System.Windows.Forms.Label lblFieldType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxAIFields;
        private System.Windows.Forms.ComboBox comboBoxAISelections;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxAIInput;
        private System.Windows.Forms.Button BtnInputAdd;
        private System.Windows.Forms.GroupBox groupBoxSubmit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxRawHtmlField;
        private System.Windows.Forms.Button BtnInputSubmit;
        private System.Windows.Forms.TextBox txtBoxExtractedByFormat;
        private System.Windows.Forms.ComboBox comboBoxExtractBy;
        private System.Windows.Forms.TextBox txtBoxXpath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCreateNew;
        private System.Windows.Forms.TextBox txtBoxAddNewAIField;
    }
}