using System;
using System.Drawing;
using System.Windows.Forms;

namespace VPMidTask1
{
    public partial class MainForm : Form
    {
        Image browsed; //To store browsed image
        public MainForm()
        {
            InitializeComponent();
        }

        private void roundButton1_Click(object sender, EventArgs e)
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
                    /* Passing the browsed image in the parameterized constructor
                     of the filter form*/
                    filter = new Filter(browsed);
                    filter.Show();
                    this.Hide();
                }
            }
            catch { };
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void capture_Click(object sender, EventArgs e)
        {
            // If User clicks on the "Capture Image Button"
            CaptureImage captureImage = new CaptureImage();
            captureImage.Show();
            this.Hide();
        }
    }
}
