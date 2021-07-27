namespace VPMidTask1
{
    partial class Filter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Filter));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.increaseBrightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decreaseBrightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gammaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.othersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preview_pbox = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.savetool = new System.Windows.Forms.ToolStripButton();
            this.cameratool = new System.Windows.Forms.ToolStripButton();
            this.browsertool = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.browserlbl = new System.Windows.Forms.Label();
            this.browser = new System.Windows.Forms.Button();
            this.webcamlbl = new System.Windows.Forms.Label();
            this.webcam = new System.Windows.Forms.Button();
            this.savelbl = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preview_pbox)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtersToolStripMenuItem,
            this.zoomToolStripMenuItem,
            this.detailToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(861, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invertToolStripMenuItem,
            this.grayScaleToolStripMenuItem,
            this.brightnessToolStripMenuItem,
            this.contrastToolStripMenuItem,
            this.gammaToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.othersToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // invertToolStripMenuItem
            // 
            this.invertToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("invertToolStripMenuItem.Image")));
            this.invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            this.invertToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.invertToolStripMenuItem.Text = "Invert";
            this.invertToolStripMenuItem.Click += new System.EventHandler(this.invertToolStripMenuItem_Click);
            // 
            // grayScaleToolStripMenuItem
            // 
            this.grayScaleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("grayScaleToolStripMenuItem.Image")));
            this.grayScaleToolStripMenuItem.Name = "grayScaleToolStripMenuItem";
            this.grayScaleToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.grayScaleToolStripMenuItem.Text = "GrayScale";
            this.grayScaleToolStripMenuItem.Click += new System.EventHandler(this.grayScaleToolStripMenuItem_Click);
            // 
            // brightnessToolStripMenuItem
            // 
            this.brightnessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.increaseBrightnessToolStripMenuItem,
            this.decreaseBrightnessToolStripMenuItem});
            this.brightnessToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("brightnessToolStripMenuItem.Image")));
            this.brightnessToolStripMenuItem.Name = "brightnessToolStripMenuItem";
            this.brightnessToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.brightnessToolStripMenuItem.Text = "Brightness";
            this.brightnessToolStripMenuItem.Click += new System.EventHandler(this.brightnessToolStripMenuItem_Click);
            // 
            // increaseBrightnessToolStripMenuItem
            // 
            this.increaseBrightnessToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("increaseBrightnessToolStripMenuItem.Image")));
            this.increaseBrightnessToolStripMenuItem.Name = "increaseBrightnessToolStripMenuItem";
            this.increaseBrightnessToolStripMenuItem.Size = new System.Drawing.Size(254, 30);
            this.increaseBrightnessToolStripMenuItem.Text = "Increase Brightness";
            this.increaseBrightnessToolStripMenuItem.Click += new System.EventHandler(this.increaseBrightnessToolStripMenuItem_Click);
            // 
            // decreaseBrightnessToolStripMenuItem
            // 
            this.decreaseBrightnessToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("decreaseBrightnessToolStripMenuItem.Image")));
            this.decreaseBrightnessToolStripMenuItem.Name = "decreaseBrightnessToolStripMenuItem";
            this.decreaseBrightnessToolStripMenuItem.Size = new System.Drawing.Size(254, 30);
            this.decreaseBrightnessToolStripMenuItem.Text = "Decrease Brightness";
            this.decreaseBrightnessToolStripMenuItem.Click += new System.EventHandler(this.decreaseBrightnessToolStripMenuItem_Click);
            // 
            // contrastToolStripMenuItem
            // 
            this.contrastToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("contrastToolStripMenuItem.Image")));
            this.contrastToolStripMenuItem.Name = "contrastToolStripMenuItem";
            this.contrastToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.contrastToolStripMenuItem.Text = "Contrast";
            this.contrastToolStripMenuItem.Click += new System.EventHandler(this.contrastToolStripMenuItem_Click);
            // 
            // gammaToolStripMenuItem
            // 
            this.gammaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gammaToolStripMenuItem.Image")));
            this.gammaToolStripMenuItem.Name = "gammaToolStripMenuItem";
            this.gammaToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.gammaToolStripMenuItem.Text = "Gamma";
            this.gammaToolStripMenuItem.Click += new System.EventHandler(this.gammaToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("colorToolStripMenuItem.Image")));
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.colorToolStripMenuItem.Text = "Color Mapping";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // othersToolStripMenuItem
            // 
            this.othersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sepiaToolStripMenuItem,
            this.blurToolStripMenuItem});
            this.othersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("othersToolStripMenuItem.Image")));
            this.othersToolStripMenuItem.Name = "othersToolStripMenuItem";
            this.othersToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.othersToolStripMenuItem.Text = "Others";
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sepiaToolStripMenuItem.Image")));
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(139, 30);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("blurToolStripMenuItem.Image")));
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(139, 30);
            this.blurToolStripMenuItem.Text = "Blur";
            this.blurToolStripMenuItem.Click += new System.EventHandler(this.blurToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomModeToolStripMenuItem});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // zoomModeToolStripMenuItem
            // 
            this.zoomModeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("zoomModeToolStripMenuItem.Image")));
            this.zoomModeToolStripMenuItem.Name = "zoomModeToolStripMenuItem";
            this.zoomModeToolStripMenuItem.Size = new System.Drawing.Size(196, 30);
            this.zoomModeToolStripMenuItem.Text = "Zoom Mode";
            this.zoomModeToolStripMenuItem.Click += new System.EventHandler(this.zoomModeToolStripMenuItem_Click);
            // 
            // detailToolStripMenuItem
            // 
            this.detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            this.detailToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.detailToolStripMenuItem.Text = "Detail";
            this.detailToolStripMenuItem.Click += new System.EventHandler(this.detailToolStripMenuItem_Click);
            // 
            // preview_pbox
            // 
            this.preview_pbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.preview_pbox.Location = new System.Drawing.Point(0, 62);
            this.preview_pbox.Name = "preview_pbox";
            this.preview_pbox.Size = new System.Drawing.Size(561, 599);
            this.preview_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.preview_pbox.TabIndex = 2;
            this.preview_pbox.TabStop = false;
            this.preview_pbox.Click += new System.EventHandler(this.preview_pbox_Click);
            this.preview_pbox.MouseHover += new System.EventHandler(this.preview_pbox_MouseHover);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savetool,
            this.cameratool,
            this.browsertool});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(861, 31);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // savetool
            // 
            this.savetool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.savetool.Image = ((System.Drawing.Image)(resources.GetObject("savetool.Image")));
            this.savetool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.savetool.Name = "savetool";
            this.savetool.Size = new System.Drawing.Size(28, 28);
            this.savetool.Text = "toolStripButton1";
            this.savetool.Click += new System.EventHandler(this.savetool_Click);
            // 
            // cameratool
            // 
            this.cameratool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cameratool.Image = ((System.Drawing.Image)(resources.GetObject("cameratool.Image")));
            this.cameratool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cameratool.Name = "cameratool";
            this.cameratool.Size = new System.Drawing.Size(28, 28);
            this.cameratool.Text = "toolStripButton2";
            this.cameratool.Click += new System.EventHandler(this.cameratool_Click);
            // 
            // browsertool
            // 
            this.browsertool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.browsertool.Image = ((System.Drawing.Image)(resources.GetObject("browsertool.Image")));
            this.browsertool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.browsertool.Name = "browsertool";
            this.browsertool.Size = new System.Drawing.Size(28, 28);
            this.browsertool.Text = "toolStripButton3";
            this.browsertool.Click += new System.EventHandler(this.browsertool_Click);
            // 
            // browserlbl
            // 
            this.browserlbl.AutoSize = true;
            this.browserlbl.Font = new System.Drawing.Font("Forte", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browserlbl.Location = new System.Drawing.Point(657, 268);
            this.browserlbl.Name = "browserlbl";
            this.browserlbl.Size = new System.Drawing.Size(196, 31);
            this.browserlbl.TabIndex = 14;
            this.browserlbl.Text = "Image Browser";
            // 
            // browser
            // 
            this.browser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("browser.BackgroundImage")));
            this.browser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.browser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browser.ForeColor = System.Drawing.Color.PowderBlue;
            this.browser.Location = new System.Drawing.Point(567, 245);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(76, 85);
            this.browser.TabIndex = 13;
            this.browser.UseVisualStyleBackColor = true;
            this.browser.Click += new System.EventHandler(this.browser_Click);
            // 
            // webcamlbl
            // 
            this.webcamlbl.AutoSize = true;
            this.webcamlbl.Font = new System.Drawing.Font("Forte", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webcamlbl.Location = new System.Drawing.Point(657, 177);
            this.webcamlbl.Name = "webcamlbl";
            this.webcamlbl.Size = new System.Drawing.Size(107, 31);
            this.webcamlbl.TabIndex = 12;
            this.webcamlbl.Text = "Capture";
            // 
            // webcam
            // 
            this.webcam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("webcam.BackgroundImage")));
            this.webcam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.webcam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.webcam.ForeColor = System.Drawing.Color.PowderBlue;
            this.webcam.Location = new System.Drawing.Point(567, 154);
            this.webcam.Name = "webcam";
            this.webcam.Size = new System.Drawing.Size(76, 85);
            this.webcam.TabIndex = 11;
            this.webcam.UseVisualStyleBackColor = true;
            this.webcam.Click += new System.EventHandler(this.webcam_Click);
            // 
            // savelbl
            // 
            this.savelbl.AutoSize = true;
            this.savelbl.Font = new System.Drawing.Font("Forte", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savelbl.Location = new System.Drawing.Point(654, 97);
            this.savelbl.Name = "savelbl";
            this.savelbl.Size = new System.Drawing.Size(154, 31);
            this.savelbl.TabIndex = 10;
            this.savelbl.Text = "Save Image";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Transparent;
            this.save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save.BackgroundImage")));
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.PowderBlue;
            this.save.Location = new System.Drawing.Point(567, 62);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(76, 86);
            this.save.TabIndex = 9;
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(861, 662);
            this.Controls.Add(this.browserlbl);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.webcamlbl);
            this.Controls.Add(this.webcam);
            this.Controls.Add(this.savelbl);
            this.Controls.Add(this.save);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.preview_pbox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Filter";
            this.Text = "Filter";
            this.Load += new System.EventHandler(this.Filter_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preview_pbox)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gammaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem othersToolStripMenuItem;
        private System.Windows.Forms.PictureBox preview_pbox;
        private System.Windows.Forms.ToolStripMenuItem increaseBrightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decreaseBrightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomModeToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label browserlbl;
        private System.Windows.Forms.Button browser;
        private System.Windows.Forms.Label webcamlbl;
        private System.Windows.Forms.Button webcam;
        private System.Windows.Forms.Label savelbl;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripButton savetool;
        private System.Windows.Forms.ToolStripButton cameratool;
        private System.Windows.Forms.ToolStripButton browsertool;
    }
}