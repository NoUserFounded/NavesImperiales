using System;
using System.Windows.Forms;
using PdfiumViewer;

namespace NavesImperiales
{
    public partial class frmPDFViewer : Form
    {
        private string pdfPath;

        // Constructor que recibe la ruta del PDF
        public frmPDFViewer(string path)
        {
            InitializeComponent();
            pdfPath = path;
        }



        private void frmPDFViewer_Load(object sender, EventArgs e)
        {
            try
            {
                var document = PdfDocument.Load(pdfPath);
                pdfViewer1.Document = document;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar el PDF: " + ex.Message);
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
