namespace Галерея
{
    partial class Gallery
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lboxChooseImage = new System.Windows.Forms.ListBox();
            this.pBImage = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCurrImageName = new System.Windows.Forms.TextBox();
            this.lblCurrImageName = new System.Windows.Forms.Label();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.lblAllImages = new System.Windows.Forms.Label();
            this.tableLPLeftMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLPLeftBott = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pBImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lboxChooseImage
            // 
            this.lboxChooseImage.FormattingEnabled = true;
            this.lboxChooseImage.ItemHeight = 16;
            this.lboxChooseImage.Location = new System.Drawing.Point(25, 43);
            this.lboxChooseImage.Name = "lboxChooseImage";
            this.lboxChooseImage.Size = new System.Drawing.Size(360, 228);
            this.lboxChooseImage.TabIndex = 0;
            this.lboxChooseImage.Visible = false;
            this.lboxChooseImage.SelectedIndexChanged += new System.EventHandler(this.lboxChooseImage_SelectedIndexChanged);
            // 
            // pBImage
            // 
            this.pBImage.Location = new System.Drawing.Point(414, 24);
            this.pBImage.Name = "pBImage";
            this.pBImage.Size = new System.Drawing.Size(360, 400);
            this.pBImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBImage.TabIndex = 1;
            this.pBImage.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoad.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoad.Location = new System.Drawing.Point(25, 369);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(170, 55);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Выбрать .txt файл";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(215, 369);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(170, 55);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCurrImageName
            // 
            this.txtCurrImageName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCurrImageName.Location = new System.Drawing.Point(25, 295);
            this.txtCurrImageName.Multiline = true;
            this.txtCurrImageName.Name = "txtCurrImageName";
            this.txtCurrImageName.Size = new System.Drawing.Size(360, 22);
            this.txtCurrImageName.TabIndex = 4;
            this.txtCurrImageName.Visible = false;
            this.txtCurrImageName.TextChanged += new System.EventHandler(this.txtCurrFileName_TextChanged);
            // 
            // lblCurrImageName
            // 
            this.lblCurrImageName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCurrImageName.AutoSize = true;
            this.lblCurrImageName.Location = new System.Drawing.Point(22, 276);
            this.lblCurrImageName.Name = "lblCurrImageName";
            this.lblCurrImageName.Size = new System.Drawing.Size(139, 16);
            this.lblCurrImageName.TabIndex = 5;
            this.lblCurrImageName.Text = "Текущий заголовок:";
            this.lblCurrImageName.Visible = false;
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            this.openFD.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            // 
            // saveFD
            // 
            this.saveFD.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            // 
            // lblAllImages
            // 
            this.lblAllImages.AutoSize = true;
            this.lblAllImages.Location = new System.Drawing.Point(22, 24);
            this.lblAllImages.Name = "lblAllImages";
            this.lblAllImages.Size = new System.Drawing.Size(173, 16);
            this.lblAllImages.TabIndex = 6;
            this.lblAllImages.Text = "Доступные изображения:";
            this.lblAllImages.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAllImages);
            this.Controls.Add(this.lblCurrImageName);
            this.Controls.Add(this.txtCurrImageName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.pBImage);
            this.Controls.Add(this.lboxChooseImage);
            this.MaximizeBox = false;
            this.Name = "Галерея";
            this.Text = "Галерея";
            ((System.ComponentModel.ISupportInitialize)(this.pBImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxChooseImage;
        private System.Windows.Forms.PictureBox pBImage;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCurrImageName;
        private System.Windows.Forms.Label lblCurrImageName;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.SaveFileDialog saveFD;
        private System.Windows.Forms.Label lblAllImages;
        private System.Windows.Forms.TableLayoutPanel tableLPLeftMain;
        private System.Windows.Forms.TableLayoutPanel tableLPLeftBott;
    }
}

