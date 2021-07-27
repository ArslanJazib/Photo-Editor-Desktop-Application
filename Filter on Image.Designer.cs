namespace VPMidTask1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.capture_btn = new VPMidTask1.RoundButton();
            this.browse_btn = new VPMidTask1.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(273, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(273, 318);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // capture_btn
            // 
            this.capture_btn.BackColor = System.Drawing.Color.White;
            this.capture_btn.BorderColor = System.Drawing.Color.Transparent;
            this.capture_btn.ButtonColor = System.Drawing.Color.PowderBlue;
            this.capture_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.capture_btn.FlatAppearance.BorderSize = 0;
            this.capture_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.capture_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.capture_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.capture_btn.Font = new System.Drawing.Font("Forte", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capture_btn.Location = new System.Drawing.Point(351, 308);
            this.capture_btn.Name = "capture_btn";
            this.capture_btn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.capture_btn.OnHoverButtonColor = System.Drawing.Color.AliceBlue;
            this.capture_btn.OnHoverTextColor = System.Drawing.Color.Black;
            this.capture_btn.Size = new System.Drawing.Size(226, 75);
            this.capture_btn.TabIndex = 1;
            this.capture_btn.Text = "Capture Image";
            this.capture_btn.TextColor = System.Drawing.Color.Black;
            this.capture_btn.UseVisualStyleBackColor = false;
            this.capture_btn.Click += new System.EventHandler(this.capture_Click);
            // 
            // browse_btn
            // 
            this.browse_btn.BackColor = System.Drawing.Color.Transparent;
            this.browse_btn.BorderColor = System.Drawing.Color.Transparent;
            this.browse_btn.ButtonColor = System.Drawing.Color.PowderBlue;
            this.browse_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.browse_btn.FlatAppearance.BorderSize = 0;
            this.browse_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.browse_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.browse_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browse_btn.Font = new System.Drawing.Font("Forte", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse_btn.Location = new System.Drawing.Point(351, 179);
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.browse_btn.OnHoverButtonColor = System.Drawing.Color.AliceBlue;
            this.browse_btn.OnHoverTextColor = System.Drawing.Color.Black;
            this.browse_btn.Size = new System.Drawing.Size(226, 75);
            this.browse_btn.TabIndex = 0;
            this.browse_btn.Text = "Browse Image";
            this.browse_btn.TextColor = System.Drawing.Color.Black;
            this.browse_btn.UseVisualStyleBackColor = false;
            this.browse_btn.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 599);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.capture_btn);
            this.Controls.Add(this.browse_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Filter on Image";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundButton browse_btn;
        private RoundButton capture_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}