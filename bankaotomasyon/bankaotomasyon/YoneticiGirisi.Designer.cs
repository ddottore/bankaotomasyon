namespace bankaotomasyon
{
    partial class YoneticiGirisi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_yoneticiadsoyad = new System.Windows.Forms.Label();
            this.lblHosgeldinYonetici = new System.Windows.Forms.Label();
            this.btnMusteriSil = new System.Windows.Forms.Button();
            this.btnMusteriKaydiOlustur = new System.Windows.Forms.Button();
            this.btnIslemGecmisi = new System.Windows.Forms.Button();
            this.gridmusteriler = new System.Windows.Forms.DataGridView();
            this.pb_resim = new System.Windows.Forms.PictureBox();
            this.bankaotomasyonDataSet11 = new bankaotomasyon.bankaotomasyonDataSet1();
            this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musteriTableAdapter1 = new bankaotomasyon.bankaotomasyonDataSet1TableAdapters.musteriTableAdapter();
            this.musteriibanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mbakiyeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mpuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridmusteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaotomasyonDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_yoneticiadsoyad
            // 
            this.lbl_yoneticiadsoyad.AutoSize = true;
            this.lbl_yoneticiadsoyad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_yoneticiadsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yoneticiadsoyad.Location = new System.Drawing.Point(81, 57);
            this.lbl_yoneticiadsoyad.Name = "lbl_yoneticiadsoyad";
            this.lbl_yoneticiadsoyad.Size = new System.Drawing.Size(0, 29);
            this.lbl_yoneticiadsoyad.TabIndex = 14;
            // 
            // lblHosgeldinYonetici
            // 
            this.lblHosgeldinYonetici.AutoSize = true;
            this.lblHosgeldinYonetici.BackColor = System.Drawing.Color.Transparent;
            this.lblHosgeldinYonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHosgeldinYonetici.Location = new System.Drawing.Point(39, 21);
            this.lblHosgeldinYonetici.Name = "lblHosgeldinYonetici";
            this.lblHosgeldinYonetici.Size = new System.Drawing.Size(0, 25);
            this.lblHosgeldinYonetici.TabIndex = 13;
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.Location = new System.Drawing.Point(908, 370);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(142, 52);
            this.btnMusteriSil.TabIndex = 15;
            this.btnMusteriSil.UseVisualStyleBackColor = true;
            this.btnMusteriSil.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMusteriKaydiOlustur
            // 
            this.btnMusteriKaydiOlustur.Location = new System.Drawing.Point(718, 370);
            this.btnMusteriKaydiOlustur.Name = "btnMusteriKaydiOlustur";
            this.btnMusteriKaydiOlustur.Size = new System.Drawing.Size(142, 52);
            this.btnMusteriKaydiOlustur.TabIndex = 17;
            this.btnMusteriKaydiOlustur.UseVisualStyleBackColor = true;
            this.btnMusteriKaydiOlustur.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnIslemGecmisi
            // 
            this.btnIslemGecmisi.Location = new System.Drawing.Point(907, 22);
            this.btnIslemGecmisi.Name = "btnIslemGecmisi";
            this.btnIslemGecmisi.Size = new System.Drawing.Size(143, 52);
            this.btnIslemGecmisi.TabIndex = 18;
            this.btnIslemGecmisi.UseVisualStyleBackColor = true;
            this.btnIslemGecmisi.Click += new System.EventHandler(this.button3_Click);
            // 
            // gridmusteriler
            // 
            this.gridmusteriler.AllowUserToAddRows = false;
            this.gridmusteriler.AllowUserToDeleteRows = false;
            this.gridmusteriler.AutoGenerateColumns = false;
            this.gridmusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridmusteriler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriibanDataGridViewTextBoxColumn,
            this.kullaniciAdiDataGridViewTextBoxColumn,
            this.kullaniciSifreDataGridViewTextBoxColumn,
            this.refKoduDataGridViewTextBoxColumn,
            this.madDataGridViewTextBoxColumn,
            this.msoyadDataGridViewTextBoxColumn,
            this.myasDataGridViewTextBoxColumn,
            this.mtcDataGridViewTextBoxColumn,
            this.mbakiyeDataGridViewTextBoxColumn,
            this.mpuanDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.gridmusteriler.DataSource = this.musteriBindingSource;
            this.gridmusteriler.Location = new System.Drawing.Point(10, 94);
            this.gridmusteriler.Name = "gridmusteriler";
            this.gridmusteriler.ReadOnly = true;
            this.gridmusteriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridmusteriler.Size = new System.Drawing.Size(1043, 243);
            this.gridmusteriler.TabIndex = 19;
            // 
            // pb_resim
            // 
            this.pb_resim.BackColor = System.Drawing.Color.Transparent;
            this.pb_resim.Image = global::bankaotomasyon.Properties.Resources.icons8_great_britain_96;
            this.pb_resim.Location = new System.Drawing.Point(25, 370);
            this.pb_resim.Name = "pb_resim";
            this.pb_resim.Size = new System.Drawing.Size(39, 35);
            this.pb_resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_resim.TabIndex = 20;
            this.pb_resim.TabStop = false;
            this.pb_resim.Click += new System.EventHandler(this.pb_resim_Click);
            // 
            // bankaotomasyonDataSet11
            // 
            this.bankaotomasyonDataSet11.DataSetName = "bankaotomasyonDataSet1";
            this.bankaotomasyonDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteriBindingSource
            // 
            this.musteriBindingSource.DataMember = "musteri";
            this.musteriBindingSource.DataSource = this.bankaotomasyonDataSet11;
            // 
            // musteriTableAdapter1
            // 
            this.musteriTableAdapter1.ClearBeforeFill = true;
            // 
            // musteriibanDataGridViewTextBoxColumn
            // 
            this.musteriibanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.musteriibanDataGridViewTextBoxColumn.DataPropertyName = "musteri_iban";
            this.musteriibanDataGridViewTextBoxColumn.HeaderText = "musteri_iban";
            this.musteriibanDataGridViewTextBoxColumn.Name = "musteriibanDataGridViewTextBoxColumn";
            this.musteriibanDataGridViewTextBoxColumn.ReadOnly = true;
            this.musteriibanDataGridViewTextBoxColumn.Width = 91;
            // 
            // kullaniciAdiDataGridViewTextBoxColumn
            // 
            this.kullaniciAdiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kullaniciAdiDataGridViewTextBoxColumn.DataPropertyName = "kullaniciAdi";
            this.kullaniciAdiDataGridViewTextBoxColumn.HeaderText = "kullaniciAdi";
            this.kullaniciAdiDataGridViewTextBoxColumn.Name = "kullaniciAdiDataGridViewTextBoxColumn";
            this.kullaniciAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kullaniciSifreDataGridViewTextBoxColumn
            // 
            this.kullaniciSifreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kullaniciSifreDataGridViewTextBoxColumn.DataPropertyName = "kullaniciSifre";
            this.kullaniciSifreDataGridViewTextBoxColumn.HeaderText = "kullaniciSifre";
            this.kullaniciSifreDataGridViewTextBoxColumn.Name = "kullaniciSifreDataGridViewTextBoxColumn";
            this.kullaniciSifreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // refKoduDataGridViewTextBoxColumn
            // 
            this.refKoduDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.refKoduDataGridViewTextBoxColumn.DataPropertyName = "refKodu";
            this.refKoduDataGridViewTextBoxColumn.HeaderText = "refKodu";
            this.refKoduDataGridViewTextBoxColumn.Name = "refKoduDataGridViewTextBoxColumn";
            this.refKoduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // madDataGridViewTextBoxColumn
            // 
            this.madDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.madDataGridViewTextBoxColumn.DataPropertyName = "m_ad";
            this.madDataGridViewTextBoxColumn.HeaderText = "m_ad";
            this.madDataGridViewTextBoxColumn.Name = "madDataGridViewTextBoxColumn";
            this.madDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // msoyadDataGridViewTextBoxColumn
            // 
            this.msoyadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.msoyadDataGridViewTextBoxColumn.DataPropertyName = "m_soyad";
            this.msoyadDataGridViewTextBoxColumn.HeaderText = "m_soyad";
            this.msoyadDataGridViewTextBoxColumn.Name = "msoyadDataGridViewTextBoxColumn";
            this.msoyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // myasDataGridViewTextBoxColumn
            // 
            this.myasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.myasDataGridViewTextBoxColumn.DataPropertyName = "m_yas";
            this.myasDataGridViewTextBoxColumn.HeaderText = "m_yas";
            this.myasDataGridViewTextBoxColumn.Name = "myasDataGridViewTextBoxColumn";
            this.myasDataGridViewTextBoxColumn.ReadOnly = true;
            this.myasDataGridViewTextBoxColumn.Width = 62;
            // 
            // mtcDataGridViewTextBoxColumn
            // 
            this.mtcDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mtcDataGridViewTextBoxColumn.DataPropertyName = "m_tc";
            this.mtcDataGridViewTextBoxColumn.HeaderText = "m_tc";
            this.mtcDataGridViewTextBoxColumn.Name = "mtcDataGridViewTextBoxColumn";
            this.mtcDataGridViewTextBoxColumn.ReadOnly = true;
            this.mtcDataGridViewTextBoxColumn.Width = 55;
            // 
            // mbakiyeDataGridViewTextBoxColumn
            // 
            this.mbakiyeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mbakiyeDataGridViewTextBoxColumn.DataPropertyName = "m_bakiye";
            this.mbakiyeDataGridViewTextBoxColumn.HeaderText = "m_bakiye";
            this.mbakiyeDataGridViewTextBoxColumn.Name = "mbakiyeDataGridViewTextBoxColumn";
            this.mbakiyeDataGridViewTextBoxColumn.ReadOnly = true;
            this.mbakiyeDataGridViewTextBoxColumn.Width = 77;
            // 
            // mpuanDataGridViewTextBoxColumn
            // 
            this.mpuanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mpuanDataGridViewTextBoxColumn.DataPropertyName = "m_puan";
            this.mpuanDataGridViewTextBoxColumn.HeaderText = "m_puan";
            this.mpuanDataGridViewTextBoxColumn.Name = "mpuanDataGridViewTextBoxColumn";
            this.mpuanDataGridViewTextBoxColumn.ReadOnly = true;
            this.mpuanDataGridViewTextBoxColumn.Width = 70;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-Mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // YoneticiGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bankaotomasyon.Properties.Resources._5630974;
            this.ClientSize = new System.Drawing.Size(1062, 431);
            this.Controls.Add(this.pb_resim);
            this.Controls.Add(this.gridmusteriler);
            this.Controls.Add(this.btnIslemGecmisi);
            this.Controls.Add(this.btnMusteriKaydiOlustur);
            this.Controls.Add(this.btnMusteriSil);
            this.Controls.Add(this.lbl_yoneticiadsoyad);
            this.Controls.Add(this.lblHosgeldinYonetici);
            this.Name = "YoneticiGirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YoneticiGirisi_FormClosing);
            this.Load += new System.EventHandler(this.YoneticiGirisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridmusteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaotomasyonDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_yoneticiadsoyad;
        private System.Windows.Forms.Label lblHosgeldinYonetici;
        private System.Windows.Forms.Button btnMusteriSil;
        private bankaotomasyonDataSet1 bankaotomasyonDataSet1;
        private bankaotomasyonDataSet1TableAdapters.musteriTableAdapter musteriTableAdapter;
        private System.Windows.Forms.Button btnMusteriKaydiOlustur;
        private System.Windows.Forms.Button btnIslemGecmisi;
        private System.Windows.Forms.DataGridView gridmusteriler;
        private System.Windows.Forms.PictureBox pb_resim;
        private bankaotomasyonDataSet1 bankaotomasyonDataSet11;
        private System.Windows.Forms.BindingSource musteriBindingSource;
        private bankaotomasyonDataSet1TableAdapters.musteriTableAdapter musteriTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriibanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciSifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn refKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn madDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn msoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn myasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mtcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mbakiyeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mpuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}