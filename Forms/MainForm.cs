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
        private List<string> imagePaths = new List<string>();


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
        private void showMediaSelectedImg (int index)
        {
            if ( index >= 0 && index < 4)
            {
                wmpView360.Visible = false;
                pbSelectedImg.Visible = true;

                string selectedImagePath = imagePaths[index];
                pbSelectedImg.Image = Image.FromFile(selectedImagePath);
            } else
            {
                wmpView360.Visible = true;
                wmpView360.uiMode = "none";
                pbSelectedImg.Visible = false;

                string videoPath = Path.Combine(basePath, "images/", selectedOption.textOption);
                videoPath = Directory.GetFiles(videoPath, "*.mp4")[0];
                wmpView360.URL = videoPath;
                wmpView360.stretchToFit = true;
            }

        }

        private void loadShipsImages()
        {
            string[] images = new string[]
            {
                selectedDetail.FrontView,
                selectedDetail.SideView,
                selectedDetail.TopView,
                selectedDetail.RearView,
                selectedDetail.View360
            };

            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(64, 64); // Tamaño más grande para que se vean bien

            lvShipsImages.Clear(); // Limpiar ítems anteriores
            lvShipsImages.View = View.LargeIcon;
            lvShipsImages.LargeImageList = imgList;
            
            imagePaths.Clear();


            int index = 0;
            foreach (var imgPath in images)
            {
                if (!string.IsNullOrEmpty(imgPath))
                {
                    string iconPath = Path.Combine(basePath, "images/", selectedOption.textOption, imgPath);
                    imagePaths.Add(iconPath);
                    if (File.Exists(iconPath))
                    {
                        imgList.Images.Add(Image.FromFile(iconPath));

                        // Agregar el ítem con índice correspondiente
                        ListViewItem item = new ListViewItem("", index);
                        lvShipsImages.Items.Add(item);
                        index++;
                    }
                }
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
            string imgPath = Path.Combine(basePath, "images/", selectedOption.textOption, selectedDetail.Blueprint);
            if (File.Exists(imgPath))
                pbPlanols.Image = Image.FromFile(imgPath);
            else
                pbPlanols.Image = null;

            lbShipName.Text = selectedDetail.title;
            txtDescription.Text = selectedDetail.textInfoDetail;

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
            loadShipsImages();
        }

        private void Load_Data()
        {
            string xmlPath = Path.Combine(basePath, "Info.xml");
            technicalInfo = XmlManager<TechnicalInfo>.Load(xmlPath);

            // Configurar el ListView
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

            lvNaus.View = View.List;
            lvNaus.SmallImageList = imgList; // 🔑 esta línea es necesaria
                                             // Asignar la lista de imágenes al ListView

            // Añadir ítems al ListView
            foreach (var option in technicalInfo.InfoOptions)
            {
                var item = new ListViewItem(option.textOption);
                item.ImageKey = option.textOption;  // Asegurarse de que el ImageKey coincide con el que tenemos en el ImageList
                lvNaus.Items.Add(item);  // Agregar el ítem al ListView
            }
        }

        private void lvShipsImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar si hay algún ítem seleccionado
            if (lvShipsImages.SelectedIndices.Count > 0)
            {
                // Obtener el índice del ítem seleccionado
                int selectedIndex = lvShipsImages.SelectedItems[0].ImageIndex;
                showMediaSelectedImg(selectedIndex);

            }
        }
    }
}
