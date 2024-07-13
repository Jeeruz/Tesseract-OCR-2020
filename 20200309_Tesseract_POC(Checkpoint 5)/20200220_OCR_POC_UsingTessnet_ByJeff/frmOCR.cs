using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
using tessnet2;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace OCRPOC_TesseractByJeff
{
    public partial class frmOCR : Form
    {
        bool bTabOpen = false;
        int iPanelWidth = 0;
        int startX, startY, curX, curY = 0;
        Pen pDrawBox;
        string sPath, sFileName, sBoxName = "";
        frmDocTemplate frmDocTemplate = new frmDocTemplate();

        public frmOCR()
        {
            InitializeComponent();
            iPanelWidth = pnlSlidingPanel.Width;
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        //Flow layout panel image
        PictureBox pb = new PictureBox();
            

        public class GetFilePath
        {
            public static string strGetPath { get; set; }
        }

        private void btnTab_Paint(object sender, PaintEventArgs e)
        {
            Font fntMyFont = new Font("Arial", 9);
            Brush brshMyBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(21, 10);
            e.Graphics.RotateTransform(90);
            e.Graphics.DrawString("III", fntMyFont, brshMyBrush, 0, 0);
        }

        private void btnTab_Click(object sender, EventArgs e)
        {
            tmrPanelSlider.Start();
        }

        private void tmrPanelSlider_Tick(object sender, EventArgs e)
        {
            if (bTabOpen)
            {
                pnlSlidingPanel.Width = pnlSlidingPanel.Width + 17;
                if (pnlSlidingPanel.Width >= iPanelWidth)
                {
                    tmrPanelSlider.Stop();
                    bTabOpen = false;
                    this.Refresh();
                }
            }
            else
            {
                pnlSlidingPanel.Width = pnlSlidingPanel.Width - 17;
                if (pnlSlidingPanel.Width <= 0)
                {
                    tmrPanelSlider.Stop();
                    bTabOpen = true;
                    this.Refresh();
                }
            }
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            DelTempImg();
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                string strfilePath = opf.FileName.ToString();
                string strGetFileExtension = Path.GetExtension(strfilePath);
                try
                {
                    File.Move(strfilePath, Path.ChangeExtension(strfilePath, ".tiff"));
                    var varesult = Path.ChangeExtension(strfilePath, ".tiff");
                    pb.Image = new Bitmap(varesult);
                    txtPath.Text = varesult;
                    int iteraCurr = 0;

                    foreach (DataGridViewRow row in dgvCoordinates.Rows)
                    {
                        
                        sBoxName = row.Cells["clmTextBox"].Value.ToString();
                        startX = Convert.ToInt32(row.Cells["clmX1"].Value);
                        startY = Convert.ToInt32(row.Cells["clmY1"].Value); 
                        curX = Convert.ToInt32(row.Cells["clmX2"].Value); 
                        curY = Convert.ToInt32(row.Cells["clmY2"].Value); 

                        Rectangle rect = new Rectangle(startX, startY, curX - startX, curY - startY);

                        DrawRectangle(pb, rect);

                        string sImgLoc = "";
                        sImgLoc = txtPath.Text;
                        Tesseract(sImgLoc, rect, iteraCurr);
                        iteraCurr++;

                    }
            }
                catch (Exception ex)
            {
                MessageBox.Show("Oh no! It seems we had encountered a problem. \t\nDetails: " + ex.Message, "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

            flpImage.AutoScroll = true;
            flpImage.Controls.Add(pb);
            pb.MouseMove += new MouseEventHandler(pcbxImg_MouseMove);
            pb.MouseClick += new MouseEventHandler(pcbxImg_MouseClick);

        }

        private void pcbxImg_MouseMove(object sender, MouseEventArgs e)
        {
            lblCoordinates.Text = "X = " + e.X + " ; Y = " + e.Y;
        }

        private void pcbxImg_MouseClick(object sender, MouseEventArgs e)
        {
            lblCoordinates.Text = "X = " + e.X + " ; Y = " + e.Y;
        }

        private void btnOpenScanner_Click(object sender, EventArgs e)
        {
            frmScanner frmScanner = new frmScanner();
            frmScanner.ShowDialog();
        }

        private void btnNewDocument_Click(object sender, EventArgs e)
        {
            DialogResult result = frmDocTemplate.ShowDialog();
            if (result == DialogResult.OK)
            { 
                foreach (var item in frmDocTemplate.Box)
                {
                    dgvCoordinates.Rows.Add(item.BoxName, item.StartX, item.StartY, item.EndX, item.EndY);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        public void DrawRectangle(PictureBox pb, Rectangle rect)
        {
            //Draw box
            pb.Refresh();
            pDrawBox = new Pen(Color.Red, 2);
            Graphics gPbImage = Graphics.FromImage(pb.Image);
            gPbImage.DrawRectangle(pDrawBox, rect);
        }

        public void Tesseract(string sImgPath, Rectangle rect, int rowIteration)
        {
            //Tesseract 
            var image = new Bitmap(sImgPath);
            var ocr = new Tesseract();
            ocr.Init("./Content/tessdata", "eng", false);
            var result = ocr.DoOCR(image, rect);
            string strRes = "";
            foreach (tessnet2.Word word in result)
            {
                if (strRes == "")
                {
                    strRes = word.Text;
                }
                else
                {
                    strRes = strRes + " " + word.Text;
                }
            }

            dgvCoordinates.Rows[rowIteration].Cells[5].Value = strRes;
        }

        public void DelTempImg()
        {
            //Delete all temporary images
            System.IO.DirectoryInfo di = new DirectoryInfo((Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Scanned\temp\"));

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            } 
        }
    }
}
