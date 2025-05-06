using System;
using System.Windows.Forms;
using PdfiumViewer;

namespace NavesImperiales
{
    public partial class frmPDFViewer : Form
    {
        private PdfViewer pdfViewer;
        private string pdfPath;

        // Constructor que recibe la ruta del PDF
        public frmPDFViewer(string path)
        {
            InitializeComponent();
            pdfPath = path;
        }



        private void frmPDFViewer_Load(object sender, EventArgs e)
        {
            pdfViewer = new PdfViewer();
            pdfViewer.Dock = DockStyle.Fill;
            this.Controls.Add(pdfViewer);

            try
            {
                var document = PdfDocument.Load(pdfPath);
                pdfViewer.Document = document;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar el PDF: " + ex.Message);
            }
        }
    }
}
