namespace bankaotomasyon
{
    partial class ParaTransferi
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
            this.lblTransferYapilacakKisi = new System.Windows.Forms.Label();
            this.lblTransferYapilacakMiktar = new System.Windows.Forms.Label();
            this.txtTransferYapilacakTutar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gridmusteriler = new System.Windows.Forms.DataGridView();
            this.musteriibanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankaotomasyonDataSet1 = new bankaotomasyon.bankaotomasyonDataSet1();
            this.bankaotomasyonDataSet = new bankaotomasyon.bankaotomasyonDataSet();
            this.bankaotomasyonDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musteriTableAdapter = new bankaotomasyon.bankaotomasyonDataSet1TableAdapters.musteriTableAdapter();
            this.pb_resim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridmusteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaotomasyonDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaotomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaotomasyonDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTransferYapilacakKisi
            // 
            this.lblTransferYapilacakKisi.AutoSize = true;
            this.lblTransferYapilacakKisi.BackColor = System.Drawing.Color.Transparent;
            this.lblTransferYapilacakKisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTransferYapilacakKisi.Location = new System.Drawing.Point(125, 9);
            this.lblTransferYapilacakKisi.Name = "lblTransferYapilacakKisi";
            this.lblTransferYapilacakKisi.Size = new System.Drawing.Size(158, 18);
            this.lblTransferYapilacakKisi.TabIndex = 0;
            this.lblTransferYapilacakKisi.Text = "Transfer Yapılacak Kişi";
            // 
            // lblTransferYapilacakMiktar
            // 
            this.lblTransferYapilacakMiktar.AutoSize = true;
            this.lblTransferYapilacakMiktar.BackColor = System.Drawing.Color.Transparent;
            this.lblTransferYapilacakMiktar.Location = new System.Drawing.Point(12, 290);
            this.lblTransferYapilacakMiktar.Name = "lblTransferYapilacakMiktar";
            this.lblTransferYapilacakMiktar.Size = new System.Drawing.Size(128, 13);
            this.lblTransferYapilacakMiktar.TabIndex = 1;
            this.lblTransferYapilacakMiktar.Text = "Transfer Yapılacak Miktar";
            // 
            // txtTransferYapilacakTutar
            // 
            this.txtTransferYapilacakTutar.Location = new System.Drawing.Point(146, 287);
            this.txtTransferYapilacakTutar.Name = "txtTransferYapilacakTutar";
            this.txtTransferYapilacakTutar.Size = new System.Drawing.Size(140, 20);
            this.txtTransferYapilacakTutar.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Transfer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridmusteriler
            // 
            this.gridmusteriler.AllowUserToAddRows = false;
            this.gridmusteriler.AllowUserToDeleteRows = false;
            this.gridmusteriler.AutoGenerateColumns = false;
            this.gridmusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridmusteriler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriibanDataGridViewTextBoxColumn,
            this.madDataGridViewTextBoxColumn,
            this.msoyadDataGridViewTextBoxColumn});
            this.gridmusteriler.DataSource = this.musteriBindingSource;
            this.gridmusteriler.Location = new System.Drawing.Point(12, 43);
            this.gridmusteriler.Name = "gridmusteriler";
            this.gridmusteriler.ReadOnly = true;
            this.gridmusteriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridmusteriler.Size = new System.Drawing.Size(371, 209);
            this.gridmusteriler.TabIndex = 5;
            this.gridmusteriler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridmusteriler_CellContentClick);
            // 
            // musteriibanDataGridViewTextBoxColumn
            // 
            this.musteriibanDataGridViewTextBoxColumn.DataPropertyName = "musteri_iban";
            this.musteriibanDataGridViewTextBoxColumn.HeaderText = "musteri_iban";
            this.musteriibanDataGridViewTextBoxColumn.Name = "musteriibanDataGridViewTextBoxColumn";
            this.musteriibanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // madDataGridViewTextBoxColumn
            // 
            this.madDataGridViewTextBoxColumn.DataPropertyName = "m_ad";
            this.madDataGridViewTextBoxColumn.HeaderText = "m_ad";
            this.madDataGridViewTextBoxColumn.Name = "madDataGridViewTextBoxColumn";
            this.madDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // msoyadDataGridViewTextBoxColumn
            // 
            this.msoyadDataGridViewTextBoxColumn.DataPropertyName = "m_soyad";
            this.msoyadDataGridViewTextBoxColumn.HeaderText = "m_soyad";
            this.msoyadDataGridViewTextBoxColumn.Name = "msoyadDataGridViewTextBoxColumn";
            this.msoyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // musteriBindingSource
            // 
            this.musteriBindingSource.DataMember = "musteri";
            this.musteriBindingSource.DataSource = this.bankaotomasyonDataSet1;
            // 
            // bankaotomasyonDataSet1
            // 
            this.bankaotomasyonDataSet1.DataSetName = "bankaotomasyonDataSet1";
            this.bankaotomasyonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankaotomasyonDataSet
            // 
            this.bankaotomasyonDataSet.DataSetName = "bankaotomasyonDataSet";
            this.bankaotomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankaotomasyonDataSetBindingSource
            // 
            this.bankaotomasyonDataSetBindingSource.DataSource = this.bankaotomasyonDataSet;
            this.bankaotomasyonDataSetBindingSource.Position = 0;
            // 
            // musteriTableAdapter
            // 
            this.musteriTableAdapter.ClearBeforeFill = true;
            // 
            // pb_resim
            // 
            this.pb_resim.BackColor = System.Drawing.Color.Transparent;
            this.pb_resim.Image = global::bankaotomasyon.Properties.Resources.icons8_great_britain_96;
            this.pb_resim.Location = new System.Drawing.Point(344, 2);
            this.pb_resim.Name = "pb_resim";
            this.pb_resim.Size = new System.Drawing.Size(39, 35);
            this.pb_resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_resim.TabIndex = 20;
            this.pb_resim.TabStop = false;
            this.pb_resim.Click += new System.EventHandler(this.pb_resim_Click);
            // 
            // ParaTransferi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bankaotomasyon.Properties.Resources._5630974;
            this.ClientSize = new System.Drawing.Size(395, 338);
            this.Controls.Add(this.pb_resim);
            this.Controls.Add(this.gridmusteriler);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTransferYapilacakTutar);
            this.Controls.Add(this.lblTransferYapilacakMiktar);
            this.Controls.Add(this.lblTransferYapilacakKisi);
            this.Name = "ParaTransferi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Para Transferi";
            this.Load += new System.EventHandler(this.ParaTransferi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridmusteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaotomasyonDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaotomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaotomasyonDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTransferYapilacakKisi;
        private System.Windows.Forms.Label lblTransferYapilacakMiktar;
        private System.Windows.Forms.TextBox txtTransferYapilacakTutar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gridmusteriler;
        private System.Windows.Forms.BindingSource bankaotomasyonDataSetBindingSource;
        private bankaotomasyonDataSet bankaotomasyonDataSet;
        private bankaotomasyonDataSet1 bankaotomasyonDataSet1;
        private System.Windows.Forms.BindingSource musteriBindingSource;
        private bankaotomasyonDataSet1TableAdapters.musteriTableAdapter musteriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriibanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn madDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn msoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pb_resim;
    }
}