using System;
using System.Windows.Forms;
using System.Management;// Reference to get system information
using System.IO;
namespace VPMidTask1
{
    public partial class SystemInformation : Form
    {
        public SystemInformation()
        {
            InitializeComponent();
        }

        private void SystemInformation_Load(object sender, EventArgs e)
        {
            ManagementObjectSearcher myVideoObject = new ManagementObjectSearcher("select * from Win32_VideoController");
            // Looping through GPU(s)
            foreach (ManagementObject obj in myVideoObject.Get())
            {
                systemInfo.Text += "Graphic card (GPU)" + "\n";
                systemInfo.Text += "------------------" + "\n";
                systemInfo.Text +="Name: "+obj["Name"]+"\n";
                systemInfo.Text +="Status: "+ obj["Status"]+"\n";
                systemInfo.Text +="Adapter Ram: "+ obj["AdapterRAM"]+"\n";
                systemInfo.Text +="Driver Version: "+obj["DriverVersion"]+"\n";
            }
            //Looping through Disk Drives
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            systemInfo.Text += "------------------" + "\n";
            systemInfo.Text += "Hard Disk" + "\n";
            foreach (DriveInfo d in allDrives)
            {
                systemInfo.Text += "------------------" + "\n";
                systemInfo.Text += "Drive: " + d.Name + "\n";
                systemInfo.Text += "Drive Type: " + d.DriveType + "\n";
                if (d.IsReady == true)
                {
                    systemInfo.Text += "Available space to current user: " + SizeSuffix(d.AvailableFreeSpace)+ "\n";
                }
            }
            //Looping through Processors
            ManagementObjectSearcher myProcessorObject = new ManagementObjectSearcher("select * from Win32_Processor");
            systemInfo.Text += "------------------" + "\n";
            systemInfo.Text += "Processor(s)" + "\n";
            systemInfo.Text += "------------------" + "\n";
            foreach (ManagementObject obj in myProcessorObject.Get())
            {
                systemInfo.Text += "Name: " + obj["Name"] + "\n";
                systemInfo.Text += "Manufacturer: " + obj["Manufacturer"] + "\n";
                systemInfo.Text += "Caption: " + obj["Caption"] + "\n";
                systemInfo.Text += "Number Of Cores: " + obj["NumberOfCores"] + "\n";
            }
            ManagementObjectSearcher myOperativeSystemObject = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
            systemInfo.Text += "------------------" + "\n";
            systemInfo.Text += "Operative system" + "\n";
            systemInfo.Text += "------------------" + "\n";
            foreach (ManagementObject obj in myOperativeSystemObject.Get())
            {
                systemInfo.Text += "Caption: " + obj["Caption"] + "\n";
                systemInfo.Text += "Windows Directory: " + obj["WindowsDirectory"] + "\n";
                systemInfo.Text += "Country Code: " + obj["CountryCode"] + "\n";
                systemInfo.Text += "Version: " + obj["Version"] + "\n";
            }
        }
        //Changing Bytes to different unites for readability
        static readonly string[] SizeSuffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

        static string SizeSuffix(Int64 value)
        {
            if (value < 0) { return "-" + SizeSuffix(-value); }
            if (value == 0) { return "0.0 bytes"; }

            int mag = (int)Math.Log(value, 1024);
            decimal adjustedSize = (decimal)value / (1L << (mag * 10));

            return string.Format("{0:n1} {1}", adjustedSize, SizeSuffixes[mag]);
        }

        private void systemInfo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
