using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCRPOC_TesseractByJeff
{
    public partial class frmGetTxtname : Form
    {
        public static string sTextboxName { get; set; }

        public frmGetTxtname()
        {
            InitializeComponent();
        }

        private void btnKeepBox_Click(object sender, EventArgs e)
        {
            sTextboxName = txtNameOfBox.Text;
            this.Dispose();
        }

        private void btnNopeBox_Click(object sender, EventArgs e)
        {
            sTextboxName = "";
            this.Dispose();
        }
    }
}
