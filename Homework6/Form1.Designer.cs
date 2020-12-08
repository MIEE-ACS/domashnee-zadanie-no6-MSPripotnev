namespace Homework6
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BodiesLV = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.addBodyButton = new System.Windows.Forms.Button();
            this.typeInfoLabel = new System.Windows.Forms.Label();
            this.RInfoLabel = new System.Windows.Forms.Label();
            this.radiusNUD = new System.Windows.Forms.NumericUpDown();
            this.hInfoLabel = new System.Windows.Forms.Label();
            this.VolumeTB = new System.Windows.Forms.TextBox();
            this.volumeInfoLabel = new System.Windows.Forms.Label();
            this.AreaTB = new System.Windows.Forms.TextBox();
            this.AreaInfoLabel = new System.Windows.Forms.Label();
            this.deleteBodyButton = new System.Windows.Forms.Button();
            this.typeCB = new System.Windows.Forms.ComboBox();
            this.hNUD = new System.Windows.Forms.NumericUpDown();
            this.VInfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radiusNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // BodiesLV
            // 
            this.BodiesLV.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.BodiesLV.Dock = System.Windows.Forms.DockStyle.Left;
            this.BodiesLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BodiesLV.HideSelection = false;
            this.BodiesLV.LabelWrap = false;
            this.BodiesLV.LargeImageList = this.imageList;
            this.BodiesLV.Location = new System.Drawing.Point(0, 0);
            this.BodiesLV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BodiesLV.MultiSelect = false;
            this.BodiesLV.Name = "BodiesLV";
            this.BodiesLV.Size = new System.Drawing.Size(349, 411);
            this.BodiesLV.TabIndex = 0;
            this.BodiesLV.TileSize = new System.Drawing.Size(128, 80);
            this.BodiesLV.UseCompatibleStateImageBehavior = false;
            this.BodiesLV.View = System.Windows.Forms.View.Tile;
            this.BodiesLV.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.EmployersLV_SelectedIndexChanged);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Cube.png");
            this.imageList.Images.SetKeyName(1, "Sphere.png");
            this.imageList.Images.SetKeyName(2, "Cone.png");
            // 
            // addBodyButton
            // 
            this.addBodyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBodyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addBodyButton.Location = new System.Drawing.Point(810, 10);
            this.addBodyButton.Margin = new System.Windows.Forms.Padding(0, 0, 6, 6);
            this.addBodyButton.Name = "addBodyButton";
            this.addBodyButton.Size = new System.Drawing.Size(158, 118);
            this.addBodyButton.TabIndex = 2;
            this.addBodyButton.Text = "Добавить фигуру";
            this.addBodyButton.UseVisualStyleBackColor = true;
            this.addBodyButton.Click += new System.EventHandler(this.addFigureButton_Click);
            // 
            // typeInfoLabel
            // 
            this.typeInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typeInfoLabel.AutoSize = true;
            this.typeInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typeInfoLabel.Location = new System.Drawing.Point(353, 13);
            this.typeInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typeInfoLabel.Name = "typeInfoLabel";
            this.typeInfoLabel.Size = new System.Drawing.Size(184, 33);
            this.typeInfoLabel.TabIndex = 4;
            this.typeInfoLabel.Text = "Тип фигуры:";
            // 
            // RInfoLabel
            // 
            this.RInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RInfoLabel.AutoSize = true;
            this.RInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RInfoLabel.Location = new System.Drawing.Point(353, 63);
            this.RInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RInfoLabel.Name = "RInfoLabel";
            this.RInfoLabel.Size = new System.Drawing.Size(121, 33);
            this.RInfoLabel.TabIndex = 6;
            this.RInfoLabel.Text = "Радиус:";
            this.RInfoLabel.Visible = false;
            // 
            // radiusNUD
            // 
            this.radiusNUD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radiusNUD.DecimalPlaces = 4;
            this.radiusNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radiusNUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.radiusNUD.Location = new System.Drawing.Point(544, 62);
            this.radiusNUD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radiusNUD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.radiusNUD.Name = "radiusNUD";
            this.radiusNUD.Size = new System.Drawing.Size(230, 38);
            this.radiusNUD.TabIndex = 5;
            this.radiusNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.radiusNUD.ThousandsSeparator = true;
            this.radiusNUD.Visible = false;
            this.radiusNUD.ValueChanged += new System.EventHandler(this.NUD_ValueChanged);
            // 
            // hInfoLabel
            // 
            this.hInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hInfoLabel.AutoSize = true;
            this.hInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hInfoLabel.Location = new System.Drawing.Point(353, 117);
            this.hInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hInfoLabel.Name = "hInfoLabel";
            this.hInfoLabel.Size = new System.Drawing.Size(123, 33);
            this.hInfoLabel.TabIndex = 7;
            this.hInfoLabel.Text = "Высота:";
            this.hInfoLabel.Visible = false;
            // 
            // VolumeTB
            // 
            this.VolumeTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VolumeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VolumeTB.Location = new System.Drawing.Point(544, 216);
            this.VolumeTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.VolumeTB.Name = "VolumeTB";
            this.VolumeTB.ReadOnly = true;
            this.VolumeTB.Size = new System.Drawing.Size(230, 38);
            this.VolumeTB.TabIndex = 10;
            this.VolumeTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // volumeInfoLabel
            // 
            this.volumeInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeInfoLabel.AutoSize = true;
            this.volumeInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.volumeInfoLabel.Location = new System.Drawing.Point(353, 218);
            this.volumeInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.volumeInfoLabel.Name = "volumeInfoLabel";
            this.volumeInfoLabel.Size = new System.Drawing.Size(118, 33);
            this.volumeInfoLabel.TabIndex = 9;
            this.volumeInfoLabel.Text = "Объём:";
            // 
            // AreaTB
            // 
            this.AreaTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AreaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AreaTB.Location = new System.Drawing.Point(544, 165);
            this.AreaTB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AreaTB.Name = "AreaTB";
            this.AreaTB.ReadOnly = true;
            this.AreaTB.Size = new System.Drawing.Size(230, 38);
            this.AreaTB.TabIndex = 12;
            this.AreaTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AreaInfoLabel
            // 
            this.AreaInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AreaInfoLabel.AutoSize = true;
            this.AreaInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AreaInfoLabel.Location = new System.Drawing.Point(353, 167);
            this.AreaInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AreaInfoLabel.Name = "AreaInfoLabel";
            this.AreaInfoLabel.Size = new System.Drawing.Size(149, 33);
            this.AreaInfoLabel.TabIndex = 11;
            this.AreaInfoLabel.Text = "Площадь:";
            // 
            // deleteBodyButton
            // 
            this.deleteBodyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBodyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteBodyButton.Location = new System.Drawing.Point(810, 134);
            this.deleteBodyButton.Margin = new System.Windows.Forms.Padding(0, 0, 6, 6);
            this.deleteBodyButton.Name = "deleteBodyButton";
            this.deleteBodyButton.Size = new System.Drawing.Size(158, 120);
            this.deleteBodyButton.TabIndex = 13;
            this.deleteBodyButton.Text = "Убрать фигуру";
            this.deleteBodyButton.UseVisualStyleBackColor = true;
            this.deleteBodyButton.Click += new System.EventHandler(this.DeleteEmployeeButton_Click);
            // 
            // typeCB
            // 
            this.typeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typeCB.FormattingEnabled = true;
            this.typeCB.Items.AddRange(new object[] {
            "Cube",
            "Sphere",
            "Cone"});
            this.typeCB.Location = new System.Drawing.Point(544, 13);
            this.typeCB.MaxDropDownItems = 3;
            this.typeCB.Name = "typeCB";
            this.typeCB.Size = new System.Drawing.Size(233, 38);
            this.typeCB.TabIndex = 16;
            this.typeCB.SelectedIndexChanged += new System.EventHandler(this.typeCB_SelectedIndexChanged);
            // 
            // hNUD
            // 
            this.hNUD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hNUD.DecimalPlaces = 4;
            this.hNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hNUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.hNUD.Location = new System.Drawing.Point(544, 112);
            this.hNUD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hNUD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.hNUD.Name = "hNUD";
            this.hNUD.Size = new System.Drawing.Size(230, 38);
            this.hNUD.TabIndex = 17;
            this.hNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hNUD.ThousandsSeparator = true;
            this.hNUD.Visible = false;
            this.hNUD.ValueChanged += new System.EventHandler(this.NUD_ValueChanged);
            // 
            // VInfoLabel
            // 
            this.VInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VInfoLabel.AutoSize = true;
            this.VInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VInfoLabel.Location = new System.Drawing.Point(327, 218);
            this.VInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VInfoLabel.Name = "VInfoLabel";
            this.VInfoLabel.Size = new System.Drawing.Size(118, 33);
            this.VInfoLabel.TabIndex = 9;
            this.VInfoLabel.Text = "Объём:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 411);
            this.Controls.Add(this.hNUD);
            this.Controls.Add(this.typeCB);
            this.Controls.Add(this.deleteBodyButton);
            this.Controls.Add(this.AreaTB);
            this.Controls.Add(this.AreaInfoLabel);
            this.Controls.Add(this.VolumeTB);
            this.Controls.Add(this.volumeInfoLabel);
            this.Controls.Add(this.hInfoLabel);
            this.Controls.Add(this.RInfoLabel);
            this.Controls.Add(this.radiusNUD);
            this.Controls.Add(this.typeInfoLabel);
            this.Controls.Add(this.addBodyButton);
            this.Controls.Add(this.BodiesLV);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Припотнев М.С., УТС-22, вариант 1";
            ((System.ComponentModel.ISupportInitialize)(this.radiusNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView BodiesLV;
        private System.Windows.Forms.Button addBodyButton;
        private System.Windows.Forms.Label typeInfoLabel;
        private System.Windows.Forms.Label RInfoLabel;
        private System.Windows.Forms.NumericUpDown radiusNUD;
        private System.Windows.Forms.Label hInfoLabel;
        private System.Windows.Forms.TextBox VolumeTB;
        private System.Windows.Forms.Label volumeInfoLabel;
        private System.Windows.Forms.TextBox AreaTB;
        private System.Windows.Forms.Label AreaInfoLabel;
        private System.Windows.Forms.Button deleteBodyButton;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ComboBox typeCB;
        private System.Windows.Forms.NumericUpDown hNUD;
        private System.Windows.Forms.Label VInfoLabel;
    }
}

