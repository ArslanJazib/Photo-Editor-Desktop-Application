namespace VPMidTask1
{
    partial class SystemInformation
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
            this.systemInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // systemInfo
            // 
            this.systemInfo.BackColor = System.Drawing.Color.White;
            this.systemInfo.Location = new System.Drawing.Point(4, 13);
            this.systemInfo.Name = "systemInfo";
            this.systemInfo.ReadOnly = true;
            this.systemInfo.Size = new System.Drawing.Size(651, 602);
            this.systemInfo.TabIndex = 0;
            this.systemInfo.Text = "";
            this.systemInfo.TextChanged += new System.EventHandler(this.systemInfo_TextChanged);
            // 
            // SystemInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(667, 627);
            this.Controls.Add(this.systemInfo);
            this.Name = "SystemInformation";
            this.Text = "SystemInformation";
            this.Load += new System.EventHandler(this.SystemInformation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox systemInfo;
    }
}