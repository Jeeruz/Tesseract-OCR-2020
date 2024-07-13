namespace OCRPOC_TesseractByJeff
{
    partial class frmDocTemplate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tmrPanelSlider = new System.Windows.Forms.Timer(this.components);
            this.txtPath = new System.Windows.Forms.TextBox();
            this.dgvCoordinates = new System.Windows.Forms.DataGridView();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlSlidingPanel = new System.Windows.Forms.Panel();
            this.lblCoordinates = new System.Windows.Forms.Label();
            this.flpImage = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSaveDoc = new System.Windows.Forms.Button();
            this.clmTextBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmX1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmY1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmX2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmY2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnTab = new System.Windows.Forms.Button();
            this.pnlTabMenu = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoordinates)).BeginInit();
            this.pnlSlidingPanel.SuspendLayout();
            this.pnlTabMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrPanelSlider
            // 
            this.tmrPanelSlider.Interval = 1;
            this.tmrPanelSlider.Tick += new System.EventHandler(this.tmrPanelSlider_Tick);
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.White;
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(87, 31);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(118, 21);
            this.txtPath.TabIndex = 29;
            // 
            // dgvCoordinates
            // 
            this.dgvCoordinates.AllowUserToAddRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCoordinates.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvCoordinates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoordinates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTextBox,
            this.clmX1,
            this.clmY1,
            this.clmX2,
            this.clmY2,
            this.btnRemove});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCoordinates.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvCoordinates.Location = new System.Drawing.Point(6, 58);
            this.dgvCoordinates.Name = "dgvCoordinates";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCoordinates.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvCoordinates.RowHeadersVisible = false;
            this.dgvCoordinates.Size = new System.Drawing.Size(379, 265);
            this.dgvCoordinates.TabIndex = 32;
            this.dgvCoordinates.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoordinates_CellContentClick);
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Location = new System.Drawing.Point(6, 31);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(75, 21);
            this.btnOpenImage.TabIndex = 28;
            this.btnOpenImage.Text = "Open Image";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(199, 23);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "Clear Image";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // pnlSlidingPanel
            // 
            this.pnlSlidingPanel.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSlidingPanel.Controls.Add(this.btnSaveDoc);
            this.pnlSlidingPanel.Controls.Add(this.lblCoordinates);
            this.pnlSlidingPanel.Controls.Add(this.btnClear);
            this.pnlSlidingPanel.Controls.Add(this.btnOpenImage);
            this.pnlSlidingPanel.Controls.Add(this.dgvCoordinates);
            this.pnlSlidingPanel.Controls.Add(this.txtPath);
            this.pnlSlidingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSlidingPanel.Location = new System.Drawing.Point(36, 0);
            this.pnlSlidingPanel.Name = "pnlSlidingPanel";
            this.pnlSlidingPanel.Size = new System.Drawing.Size(390, 631);
            this.pnlSlidingPanel.TabIndex = 36;
            // 
            // lblCoordinates
            // 
            this.lblCoordinates.AutoSize = true;
            this.lblCoordinates.Location = new System.Drawing.Point(212, 8);
            this.lblCoordinates.Name = "lblCoordinates";
            this.lblCoordinates.Size = new System.Drawing.Size(0, 13);
            this.lblCoordinates.TabIndex = 33;
            // 
            // flpImage
            // 
            this.flpImage.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.flpImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpImage.Location = new System.Drawing.Point(426, 0);
            this.flpImage.Name = "flpImage";
            this.flpImage.Size = new System.Drawing.Size(894, 631);
            this.flpImage.TabIndex = 37;
            // 
            // btnSaveDoc
            // 
            this.btnSaveDoc.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveDoc.Location = new System.Drawing.Point(142, 329);
            this.btnSaveDoc.Name = "btnSaveDoc";
            this.btnSaveDoc.Size = new System.Drawing.Size(100, 23);
            this.btnSaveDoc.TabIndex = 0;
            this.btnSaveDoc.Text = "Save Document";
            this.btnSaveDoc.UseVisualStyleBackColor = true;
            this.btnSaveDoc.Click += new System.EventHandler(this.btnSaveDoc_Click);
            // 
            // clmTextBox
            // 
            this.clmTextBox.HeaderText = "Text Box";
            this.clmTextBox.MinimumWidth = 100;
            this.clmTextBox.Name = "clmTextBox";
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
            // btnRemove
            // 
            this.btnRemove.HeaderText = "Remove Box";
            this.btnRemove.MinimumWidth = 75;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Width = 75;
            // 
            // btnTab
            // 
            this.btnTab.Location = new System.Drawing.Point(3, 3);
            this.btnTab.Name = "btnTab";
            this.btnTab.Size = new System.Drawing.Size(30, 33);
            this.btnTab.TabIndex = 34;
            this.btnTab.UseVisualStyleBackColor = true;
            this.btnTab.Click += new System.EventHandler(this.btnTab_Click);
            this.btnTab.Paint += new System.Windows.Forms.PaintEventHandler(this.btnTab_Paint);
            // 
            // pnlTabMenu
            // 
            this.pnlTabMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlTabMenu.Controls.Add(this.btnTab);
            this.pnlTabMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTabMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlTabMenu.Name = "pnlTabMenu";
            this.pnlTabMenu.Size = new System.Drawing.Size(36, 631);
            this.pnlTabMenu.TabIndex = 35;
            // 
            // frmDocTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 631);
            this.Controls.Add(this.flpImage);
            this.Controls.Add(this.pnlSlidingPanel);
            this.Controls.Add(this.pnlTabMenu);
            this.Name = "frmDocTemplate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OCR POC - New Template";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoordinates)).EndInit();
            this.pnlSlidingPanel.ResumeLayout(false);
            this.pnlSlidingPanel.PerformLayout();
            this.pnlTabMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrPanelSlider;
        public System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.DataGridView dgvCoordinates;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlSlidingPanel;
        private System.Windows.Forms.FlowLayoutPanel flpImage;
        private System.Windows.Forms.Label lblCoordinates;
        private System.Windows.Forms.Button btnSaveDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmY1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmY2;
        private System.Windows.Forms.DataGridViewButtonColumn btnRemove;
        private System.Windows.Forms.Button btnTab;
        private System.Windows.Forms.Panel pnlTabMenu;
    }
}