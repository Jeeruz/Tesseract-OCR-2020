namespace OCRPOC_TesseractByJeff
{
    partial class frmGetTxtname
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
            this.txtNameOfBox = new System.Windows.Forms.TextBox();
            this.lblTxtboxNm = new System.Windows.Forms.Label();
            this.btnKeepBox = new System.Windows.Forms.Button();
            this.btnNopeBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNameOfBox
            // 
            this.txtNameOfBox.Location = new System.Drawing.Point(180, 22);
            this.txtNameOfBox.Name = "txtNameOfBox";
            this.txtNameOfBox.Size = new System.Drawing.Size(100, 20);
            this.txtNameOfBox.TabIndex = 0;
            // 
            // lblTxtboxNm
            // 
            this.lblTxtboxNm.AutoSize = true;
            this.lblTxtboxNm.Location = new System.Drawing.Point(69, 29);
            this.lblTxtboxNm.Name = "lblTxtboxNm";
            this.lblTxtboxNm.Size = new System.Drawing.Size(105, 13);
            this.lblTxtboxNm.TabIndex = 1;
            this.lblTxtboxNm.Text = "Name of the textbox:";
            // 
            // btnKeepBox
            // 
            this.btnKeepBox.Location = new System.Drawing.Point(99, 58);
            this.btnKeepBox.Name = "btnKeepBox";
            this.btnKeepBox.Size = new System.Drawing.Size(75, 23);
            this.btnKeepBox.TabIndex = 2;
            this.btnKeepBox.Text = "Save";
            this.btnKeepBox.UseVisualStyleBackColor = true;
            this.btnKeepBox.Click += new System.EventHandler(this.btnKeepBox_Click);
            // 
            // btnNopeBox
            // 
            this.btnNopeBox.Location = new System.Drawing.Point(191, 58);
            this.btnNopeBox.Name = "btnNopeBox";
            this.btnNopeBox.Size = new System.Drawing.Size(75, 23);
            this.btnNopeBox.TabIndex = 3;
            this.btnNopeBox.Text = "Discard";
            this.btnNopeBox.UseVisualStyleBackColor = true;
            this.btnNopeBox.Click += new System.EventHandler(this.btnNopeBox_Click);
            // 
            // frmGetTxtname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 115);
            this.Controls.Add(this.btnNopeBox);
            this.Controls.Add(this.btnKeepBox);
            this.Controls.Add(this.lblTxtboxNm);
            this.Controls.Add(this.txtNameOfBox);
            this.Name = "frmGetTxtname";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OCR POC - Name the Textbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNameOfBox;
        private System.Windows.Forms.Label lblTxtboxNm;
        private System.Windows.Forms.Button btnKeepBox;
        private System.Windows.Forms.Button btnNopeBox;
    }
}