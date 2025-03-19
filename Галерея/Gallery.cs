using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Галерея
{
    public partial class Gallery: Form
    {
        private Dictionary<string, string> namesAndPaths;
        public Gallery()
        {
            InitializeComponent();
            namesAndPaths = new Dictionary<string, string>();

            lboxChooseImage.SelectedIndexChanged += this.lboxChooseImage_ChangeText;
            lboxChooseImage.SelectedIndexChanged += this.lboxChooseImage_LoadImage;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFD.ShowDialog() == DialogResult.Cancel)
                return;

            string fileName = saveFD.FileName;
            if (File.Exists(fileName))
            {
                File.WriteAllText(fileName, string.Empty);
            }
            foreach (var kv in namesAndPaths)
            {
                File.AppendAllText(fileName, $"{kv.Key}, {kv.Value}\n");
            }

            MessageBox.Show("Файл успешно сохранён");
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (openFD.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }            
            string[] paths = File.ReadAllLines(openFD.FileName);

            PathsToListBox(paths);

            ChangeVisibility();
        }

        /// <summary>
        /// Метод меняет свойство Visibility для ненужных на старте контролов
        /// </summary>
        private void ChangeVisibility()
        {
            btnSave.Visible = true;
            lblAllImages.Visible = true;
            lblCurrImageName.Visible = true;
            txtCurrImageName.Visible = true;
            lboxChooseImage.Visible = true;
        }

        /// <summary>
        /// Метод, записывающий пути к изображениям в словарь для дальнейшего отображения
        /// </summary>
        private void PathsToListBox(string[] paths)
        {
            namesAndPaths.Clear();
            foreach (string str in paths)
            {
                if (str.Contains(","))
                {
                    namesAndPaths[str.Split(',')[0]] = str.Split(',')[1];
                }
                else
                {
                    namesAndPaths[str] = null;
                }
            }
            foreach (var kv in namesAndPaths)
            {
                lboxChooseImage.Items.Add(kv.Key);
            }
        }
        private void lboxChooseImage_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Метод отображает в txtB (textBox) заголовок изображения
        /// </summary>
        private void lboxChooseImage_ChangeText(object sender, EventArgs e)
        {
            txtCurrImageName.Text = namesAndPaths[lboxChooseImage.SelectedItem.ToString()];
        }

        /// <summary>
        /// Метод загружает изображение в pBImage (PictureBox)
        /// </summary>
        private void lboxChooseImage_LoadImage(object sender, EventArgs e)
        {
            pBImage.Load(lboxChooseImage.SelectedItem.ToString());
        }
        private void txtCurrFileName_TextChanged(object sender, EventArgs e)
        {
            namesAndPaths[lboxChooseImage.SelectedItem.ToString()] = txtCurrImageName.Text;
        }
    }
}
