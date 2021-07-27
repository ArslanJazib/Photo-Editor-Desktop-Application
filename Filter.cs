using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Imaging.Filters;//AForge.NET reference
using System.Drawing.Imaging;
namespace VPMidTask1
{
    public partial class Filter : Form
    {
        Image toBeEdited;//Will store the image which is either browsed or captured by the user
        bool zoomFlag;//Checks whether if use is currently in zoom mode
        Size orignalSize;//To store the orignal size of the image for when the user chooses to zoom out
        Image browsed;//To store the browsed image
        public Filter()
        {
            InitializeComponent();
        }
        public Filter(Image image )
        {
            InitializeComponent();
            toBeEdited = image;//Initiliazing toBeEdited with the images passed by the user
        }
        private void Filter_Load(object sender, EventArgs e)
        {
            preview_pbox.Image = toBeEdited;//Displaying the image in the preview box
            orignalSize = preview_pbox.Size;//storing orignal size of the image

        }

        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Initializing with the picture 
            Bitmap invertImage = (Bitmap)preview_pbox.Image;
            // Invert filter from AForge.Imaging.Filters
            Invert filter = new Invert();
            // Applying filter
            filter.ApplyInPlace(invertImage);
            // Displaying the reuslt in the preview box
            preview_pbox.Image = invertImage; 
        }

        private void grayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Initializing with the picture 
            Bitmap grayscaleImage = (Bitmap)preview_pbox.Image;
            // Grayscale filter from AForge.Imaging.Filters
            Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
            try
            {
                // Applying filter
                grayscaleImage = filter.Apply(grayscaleImage);
                // Displaying the reuslt in the preview box
                preview_pbox.Image = grayscaleImage;
            }
            catch(Exception excep)
            {
                // Grayscale filter can't be applied on all images
                MessageBox.Show(excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void brightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void increaseBrightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Initializing with the picture 
            Bitmap brightnessImage = (Bitmap)preview_pbox.Image;
            // Brightness filter from AForge.Imaging.Filters
            BrightnessCorrection filter = new BrightnessCorrection(10);
            // Applying filter
            filter.ApplyInPlace(brightnessImage);
            // Displaying the reuslt in the preview box
            preview_pbox.Image = brightnessImage;
        }

        private void decreaseBrightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Initializing with the picture 
            Bitmap brightnessImage = (Bitmap)preview_pbox.Image;
            // Brightness filter from AForge.Imaging.Filters
            BrightnessCorrection filter = new BrightnessCorrection(-10);
            // Applying filter
            filter.ApplyInPlace(brightnessImage);
            // Displaying the reuslt in the preview box
            preview_pbox.Image = brightnessImage;
        }

        private void contrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Initializing with the picture 
            Bitmap contrastImage = (Bitmap)preview_pbox.Image;
            // Contrast filter from AForge.Imaging.Filters
            ContrastCorrection filter = new ContrastCorrection(15);
            // Applying filter
            filter.ApplyInPlace(contrastImage);
            // Displaying the reuslt in the preview box
            preview_pbox.Image = contrastImage;

        }

        private void gammaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Initializing with the picture 
            Bitmap gammaImage = (Bitmap)preview_pbox.Image;
            // Gamma filter from AForge.Imaging.Filters
            GammaCorrection filter = new GammaCorrection(0.5);
            // Applying filter
            filter.ApplyInPlace(gammaImage);
            // Displaying the reuslt in the preview box
            preview_pbox.Image = gammaImage;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Initializing with the picture 
            Bitmap mappingImage = (Bitmap)preview_pbox.Image;
            // Create map
            byte[] map = new byte[256];
            for (int i = 0; i < 256; i++)
            {
                map[i] = (byte)Math.Min(255, Math.Pow(2, (double)i / 32));
            }
            // Create filter
            ColorRemapping filter = new ColorRemapping(map, map, map);
            // Apply the filter
            filter.ApplyInPlace(mappingImage);
            preview_pbox.Image = mappingImage;
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Initializing with the picture 
            Bitmap sepiaImage = (Bitmap)preview_pbox.Image;
            // Sepia filter from AForge.Imaging.Filters
            Sepia filter = new Sepia();
            //Applying Filter
            filter.ApplyInPlace(sepiaImage);
            // Displaying the reuslt in the preview box
            preview_pbox.Image = sepiaImage;
        }

        private void blurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Initializing with the picture 
            Bitmap blurImage = (Bitmap)preview_pbox.Image;
            // Blur filter from AForge.Imaging.Filters
            Blur filter = new Blur();
            //Applying Filter
            filter.ApplyInPlace(blurImage);
            // Displaying the reuslt in the preview box
            preview_pbox.Image = blurImage;
        }

        private void preview_pbox_Click(object sender, EventArgs e)
        {

        }

        private void zoomModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(zoomFlag)// If the user is currently in zoom mode
            {
                zoomFlag = false;//setting to zoom flag zoom false to turn off zoom mode
                WindowState = FormWindowState.Normal;//Turning the winfrom size from maximized to normal
                preview_pbox.Size = orignalSize;//setting the picture box to orignal size
                toolStrip1.Visible = false;// Hiding the tool strip
                // Displaying the buttons
                save.Visible = true;
                savelbl.Visible = true;
                webcam.Visible = true;
                webcamlbl.Visible = true;
                browser.Visible = true;
                browserlbl.Visible = true;
            }
            else
            {
                // Hiding the buttons
                save.Visible = false;
                savelbl.Visible = false;
                webcam.Visible = false;
                webcamlbl.Visible = false;
                browser.Visible = false;
                browserlbl.Visible = false;
                zoomFlag = true;


            }
        }

        private void preview_pbox_MouseHover(object sender, EventArgs e)
        {
            if(zoomFlag)// If the user is in zoom mode and hovers over the preview box
            {
                WindowState = FormWindowState.Maximized;//Maximize the form
                //Maximize the picture box
                preview_pbox.Width = this.Width;
                preview_pbox.Height = this.Height;
                // Display the buttons on the tool strip
                toolStrip1.Visible = true;

            }
        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If user clicks on the detail button
            SystemInformation systemInformation = new SystemInformation();
            systemInformation.Show();
        }

        private void save_Click(object sender, EventArgs e)
        {
            // save dialog box will only save images as the following extensions
            saveFileDialog1.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            // If user presses ok button on the dialog box
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // setting extension
                string ext = System.IO.Path.GetExtension(saveFileDialog1.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                // saving image
                preview_pbox.Image.Save(saveFileDialog1.FileName, format);

            }
        }
        private void browser_Click(object sender, EventArgs e)
        {
            // If User clicks on the "Browse Image Button"
            // File Dialog box will be displayed so that user can select image
            openFileDialog1.ShowDialog();
            try
            {
                browsed = Image.FromFile(openFileDialog1.FileName);
                // If user wants to edit the picture place it in the preview picturebox
                DialogResult result = MessageBox.Show("Do you want to edit browsed image", "Successful", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    preview_pbox.Image = browsed;
                }
            }
            catch { };
        }

        private void webcam_Click(object sender, EventArgs e)
        {
            
            CaptureImage capture = new CaptureImage();
            capture.Show();
            this.Hide();
        }

        private void savetool_Click(object sender, EventArgs e)
        {
            // save dialog box will only save images as the following extensions
            saveFileDialog1.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            // If user presses ok button on the dialog box
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveFileDialog1.FileName);
                switch (ext)
                {
                    // setting extension
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                //saving image
                preview_pbox.Image.Save(saveFileDialog1.FileName, format);
            }
        }
        private void cameratool_Click(object sender, EventArgs e)
        {
            CaptureImage capture = new CaptureImage();
            capture.Show();
            this.Hide();
        }

        private void browsertool_Click(object sender, EventArgs e)
        {
            // If User clicks on the "Browse Image Button"
            // File Dialog box will be displayed so that user can select image
            openFileDialog1.ShowDialog();
            try
            {
                browsed = Image.FromFile(openFileDialog1.FileName);
                // If user wants to edit the picture place it in the preview picturebox
                DialogResult result = MessageBox.Show("Do you want to edit browsed image", "Successful", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    preview_pbox.Image = browsed;
                }
            }
            catch { };
        }
    }

}
