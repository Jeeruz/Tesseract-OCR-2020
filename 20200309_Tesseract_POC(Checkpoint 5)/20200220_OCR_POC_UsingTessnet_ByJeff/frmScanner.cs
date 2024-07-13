using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;
using System.IO;

namespace OCRPOC_TesseractByJeff
{
    public partial class frmScanner : Form
    {
        string path = "";
        int iCount = 1;
        public frmScanner()
        {
            InitializeComponent();
            ListScanners();
            string strDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString();
            txtScanOutput.Text = strDirectory + "\\Scanned";
        }

        public static string strTextPath = "";

        private void ListScanners()
        {
            // Clear the ListBox.
            listScanner.Items.Clear();
            // Create a DeviceManager instance
            var deviceManager = new DeviceManager();

            // Loop through the list of devices and add the name to the listbox
            for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
            {
                //Add the device only if it's a scanner
                if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                {
                    continue;
                }

                // Add the Scanner device to the listbox
                listScanner.Items.Add(
                    new Scanner(deviceManager.DeviceInfos[i])
                );
            }
        }

        private void TriggerScan()
        {
            MessageBox.Show("Image scanned successfully", "Image Scanner", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void StartScanning()
        {
            Scanner device = null;
            this.Invoke(new MethodInvoker(delegate ()
            {
                device = listScanner.SelectedItem as Scanner;
            }));

            if (device == null)
            {
                MessageBox.Show("You need to select first an scanner device from the list",
                                "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (String.IsNullOrEmpty(txtFileName.Text))
            {
                MessageBox.Show("Provide a filename", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Before can pick either TIFF, JPEG, PNG, JPG, etc.
            // That's why may Switch-Case
            ImageFile image = new ImageFile();
            string imageExtension = "";
            string strImageFormat = "TIFF";
            switch (strImageFormat)
            {
                case "TIFF":
                    image = device.ScanTIFF();
                    imageExtension = ".tiff";
                    break;
            }

            // Save the image
            var path = Path.Combine(txtScanOutput.Text,txtFileName.Text + imageExtension);
            if (!Directory.Exists(txtScanOutput.Text))
            {
                //Creates a folder if folder does not exist.
                MessageBox.Show("Directory of " + txtScanOutput.Text + " is not found. System is now creating a folder.", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Directory.CreateDirectory(txtScanOutput.Text);
            //Create a loop "Find" to check if file still exist.
            Find:
                if (File.Exists(path))
                {
                    string strFileName = txtFileName.Text + "(" + iCount.ToString() + ")";
                    path = Path.Combine(txtScanOutput.Text,strFileName + imageExtension);
                    iCount++;
                    goto Find;
                }
                else
                {
                    image.SaveFile(path);
                }
            }
            else
            {
            Find:
                if (File.Exists(path))
                {
                    string strFileName = txtFileName.Text + "(" + iCount.ToString() + ")";
                    path = Path.Combine(txtScanOutput.Text,strFileName + imageExtension);
                    iCount++;
                    goto Find;
                }
                else
                {
                    image.SaveFile(path);
                }
            }

            picScannedDoc.Image = new Bitmap(path);
            if (picScannedDoc.Image != null)
            {
                TriggerScan();
            }
        }

        private void btnChangeOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtScanOutput.Text = folderDlg.SelectedPath;
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(StartScanning);
        }

        private void frmScanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (picScannedDoc.Image != null)
            {
                if (iCount == 1)
                {
                    strTextPath = Path.Combine(txtScanOutput.Text,txtFileName.Text + ".tiff");
                    frmOCR.GetFilePath.strGetPath = strTextPath;
                    this.Dispose();
                }
                else
                {
                    iCount -= 1;
                    strTextPath = Path.Combine(txtScanOutput.Text,txtFileName.Text + "(" + iCount.ToString() + ")" + ".tiff");
                    frmOCR.GetFilePath.strGetPath = strTextPath;
                    this.Dispose();
                }

            }
            else
            {
                this.Dispose();
            }
        }
    }
}
