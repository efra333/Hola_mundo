using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _0001
{
    public partial class FormPreviewDialog : Form
    {
        public string SelectedImagePath;
        public DialogResult Result;
        private static FormPreviewDialog instance;
                
        public static FormPreviewDialog Dialog
        {
            get {
                if (instance == null || instance.IsDisposed)
                    instance = new FormPreviewDialog();

                instance.BringToFront();
                
                return instance; 
            }
            set { instance = value; }
        }//*/
        
        private FormPreviewDialog()
        {
            InitializeComponent();
            SelectedImagePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            LoadImages();
            LoadTreeNodes();
            TXT_STATUS.Text = SelectedImagePath;
            Result = DialogResult.None;
        }

        private void LoadDirectories(string dirPath, TreeNode parentNode)
        {
            string[] directories = Directory.GetDirectories(dirPath);

            for (int d = 0; d < directories.Length; d++)//-------------aca hay que arreglar el arbol de rutas de directorios
            {
                DirectoryInfo dirInfo;
                TreeNode node;
                try
                {
                    dirInfo  = new DirectoryInfo(directories[d]);
                    node     = new TreeNode(dirInfo.Name);
                    node.Tag = directories[d];  // Guarda la ruta completa del directorio en la propiedad Tag para usarla más tarde
                    
                    parentNode.Nodes.Add(directories[d]);

                    // Carga los subdirectorios
                    LoadDirectories(directories[d], node);
                }
                catch (Exception) { }
            }
        }

        private void LoadTreeNodes()//-------------aca hay que arreglar el arbol de rutas de directorios
        {
            treeViewDirectories.Nodes.Clear();
            var rootNode = new TreeNode(SelectedImagePath);
            rootNode.Tag = SelectedImagePath;
            treeViewDirectories.Nodes.Add(rootNode);

            LoadDirectories(SelectedImagePath, rootNode);
            rootNode.Expand();
        }

        private void LoadImages()
        {            
            string[] imageFiles = Directory.GetFiles(SelectedImagePath, "*.jpg"); // Ajusta esto según tus necesidades
            LST_IMAGES.Items.Clear();
            
            FileInfo inf;
            for (int i = 0; i < imageFiles.Length; i++)
            {
                inf = new FileInfo(imageFiles[i]);
                LST_IMAGES.Items.Add(new MyItem(inf.Name,inf.FullName));
            }
        }

        private void listBoxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LST_IMAGES.SelectedItem != null)
            {
                SelectedImagePath = ((MyItem)(LST_IMAGES.SelectedItem)).Tag;
                PCT_CANVAS.Image = Image.FromFile(SelectedImagePath);
            }
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Result = DialogResult.Cancel;
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (LST_IMAGES.SelectedItem != null)
            {
                SelectedImagePath = LST_IMAGES.SelectedItem.ToString();
                Result = DialogResult.OK;
                this.Hide();
            }
        }
        private void LST_IMAGES_DoubleClick(object sender, EventArgs e)
        {
            if (LST_IMAGES.SelectedItem != null)
            {
                SelectedImagePath = ((MyItem)(LST_IMAGES.SelectedItem)).Tag; 
                Result = DialogResult.OK;
                this.Hide();
            }
        }

        private void treeViewDirectories_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SelectedImagePath = e.Node.Tag.ToString();
        }

        private void BTN_UP_Click(object sender, EventArgs e)
        {
            // Crea un objeto DirectoryInfo para el directorio actual
            DirectoryInfo directoryInfo = new DirectoryInfo(SelectedImagePath);

            // Obtiene el directorio padre
            DirectoryInfo parentDirectory = directoryInfo.Parent;
            SelectedImagePath = parentDirectory.FullName;
            TXT_STATUS.Text = SelectedImagePath;
            LoadTreeNodes();
            LoadImages();
        }

        private void FormPreviewDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel        = true;
            this.Hide();
        }

        private void BTN_DESKTOP_Click(object sender, EventArgs e)
        {
            SelectedImagePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            TXT_STATUS.Text = SelectedImagePath;
            LoadImages();
            LoadTreeNodes();
        }

 


    }
}
