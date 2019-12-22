namespace MacroBuilderV2
{
    partial class FormBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBrowser));
            this.txtBoxBrowserOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxBrowserOutput
            // 
            this.txtBoxBrowserOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxBrowserOutput.Location = new System.Drawing.Point(0, 0);
            this.txtBoxBrowserOutput.Multiline = true;
            this.txtBoxBrowserOutput.Name = "txtBoxBrowserOutput";
            this.txtBoxBrowserOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxBrowserOutput.Size = new System.Drawing.Size(933, 519);
            this.txtBoxBrowserOutput.TabIndex = 0;
            // 
            // FormBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.txtBoxBrowserOutput);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTML Browser ...";
            this.Load += new System.EventHandler(this.FormBrowser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxBrowserOutput;
    }
}