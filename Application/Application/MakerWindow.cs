/*
    TODO: Make the title and description save feature actaully work. 
    When release add verification
*/

using Newtonsoft.Json;
using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using TextureLoader.Models;

namespace App
{
    public partial class MakerWindow : Form
    {
        public MakerWindow()
        {
            InitializeComponent();
            LoadPresets();

            savebtn.Click += Savebtn_Click;
            pictureBox1.Click += PictureBox1_Click; // ground
            forestatlaspriview.Click += Forestatlaspriview_Click;
            pictureBox2.Click += PictureBox2_Click;
            pictureBox3.Click += PictureBox3_Click;
            pictureBox4.Click += Leaf_Click;

            compilebtn.Click += Compilebtn_Click;
        }

        private void Leaf_Click(object sender, EventArgs e)
        {
            string path = GetFile();
            if (path != null)
            {
                pictureBox4.ImageLocation = path;
                GetProject.Leaf = path;
            }
        }

        private void Compilebtn_Click(object sender, EventArgs e)
        {
            SaveProject(false);

            string TEMPDirectory = Directory.GetCurrentDirectory() + "/TEMP";
            if (Directory.Exists(TEMPDirectory))
                Directory.Delete(TEMPDirectory, true);
            Directory.CreateDirectory(TEMPDirectory);

            string path = GetDirectory();

            Package package = new Package(GetProject.Name, GetProject.Description, false);
            string json = JsonConvert.SerializeObject(package);
            File.WriteAllText(TEMPDirectory + "/package.json", json);
            File.Copy(GetProject.Ground, TEMPDirectory + "/ground.png");
            File.Copy(GetProject.MainAtlas, TEMPDirectory + "/atlas.png");
            File.Copy(GetProject.StumpAtlas, TEMPDirectory + "/treestump.png");
            File.Copy(GetProject.StumpRoom, TEMPDirectory + "/treestumproom.png");
            if (useleaf.Checked)
                File.Copy(GetProject.Leaf, TEMPDirectory + "/leaf.png");

            string ZIPPath = path + GetProject.Name + ".texture";
            if (File.Exists(ZIPPath))
                File.Delete(ZIPPath);

            ZipFile.CreateFromDirectory(TEMPDirectory, ZIPPath);
            Directory.Delete(TEMPDirectory, true);

            MessageBox.Show("Compile", "Successfully compiled your currently project data.", MessageBoxButtons.OK);
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            string path = GetFile();
            if (path != null)
            {
                pictureBox3.ImageLocation = path;
                GetProject.StumpRoom = path;
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            string path = GetFile();
            if (path != null)
            {
                pictureBox2.ImageLocation = path;
                GetProject.StumpAtlas = path;
            }
        }

        private void Forestatlaspriview_Click(object sender, EventArgs e)
        {
            string path = GetFile();
            if (path != null)
            {
                forestatlaspriview.ImageLocation = path;
                GetProject.MainAtlas = path;
            }
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            SaveProject(true);
        }

        // Ground
        private void PictureBox1_Click(object sender, System.EventArgs e)
        {
            string path = GetFile();
            if (path != null)
            {
                pictureBox1.ImageLocation = path;
                GetProject.Ground = path;
            }
        }

        // Util
        private void LoadPresets()
        {
            MakerProject makerProject = GetProject;
            pictureBox1.ImageLocation = makerProject.Ground;
            pictureBox2.ImageLocation = makerProject.StumpAtlas;
            forestatlaspriview.ImageLocation = makerProject.MainAtlas;

            title.Text = makerProject.Name;
            description.Text = makerProject.Description;
        }

        private MakerProject _project;
        private MakerProject GetProject
        {
            get
            {
                if (_project == null)
                {
                    string path = Directory.GetCurrentDirectory() + "/project.json";
                    if (!File.Exists(path))
                        File.WriteAllText(path, JsonConvert.SerializeObject(new MakerProject()));
                    _project = JsonConvert.DeserializeObject<MakerProject>(File.ReadAllText(path));
                }
                return _project;
            }
            set
            {
                _project = value;
            }
        }
        private void SaveProject(bool ShowMessageBox = false)
        {
            string Json = JsonConvert.SerializeObject(GetProject);
            string path = Directory.GetCurrentDirectory() + "/project.json";

            GetProject.Name = title.Text;
            GetProject.Description = description.Text;

            File.WriteAllText(path, Json);
            if (ShowMessageBox)
                MessageBox.Show("Save Project", "Successfully saved your currently project data.", MessageBoxButtons.OK);
        }

        private string GetDirectory()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = Directory.GetCurrentDirectory();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                return folderBrowserDialog.SelectedPath + "/";
            }
            return null;
        }
        private string GetFile(string path = "")
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = path == "" ? Directory.GetCurrentDirectory() : path;
            openFileDialog.Filter = "Image Files (*.png)|*.png";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.CheckFileExists = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            return null;
        }

        private void isverfiedbtn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

    [Serializable]
    public class MakerProject
    {
        public string Name;
        public string Description;

        public string Ground;
        public string MainAtlas;
        public string StumpAtlas;
        public string StumpRoom;
        public string Leaf;

        public MakerProject()
        {
            Name = "My Title";
            Description = "My description";
            Ground = "";
            MainAtlas = "";
            StumpAtlas = "";
            StumpRoom = "";
            Leaf = "";
        }
    }
}
