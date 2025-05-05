using NavesImperialesModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavesImperiales
{
    public partial class MainForm : Form
    {
        private TechnicalInfo technicalInfo;
        private InfoOption selectedOption;
        private InfoDetail selectedDetail;

        private string basePath = Application.StartupPath;

        public MainForm()
        {
            InitializeComponent();
            Load_Data();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (selectedDetail == null) return;

            string pdfPath = Path.Combine(basePath, "images/", selectedOption.textOption, selectedDetail.pdfFile);
            if (File.Exists(pdfPath))
            {
                System.Diagnostics.Process.Start(pdfPath);
            }
            else
            {
                MessageBox.Show("No se encontró el PDF.");
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNaus.SelectedItems.Count == 0) return;

            var selectedName = lvNaus.SelectedItems[0].Text;
            selectedOption = technicalInfo.InfoOptions.FirstOrDefault(o => o.textOption == selectedName);

            if (selectedOption == null) return;

            selectedDetail = technicalInfo.InfoDetails.FirstOrDefault(d => d.idInfoDetail == selectedOption.idOption);

            if (selectedDetail == null) return;

            // Mostrar imagen principal (Blueprint)
            string imgPath = Path.Combine(basePath, "images", selectedDetail.Blueprint);
            if (File.Exists(imgPath))
                pbPlanols.Image = Image.FromFile(imgPath);
            else
                pbPlanols.Image = null;

            // Mostrar detalles en el DataGridView
            dgvEspec.Rows.Clear();
            if (selectedDetail.Data != null)
            {
                dgvEspec.Rows.Add("Manufacturer", selectedDetail.Data.Manufacturer);
                dgvEspec.Rows.Add("Length", selectedDetail.Data.Length);
                dgvEspec.Rows.Add("Speed", selectedDetail.Data.Speed);
                dgvEspec.Rows.Add("Hyperdrive", selectedDetail.Data.Hyperdrive);
                dgvEspec.Rows.Add("Shielding", selectedDetail.Data.Shielding);
                dgvEspec.Rows.Add("Armament", selectedDetail.Data.Armament);
            }
            dgvEspec.ClearSelection();
        }

        private void Load_Data()
        {
            string xmlPath = Path.Combine(basePath, "Info.xml");
            technicalInfo = XmlManager<TechnicalInfo>.Load(xmlPath);

            // Configurar el ListView
            lvNaus.View = View.Details;  // Establecer la vista a "Detalles"
            lvNaus.Columns.Add("Ship Name", -2, HorizontalAlignment.Left);  // Añadir solo una columna para el nombre de la nave

            // Crear una lista de imágenes
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(32, 32);  // Tamaño de las imágenes

            // Añadir imágenes a la lista
            foreach (var option in technicalInfo.InfoOptions)
            {
                string iconPath = Path.Combine(basePath, "iconShips", option.icon);
                if (File.Exists(iconPath))
                {
                    imgList.Images.Add(option.textOption, Image.FromFile(iconPath));  // Usar la imagen de archivo
                }
                else
                {
                    imgList.Images.Add(option.textOption, SystemIcons.Question.ToBitmap());  // Usar icono por defecto si no existe el archivo
                }
            }

            lvNaus.LargeImageList = imgList;  // Asignar la lista de imágenes al ListView

            // Añadir ítems al ListView
            foreach (var option in technicalInfo.InfoOptions)
            {
                var item = new ListViewItem(option.textOption);
                item.ImageKey = option.textOption;  // Asegurarse de que el ImageKey coincide con el que tenemos en el ImageList
                lvNaus.Items.Add(item);  // Agregar el ítem al ListView
            }
        }
    }
}
