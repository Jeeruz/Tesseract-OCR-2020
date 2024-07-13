namespace OCRPOC_TesseractByJeff
{
    partial class frmScanner
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtScanOutput = new System.Windows.Forms.TextBox();
            this.btnChangeOutput = new System.Windows.Forms.Button();
            this.listScanner = new System.Windows.Forms.ListBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.picScannedDoc = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picScannedDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Select a scanner";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Filename";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(12, 127);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(194, 20);
            this.txtFileName.TabIndex = 13;
            this.txtFileName.Text = "ScannedDocument";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Output scanned images";
            // 
            // txtScanOutput
            // 
            this.txtScanOutput.Enabled = false;
            this.txtScanOutput.Location = new System.Drawing.Point(12, 166);
            this.txtScanOutput.Name = "txtScanOutput";
            this.txtScanOutput.Size = new System.Drawing.Size(194, 20);
            this.txtScanOutput.TabIndex = 11;
            // 
            // btnChangeOutput
            // 
            this.btnChangeOutput.Location = new System.Drawing.Point(12, 192);
            this.btnChangeOutput.Name = "btnChangeOutput";
            this.btnChangeOutput.Size = new System.Drawing.Size(194, 38);
            this.btnChangeOutput.TabIndex = 10;
            this.btnChangeOutput.Text = "Change output folder";
            this.btnChangeOutput.UseVisualStyleBackColor = true;
            this.btnChangeOutput.Click += new System.EventHandler(this.btnChangeOutput_Click);
            // 
            // listScanner
            // 
            this.listScanner.FormattingEnabled = true;
            this.listScanner.Location = new System.Drawing.Point(12, 25);
            this.listScanner.Name = "listScanner";
            this.listScanner.ScrollAlwaysVisible = true;
            this.listScanner.Size = new System.Drawing.Size(194, 82);
            this.listScanner.TabIndex = 9;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(12, 236);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(194, 38);
            this.btnScan.TabIndex = 16;
            this.btnScan.Text = "Start scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // picScannedDoc
            // 
            this.picScannedDoc.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.picScannedDoc.Location = new System.Drawing.Point(219, 12);
            this.picScannedDoc.Name = "picScannedDoc";
            this.picScannedDoc.Size = new System.Drawing.Size(665, 581);
            this.picScannedDoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picScannedDoc.TabIndex = 17;
            this.picScannedDoc.TabStop = false;
            // 
            // frmScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 605);
            this.Controls.Add(this.picScannedDoc);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtScanOutput);
            this.Controls.Add(this.btnChangeOutput);
            this.Controls.Add(this.listScanner);
            this.Name = "frmScanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OCR POC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmScanner_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picScannedDoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtScanOutput;
        private System.Windows.Forms.Button btnChangeOutput;
        private System.Windows.Forms.ListBox listScanner;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.PictureBox picScannedDoc;
    }
}