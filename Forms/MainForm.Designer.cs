
namespace NavesImperiales
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lvNaus = new System.Windows.Forms.ListView();
            this.dgvEspec = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.wmpView360 = new AxWMPLib.AxWindowsMediaPlayer();
            this.lvShipsImages = new System.Windows.Forms.ListView();
            this.lbShipName = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbSelectedImg = new System.Windows.Forms.PictureBox();
            this.pbFilePDF = new System.Windows.Forms.PictureBox();
            this.pbPlanols = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpView360)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilePDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlanols)).BeginInit();
            this.SuspendLayout();
            // 
            // lvNaus
            // 
            this.lvNaus.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lvNaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvNaus.ForeColor = System.Drawing.SystemColors.Window;
            this.lvNaus.HideSelection = false;
            this.lvNaus.Location = new System.Drawing.Point(29, 41);
            this.lvNaus.Name = "lvNaus";
            this.lvNaus.Size = new System.Drawing.Size(196, 216);
            this.lvNaus.TabIndex = 0;
            this.lvNaus.UseCompatibleStateImageBehavior = false;
            this.lvNaus.View = System.Windows.Forms.View.List;
            this.lvNaus.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // dgvEspec
            // 
            this.dgvEspec.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvEspec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspec.ColumnHeadersVisible = false;
            this.dgvEspec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colValor});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEspec.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEspec.Enabled = false;
            this.dgvEspec.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvEspec.Location = new System.Drawing.Point(298, 427);
            this.dgvEspec.Name = "dgvEspec";
            this.dgvEspec.ReadOnly = true;
            this.dgvEspec.RowHeadersVisible = false;
            this.dgvEspec.RowHeadersWidth = 62;
            this.dgvEspec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEspec.Size = new System.Drawing.Size(316, 209);
            this.dgvEspec.TabIndex = 2;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Detalle";
            this.colNombre.MinimumWidth = 8;
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 150;
            // 
            // colValor
            // 
            this.colValor.HeaderText = "Valor";
            this.colValor.MinimumWidth = 8;
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            this.colValor.Width = 150;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Snow;
            this.lblTitle.Location = new System.Drawing.Point(25, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(185, 24);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Light Fighter Ships";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDescription.Location = new System.Drawing.Point(29, 263);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(196, 284);
            this.txtDescription.TabIndex = 7;
            this.txtDescription.Text = "";
            // 
            // wmpView360
            // 
            this.wmpView360.Enabled = true;
            this.wmpView360.Location = new System.Drawing.Point(775, 41);
            this.wmpView360.Name = "wmpView360";
            this.wmpView360.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpView360.OcxState")));
            this.wmpView360.Size = new System.Drawing.Size(592, 370);
            this.wmpView360.TabIndex = 9;
            this.wmpView360.Visible = false;
            // 
            // lvShipsImages
            // 
            this.lvShipsImages.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lvShipsImages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvShipsImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvShipsImages.ForeColor = System.Drawing.SystemColors.Window;
            this.lvShipsImages.HideSelection = false;
            this.lvShipsImages.Location = new System.Drawing.Point(759, 427);
            this.lvShipsImages.Name = "lvShipsImages";
            this.lvShipsImages.Size = new System.Drawing.Size(647, 100);
            this.lvShipsImages.TabIndex = 10;
            this.lvShipsImages.UseCompatibleStateImageBehavior = false;
            this.lvShipsImages.SelectedIndexChanged += new System.EventHandler(this.lvShipsImages_SelectedIndexChanged);
            // 
            // lbShipName
            // 
            this.lbShipName.AutoSize = true;
            this.lbShipName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbShipName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShipName.ForeColor = System.Drawing.Color.Snow;
            this.lbShipName.Location = new System.Drawing.Point(967, 522);
            this.lbShipName.Name = "lbShipName";
            this.lbShipName.Size = new System.Drawing.Size(0, 25);
            this.lbShipName.TabIndex = 11;
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbClose.Image = global::NavesImperiales.Properties.Resources.delete;
            this.pbClose.Location = new System.Drawing.Point(1321, 12);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(20, 21);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 12;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // pbSelectedImg
            // 
            this.pbSelectedImg.Location = new System.Drawing.Point(775, 41);
            this.pbSelectedImg.Name = "pbSelectedImg";
            this.pbSelectedImg.Size = new System.Drawing.Size(592, 370);
            this.pbSelectedImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSelectedImg.TabIndex = 8;
            this.pbSelectedImg.TabStop = false;
            this.pbSelectedImg.Visible = false;
            // 
            // pbFilePDF
            // 
            this.pbFilePDF.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbFilePDF.Image = global::NavesImperiales.Properties.Resources.pdfW;
            this.pbFilePDF.Location = new System.Drawing.Point(665, 427);
            this.pbFilePDF.Name = "pbFilePDF";
            this.pbFilePDF.Size = new System.Drawing.Size(60, 63);
            this.pbFilePDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFilePDF.TabIndex = 5;
            this.pbFilePDF.TabStop = false;
            this.pbFilePDF.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbPlanols
            // 
            this.pbPlanols.Location = new System.Drawing.Point(240, 41);
            this.pbPlanols.Name = "pbPlanols";
            this.pbPlanols.Size = new System.Drawing.Size(485, 370);
            this.pbPlanols.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlanols.TabIndex = 1;
            this.pbPlanols.TabStop = false;
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1434, 660);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.lbShipName);
            this.Controls.Add(this.lvShipsImages);
            this.Controls.Add(this.wmpView360);
            this.Controls.Add(this.pbSelectedImg);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbFilePDF);
            this.Controls.Add(this.dgvEspec);
            this.Controls.Add(this.pbPlanols);
            this.Controls.Add(this.lvNaus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Naves Imperiales";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpView360)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilePDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlanols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvNaus;
        private System.Windows.Forms.PictureBox pbPlanols;
        private System.Windows.Forms.DataGridView dgvEspec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.PictureBox pbFilePDF;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RichTextBox txtDescription;
        private AxWMPLib.AxWindowsMediaPlayer wmpView360;
        private System.Windows.Forms.PictureBox pbSelectedImg;
        private System.Windows.Forms.ListView lvShipsImages;
        private System.Windows.Forms.Label lbShipName;
        private System.Windows.Forms.PictureBox pbClose;
    }
}