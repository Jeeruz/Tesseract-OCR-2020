namespace OCRPOC_TesseractByJeff
{
    partial class frmOCR
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.btnOpenScanner = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNewDocument = new System.Windows.Forms.Button();
            this.pnlSlidingPanel = new System.Windows.Forms.Panel();
            this.lblCoordinates = new System.Windows.Forms.Label();
            this.dgvCoordinates = new System.Windows.Forms.DataGridView();
            this.pnlTabMenu = new System.Windows.Forms.Panel();
            this.btnTab = new System.Windows.Forms.Button();
            this.tmrPanelSlider = new System.Windows.Forms.Timer(this.components);
            this.flpImage = new System.Windows.Forms.FlowLayoutPanel();
            this.clmTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmX1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmY1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmX2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmY2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSlidingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoordinates)).BeginInit();
            this.pnlTabMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.White;
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(116, 111);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(155, 25);
            this.txtPath.TabIndex = 10;
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Location = new System.Drawing.Point(8, 111);
            this.btnOpenImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(100, 26);
            this.btnOpenImage.TabIndex = 6;
            this.btnOpenImage.Text = "Open Image";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // btnOpenScanner
            // 
            this.btnOpenScanner.Location = new System.Drawing.Point(8, 4);
            this.btnOpenScanner.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenScanner.Name = "btnOpenScanner";
            this.btnOpenScanner.Size = new System.Drawing.Size(264, 28);
            this.btnOpenScanner.TabIndex = 15;
            this.btnOpenScanner.Text = "Scan";
            this.btnOpenScanner.UseVisualStyleBackColor = true;
            this.btnOpenScanner.Click += new System.EventHandler(this.btnOpenScanner_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(8, 75);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(264, 28);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "Clear Image";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnNewDocument
            // 
            this.btnNewDocument.Location = new System.Drawing.Point(8, 39);
            this.btnNewDocument.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewDocument.Name = "btnNewDocument";
            this.btnNewDocument.Size = new System.Drawing.Size(264, 28);
            this.btnNewDocument.TabIndex = 27;
            this.btnNewDocument.Text = "New Document";
            this.btnNewDocument.UseVisualStyleBackColor = true;
            this.btnNewDocument.Click += new System.EventHandler(this.btnNewDocument_Click);
            // 
            // pnlSlidingPanel
            // 
            this.pnlSlidingPanel.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSlidingPanel.Controls.Add(this.lblCoordinates);
            this.pnlSlidingPanel.Controls.Add(this.dgvCoordinates);
            this.pnlSlidingPanel.Controls.Add(this.btnOpenScanner);
            this.pnlSlidingPanel.Controls.Add(this.txtPath);
            this.pnlSlidingPanel.Controls.Add(this.btnNewDocument);
            this.pnlSlidingPanel.Controls.Add(this.btnClear);
            this.pnlSlidingPanel.Controls.Add(this.btnOpenImage);
            this.pnlSlidingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSlidingPanel.Location = new System.Drawing.Point(48, 0);
            this.pnlSlidingPanel.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSlidingPanel.Name = "pnlSlidingPanel";
            this.pnlSlidingPanel.Size = new System.Drawing.Size(520, 777);
            this.pnlSlidingPanel.TabIndex = 38;
            // 
            // lblCoordinates
            // 
            this.lblCoordinates.AutoSize = true;
            this.lblCoordinates.Location = new System.Drawing.Point(281, 11);
            this.lblCoordinates.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoordinates.Name = "lblCoordinates";
            this.lblCoordinates.Size = new System.Drawing.Size(0, 17);
            this.lblCoordinates.TabIndex = 34;
            // 
            // dgvCoordinates
            // 
            this.dgvCoordinates.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCoordinates.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCoordinates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoordinates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTextBox,
            this.clmX1,
            this.clmY1,
            this.clmX2,
            this.clmY2,
            this.Value});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCoordinates.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCoordinates.Location = new System.Drawing.Point(0, 166);
            this.dgvCoordinates.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCoordinates.Name = "dgvCoordinates";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCoordinates.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCoordinates.RowHeadersVisible = false;
            this.dgvCoordinates.RowHeadersWidth = 51;
            this.dgvCoordinates.Size = new System.Drawing.Size(422, 569);
            this.dgvCoordinates.TabIndex = 32;
            // 
            // pnlTabMenu
            // 
            this.pnlTabMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlTabMenu.Controls.Add(this.btnTab);
            this.pnlTabMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTabMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlTabMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTabMenu.Name = "pnlTabMenu";
            this.pnlTabMenu.Size = new System.Drawing.Size(48, 777);
            this.pnlTabMenu.TabIndex = 37;
            // 
            // btnTab
            // 
            this.btnTab.Location = new System.Drawing.Point(4, 4);
            this.btnTab.Margin = new System.Windows.Forms.Padding(4);
            this.btnTab.Name = "btnTab";
            this.btnTab.Size = new System.Drawing.Size(40, 41);
            this.btnTab.TabIndex = 34;
            this.btnTab.UseVisualStyleBackColor = true;
            this.btnTab.Click += new System.EventHandler(this.btnTab_Click);
            this.btnTab.Paint += new System.Windows.Forms.PaintEventHandler(this.btnTab_Paint);
            // 
            // tmrPanelSlider
            // 
            this.tmrPanelSlider.Interval = 1;
            this.tmrPanelSlider.Tick += new System.EventHandler(this.tmrPanelSlider_Tick);
            // 
            // flpImage
            // 
            this.flpImage.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.flpImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpImage.Location = new System.Drawing.Point(568, 0);
            this.flpImage.Margin = new System.Windows.Forms.Padding(4);
            this.flpImage.Name = "flpImage";
            this.flpImage.Size = new System.Drawing.Size(1192, 777);
            this.flpImage.TabIndex = 35;
            // 
            // clmTextBox
            // 
            this.clmTextBox.HeaderText = "Text Box";
            this.clmTextBox.MinimumWidth = 100;
            this.clmTextBox.Name = "clmTextBox";
            this.clmTextBox.Width = 125;
            // 
            // clmX1
            // 
            this.clmX1.HeaderText = "Start X1";
            this.clmX1.MinimumWidth = 50;
            this.clmX1.Name = "clmX1";
            this.clmX1.Width = 50;
            // 
            // clmY1
            // 
            this.clmY1.HeaderText = "Start Y1";
            this.clmY1.MinimumWidth = 50;
            this.clmY1.Name = "clmY1";
            this.clmY1.Width = 50;
            // 
            // clmX2
            // 
            this.clmX2.HeaderText = "End X2";
            this.clmX2.MinimumWidth = 50;
            this.clmX2.Name = "clmX2";
            this.clmX2.Width = 50;
            // 
            // clmY2
            // 
            this.clmY2.HeaderText = "End Y2";
            this.clmY2.MinimumWidth = 50;
            this.clmY2.Name = "clmY2";
            this.clmY2.Width = 50;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.MinimumWidth = 75;
            this.Value.Name = "Value";
            this.Value.Width = 75;
            // 
            // frmOCR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1760, 777);
            this.Controls.Add(this.flpImage);
            this.Controls.Add(this.pnlSlidingPanel);
            this.Controls.Add(this.pnlTabMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOCR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OCR POC - Main";
            this.pnlSlidingPanel.ResumeLayout(false);
            this.pnlSlidingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoordinates)).EndInit();
            this.pnlTabMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.Button btnOpenScanner;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnNewDocument;
        private System.Windows.Forms.Panel pnlSlidingPanel;
        private System.Windows.Forms.DataGridView dgvCoordinates;
        private System.Windows.Forms.Panel pnlTabMenu;
        private System.Windows.Forms.Button btnTab;
        private System.Windows.Forms.Timer tmrPanelSlider;
        private System.Windows.Forms.Label lblCoordinates;
        private System.Windows.Forms.FlowLayoutPanel flpImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmY1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmY2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}

