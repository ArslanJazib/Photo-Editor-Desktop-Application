using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video; //AForge.NET reference
using AForge.Video.DirectShow;//AForge.NET reference
using System.IO;
namespace VPMidTask1
{
    public partial class CaptureImage : Form
    {
        VideoCaptureDevice frame;//To record the video from the webcam        
        FilterInfoCollection Devices;//To select a device used for recording video       
        Image browsed;//To store browsed image
        bool cameraFlag;// To either switch on or off the webcam
        public CaptureImage()
        {
            InitializeComponent();
        }

        private void CaptureImage_Load(object sender, EventArgs e)
        {
            // Setting picturebox size mode as stretch image to display the whole image
            capturedImage_pbox.SizeMode = PictureBoxSizeMode.StretchImage;
            cameraFlag = true;//Intitally setting the flag to true because webcam is turned on by default
            Start_cam();//To start recording video from the webcam

        }
        void Start_cam()
        {
            //Choosing the video input device e.g webcam
            Devices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //Video is recorded from the default recording device
            frame = new VideoCaptureDevice(Devices[0].MonikerString);
            //Making a new frame event to transmit each frame in the picturebox
            frame.NewFrame += new AForge.Video.NewFrameEventHandler(NewFrame_event);
            //Keeping  playing the recording
            frame.Start();
        }
        void NewFrame_event(object send, NewFrameEventArgs e)
        {
            try
            {
                // Transmitting each frame in the picturebox
                capturedImage_pbox.Image = (Image)e.Frame.Clone();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void CaputeImage_Click(object sender, EventArgs e)
        {
            Image image=null;
            Filter filter = new Filter();
            // Captured image will be stored in this directory
            string output = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString()+"\\Images";
            // If image the path is correct and there is an image in the picturebox
            if (output != "" && capturedImage_pbox.Image != null)
            {
                //Resizing image according to the picture box size
                image=ResizeImage(capturedImage_pbox.Image, capturedImage_pbox.Size);
                // Sacing the picture in the output directory
                image.Save(output + "\\Image.png");
            }
            /* Giving user the choice if he/she wants to stay on the current form or move
            to the filter form*/
            DialogResult result = MessageBox.Show("Captured image is present in Images folder Do you want to open Filter Form", "Successful", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                /* Passing the browsed image in the parameterized constructor
                of the filter form*/
                filter = new Filter(image);
                this.Hide();
                filter.Show();
            }

        }
        private void webcam_Click(object sender, EventArgs e)
        {
            if(cameraFlag)//Camera was on
            {
                frame.Stop();//Stop recording
                capturedImage_pbox.Image = null;//Stop showing any image in picture box
                cameraFlag = false;//Turning the flag false to show camera is turned off
                //Changing the icon of the webcam button
                webcam.BackgroundImage = Image.FromFile(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString() + "\\Images\\Turn off cam.png");
            }
            else
            {
                //Camera was off
                Start_cam();//Start recording
                //Changing the icon of the webcam button
                webcam.BackgroundImage = Image.FromFile(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString() + "\\Images\\Turn on cam.png");
                cameraFlag = true;//Turning the flag True to show camera is turned ON
            }
        }
        private static Image ResizeImage(Image image,Size newSize)
        {
            // Initializing an image with the size of picture box
            Image resized = new Bitmap(newSize.Width, newSize.Height);
            //Drawing the captured image according to picture box size
            using (Graphics graphics = Graphics.FromImage((Bitmap)resized))
            {
                graphics.DrawImage(image, new Rectangle(Point.Empty, newSize));
            }
            return resized;
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void CaptureImage_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void CaptureImage_FormClosing(object sender, FormClosingEventArgs e)
        {
            frame.Stop();//Stop recording
            capturedImage_pbox.Image = null;//Stop showing any image in picture box
        }

        private void ReturnMainBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            frame.Stop();//Stop recording
            capturedImage_pbox.Image = null;//Stop showing any image in picture box
            this.Close();
            mainForm.Show();
        }

        private void browser_Click(object sender, EventArgs e)
        {
            // If User clicks on the "Browse Image Button"
            Filter filter = new Filter();
            // File Dialog box will be displayed so that user can select image
            openFileDialog1.ShowDialog();
            try
            {
                browsed = Image.FromFile(openFileDialog1.FileName);
                /* Giving user the choice if he/she wants to stay on the current form or move
                to the filter form*/
                DialogResult result = MessageBox.Show("Do you want to open Filter Form", "Successful", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    frame.Stop();
                    capturedImage_pbox.Image = null;
                    /* Passing the browsed image in the parameterized constructor
                    of the filter form*/
                    filter = new Filter(browsed);
                    this.Hide();
                    filter.Show();
                }
            }
            catch { };
            


        }
    }
}
