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
    public partial class frmDocTemplate : Form
    {
        bool bTabOpen = false;
        int iPanelWidth = 0;
        int startX, startY, curX, curY = 0;
        Pen pDrawBox;
        public List<RectangleBox> Box = new List<RectangleBox>();

        public class RectangleBox
        {
            public string BoxName = "";
            public int StartX = 0;
            public int StartY = 0;
            public int EndX = 0;
            public int EndY = 0;
        }

        //Flow layout panel image
        PictureBox pb = new PictureBox();
        public frmDocTemplate()
        {
            InitializeComponent();
            iPanelWidth = pnlSlidingPanel.Width;
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        #region Information Tab       
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
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string strfilePath = openFile.FileName.ToString();
                string strGetFileExtension = Path.GetExtension(strfilePath);
                try
                {
                    File.Move(strfilePath, Path.ChangeExtension(strfilePath, ".tiff"));
                    var varesult = Path.ChangeExtension(strfilePath, ".tiff");
                    pb.Image = new Bitmap(Image.FromStream(new MemoryStream(File.ReadAllBytes(varesult))));
                    txtPath.Text = varesult;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Oh no! It seems we had encountered a problem. \t\nDetails: " + ex.Message, "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            flpImage.AutoScroll = true;
            flpImage.Controls.Add(pb);
            pb.MouseMove += new MouseEventHandler(pcbxImg_MouseMove);
            pb.MouseDown += new MouseEventHandler(pcbxImg_MouseDown);
            pb.MouseUp += new MouseEventHandler(pcbxImg_MouseUp);

        }
        #endregion

        private void pcbxImg_MouseMove(object sender, MouseEventArgs e)
        {
            lblCoordinates.Text = "X = " + e.X + " ; Y = " + e.Y;
            try
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    pb.Refresh();
                    curX = e.X;
                    curY = e.Y;
                    Rectangle rect = new Rectangle(startX, startY, curX - startX, curY - startY);
                    pb.CreateGraphics().DrawRectangle(pDrawBox, rect);
                }
            }
            catch
            { }   
        }

        private void pcbxImg_MouseDown(object sender, MouseEventArgs e)
        {
            lblCoordinates.Text = "X = " + e.X + " ; Y = " + e.Y;
            try
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Cursor = Cursors.Cross;
                    startX = e.X;
                    startY = e.Y;
                    pDrawBox = new Pen(Color.Red, 2);
                }     
            }
            catch
            { }
        }

        private void pcbxImg_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Arrow;
            if (startX != 0 && startY != 0 && curX != 0 && curY != 0)
            {
                frmGetTxtname frmGetTxtname = new frmGetTxtname();
                frmGetTxtname.ShowDialog();

                if (frmGetTxtname.sTextboxName != "")
                {
                    dgvCoordinates.Rows.Add(frmGetTxtname.sTextboxName, startX, startY, curX, curY, "Remove");
                }
            }
        }

        private void dgvCoordinates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                try 
                {
                    dgvCoordinates.Rows.RemoveAt(dgvCoordinates.CurrentCell.RowIndex);
                }
                catch { }
            }
        }

        private void btnSaveDoc_Click(object sender, EventArgs e)
        {
            this.pb.Image.Dispose();
            foreach (DataGridViewRow item in dgvCoordinates.Rows)
            {
                RectangleBox box = new RectangleBox()
                {
                    BoxName = item.Cells[0].Value.ToString(),
                    StartX = Convert.ToInt32(item.Cells[1].Value),
                    StartY = Convert.ToInt32(item.Cells[2].Value),
                    EndX = Convert.ToInt32(item.Cells[3].Value),
                    EndY = Convert.ToInt32(item.Cells[4].Value)
                };
                Box.Add(box);
            }
        }
    }
}
