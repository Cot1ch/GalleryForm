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
            File.WriteAllText(fileName, string.Empty);

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
            bool ifRepeat = false;
            namesAndPaths.Clear();
            foreach (string str in paths)
            {
                
                if (str.Contains(","))
                {
                    if (!File.Exists(str.Split(',')[0]))
                    {
                        MessageBox.Show($"Файл {str.Split(',')[0]} не найден");
                    }
                    if (namesAndPaths.ContainsKey(str.Split(',')[0]))
                    {
                        ifRepeat = true;
                    }
                    
                    namesAndPaths[str.Split(',')[0]] = str.Split(',')[1];
                }
                else
                {
                    if (!File.Exists(str))
                    {
                        MessageBox.Show($"Файл {str} не найден");
                    }
                    if (namesAndPaths.ContainsKey(str))
                    {
                        ifRepeat = true;
                    }

                    namesAndPaths[str] = null;
                }
            }
            foreach (var kv in namesAndPaths)
            {
                lboxChooseImage.Items.Add(kv.Key);
            }
            if (ifRepeat)
            {
                MessageBox.Show("!!! Проверьте файл !!!\n" +
                    "Некоторые изображения встречаются несколько раз!\n" +
                    "Отображаются только последние вхождения");
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

        private void ChangeDefaultPaths(object sender, EventArgs e)
        {
            string path = $"{Directory.GetCurrentDirectory()}\\..\\..\\..\\images\\Images.txt";
            if (!File.Exists(path))
            {
                MessageBox.Show("!! Файл по умолчанию не найден (возможно, удалён или переименован) !!", "! Ошибка !", icon: MessageBoxIcon.Error, buttons: MessageBoxButtons.OK, defaultButton: MessageBoxDefaultButton.Button1);
                return;
            }
            string[] images = File.ReadAllLines(path);
            for (int i = 0; i < images.Length; i++)
            {
                images[i] = $"{Directory.GetCurrentDirectory()}\\..\\..\\..\\..images.{images[i].Substring(images[i].LastIndexOf('\\') + 1)}";
            }
            MessageBox.Show("Файл успешно перезаписан");
        }

        
    }
}
