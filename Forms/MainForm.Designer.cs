
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lvNaus = new System.Windows.Forms.ListView();
            this.dgvEspec = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbFilePDF = new System.Windows.Forms.PictureBox();
            this.pbPlanols = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilePDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlanols)).BeginInit();
            this.SuspendLayout();
            // 
            // lvNaus
            // 
            this.lvNaus.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lvNaus.HideSelection = false;
            this.lvNaus.Location = new System.Drawing.Point(12, 12);
            this.lvNaus.Name = "lvNaus";
            this.lvNaus.Size = new System.Drawing.Size(250, 376);
            this.lvNaus.TabIndex = 0;
            this.lvNaus.UseCompatibleStateImageBehavior = false;
            this.lvNaus.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // dgvEspec
            // 
            this.dgvEspec.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvEspec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colValor});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEspec.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEspec.Enabled = false;
            this.dgvEspec.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvEspec.Location = new System.Drawing.Point(280, 270);
            this.dgvEspec.Name = "dgvEspec";
            this.dgvEspec.ReadOnly = true;
            this.dgvEspec.RowHeadersVisible = false;
            this.dgvEspec.RowHeadersWidth = 62;
            this.dgvEspec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEspec.Size = new System.Drawing.Size(341, 242);
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
            // pbFilePDF
            // 
            this.pbFilePDF.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbFilePDF.Image = global::NavesImperiales.Properties.Resources.pdfW;
            this.pbFilePDF.Location = new System.Drawing.Point(620, 279);
            this.pbFilePDF.Name = "pbFilePDF";
            this.pbFilePDF.Size = new System.Drawing.Size(60, 63);
            this.pbFilePDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFilePDF.TabIndex = 5;
            this.pbFilePDF.TabStop = false;
            this.pbFilePDF.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbPlanols
            // 
            this.pbPlanols.Location = new System.Drawing.Point(280, 12);
            this.pbPlanols.Name = "pbPlanols";
            this.pbPlanols.Size = new System.Drawing.Size(400, 250);
            this.pbPlanols.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlanols.TabIndex = 1;
            this.pbPlanols.TabStop = false;
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1036, 660);
            this.Controls.Add(this.pbFilePDF);
            this.Controls.Add(this.dgvEspec);
            this.Controls.Add(this.pbPlanols);
            this.Controls.Add(this.lvNaus);
            this.Name = "MainForm";
            this.Text = "Naves Imperiales";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilePDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlanols)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvNaus;
        private System.Windows.Forms.PictureBox pbPlanols;
        private System.Windows.Forms.DataGridView dgvEspec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.PictureBox pbFilePDF;
    }
}