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
            if (listView.SelectedItems.Count == 0) return;

            var selectedName = listView.SelectedItems[0].Text;
            selectedOption = technicalInfo.InfoOptions.FirstOrDefault(o => o.textOption == selectedName);

            if (selectedOption == null) return;

            selectedDetail = technicalInfo.InfoDetails.FirstOrDefault(d => d.idInfoDetail == selectedOption.idOption);

            if (selectedDetail == null) return;

            // Mostrar imagen principal (Blueprint)
            string imgPath = Path.Combine(basePath, "images", selectedDetail.Blueprint);
            if (File.Exists(imgPath))
                pictureBox1.Image = Image.FromFile(imgPath);
            else
                pictureBox1.Image = null;

            // Mostrar detalles en el DataGridView
            dataGridView1.Rows.Clear();
            if (selectedDetail.Data != null)
            {
                dataGridView1.Rows.Add("Manufacturer", selectedDetail.Data.Manufacturer);
                dataGridView1.Rows.Add("Length", selectedDetail.Data.Length);
                dataGridView1.Rows.Add("Speed", selectedDetail.Data.Speed);
                dataGridView1.Rows.Add("Hyperdrive", selectedDetail.Data.Hyperdrive);
                dataGridView1.Rows.Add("Shielding", selectedDetail.Data.Shielding);
                dataGridView1.Rows.Add("Armament", selectedDetail.Data.Armament);
            }
            dataGridView1.ClearSelection();
        }

        private void Load_Data()
        {
            string xmlPath = Path.Combine(basePath, "Info.xml");
            technicalInfo = XmlManager<TechnicalInfo>.Load(xmlPath);

            // Configurar el ListView
            listView.View = View.Details;  // Establecer la vista a "Detalles"
            listView.Columns.Add("Ship Name", -2, HorizontalAlignment.Left);  // Añadir solo una columna para el nombre de la nave

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

            listView.LargeImageList = imgList;  // Asignar la lista de imágenes al ListView

            // Añadir ítems al ListView
            foreach (var option in technicalInfo.InfoOptions)
            {
                var item = new ListViewItem(option.textOption);
                item.ImageKey = option.textOption;  // Asegurarse de que el ImageKey coincide con el que tenemos en el ImageList
                listView.Items.Add(item);  // Agregar el ítem al ListView
            }
        }
    }
}
