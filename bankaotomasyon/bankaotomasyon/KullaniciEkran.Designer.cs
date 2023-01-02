namespace bankaotomasyon
{
    partial class KullaniciEkran
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
            this.btn_paracek = new System.Windows.Forms.Button();
            this.btn_parayatir = new System.Windows.Forms.Button();
            this.btn_paratransfer = new System.Windows.Forms.Button();
            this.btn_odeme = new System.Windows.Forms.Button();
            this.btn_puancevir = new System.Windows.Forms.Button();
            this.btn_kAskidaPara = new System.Windows.Forms.Button();
            this.bankaotomasyonDataSet = new bankaotomasyon.bankaotomasyonDataSet();
            this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musteriTableAdapter = new bankaotomasyon.bankaotomasyonDataSetTableAdapters.musteriTableAdapter();
            this.musteriBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_hosgeldiniz = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_musteriadsoyad = new System.Windows.Forms.Label();
            this.lbl_bakiye = new System.Windows.Forms.Label();
            this.lbl_puan = new System.Windows.Forms.Label();
            this.lbl_atmtoplampara = new System.Windows.Forms.Label();
            this.lbl_atmdekipara = new System.Windows.Forms.Label();
            this.btn_sansinidene = new System.Windows.Forms.Button();
            this.lbl_kAciklama = new System.Windows.Forms.Label();
            this.pb_resim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bankaotomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_paracek
            // 
            this.btn_paracek.Location = new System.Drawing.Point(77, 89);
            this.btn_paracek.Name = "btn_paracek";
            this.btn_paracek.Size = new System.Drawing.Size(132, 58);
            this.btn_paracek.TabIndex = 0;
            this.btn_paracek.UseVisualStyleBackColor = true;
            this.btn_paracek.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_parayatir
            // 
            this.btn_parayatir.Location = new System.Drawing.Point(77, 153);
            this.btn_parayatir.Name = "btn_parayatir";
            this.btn_parayatir.Size = new System.Drawing.Size(132, 58);
            this.btn_parayatir.TabIndex = 1;
            this.btn_parayatir.UseVisualStyleBackColor = true;
            this.btn_parayatir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_paratransfer
            // 
            this.btn_paratransfer.Location = new System.Drawing.Point(77, 217);
            this.btn_paratransfer.Name = "btn_paratransfer";
            this.btn_paratransfer.Size = new System.Drawing.Size(132, 58);
            this.btn_paratransfer.TabIndex = 2;
            this.btn_paratransfer.UseVisualStyleBackColor = true;
            this.btn_paratransfer.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_odeme
            // 
            this.btn_odeme.Location = new System.Drawing.Point(273, 89);
            this.btn_odeme.Name = "btn_odeme";
            this.btn_odeme.Size = new System.Drawing.Size(132, 58);
            this.btn_odeme.TabIndex = 3;
            this.btn_odeme.UseVisualStyleBackColor = true;
            this.btn_odeme.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_puancevir
            // 
            this.btn_puancevir.Location = new System.Drawing.Point(273, 153);
            this.btn_puancevir.Name = "btn_puancevir";
            this.btn_puancevir.Size = new System.Drawing.Size(132, 58);
            this.btn_puancevir.TabIndex = 4;
            this.btn_puancevir.UseVisualStyleBackColor = true;
            this.btn_puancevir.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_kAskidaPara
            // 
            this.btn_kAskidaPara.Location = new System.Drawing.Point(273, 217);
            this.btn_kAskidaPara.Name = "btn_kAskidaPara";
            this.btn_kAskidaPara.Size = new System.Drawing.Size(132, 58);
            this.btn_kAskidaPara.TabIndex = 5;
            this.btn_kAskidaPara.UseVisualStyleBackColor = true;
            this.btn_kAskidaPara.Click += new System.EventHandler(this.button6_Click);
            // 
            // bankaotomasyonDataSet
            // 
            this.bankaotomasyonDataSet.DataSetName = "bankaotomasyonDataSet";
            this.bankaotomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteriBindingSource
            // 
            this.musteriBindingSource.DataMember = "musteri";
            this.musteriBindingSource.DataSource = this.bankaotomasyonDataSet;
            // 
            // musteriTableAdapter
            // 
            this.musteriTableAdapter.ClearBeforeFill = true;
            // 
            // musteriBindingSource1
            // 
            this.musteriBindingSource1.DataMember = "musteri";
            this.musteriBindingSource1.DataSource = this.bankaotomasyonDataSet;
            // 
            // lbl_hosgeldiniz
            // 
            this.lbl_hosgeldiniz.AutoSize = true;
            this.lbl_hosgeldiniz.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hosgeldiniz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hosgeldiniz.Location = new System.Drawing.Point(12, 9);
            this.lbl_hosgeldiniz.Name = "lbl_hosgeldiniz";
            this.lbl_hosgeldiniz.Size = new System.Drawing.Size(0, 16);
            this.lbl_hosgeldiniz.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(280, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(359, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 11;
            // 
            // lbl_musteriadsoyad
            // 
            this.lbl_musteriadsoyad.AutoSize = true;
            this.lbl_musteriadsoyad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_musteriadsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_musteriadsoyad.Location = new System.Drawing.Point(15, 26);
            this.lbl_musteriadsoyad.Name = "lbl_musteriadsoyad";
            this.lbl_musteriadsoyad.Size = new System.Drawing.Size(0, 24);
            this.lbl_musteriadsoyad.TabIndex = 12;
            // 
            // lbl_bakiye
            // 
            this.lbl_bakiye.AutoSize = true;
            this.lbl_bakiye.BackColor = System.Drawing.Color.Transparent;
            this.lbl_bakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bakiye.Location = new System.Drawing.Point(335, 11);
            this.lbl_bakiye.Name = "lbl_bakiye";
            this.lbl_bakiye.Size = new System.Drawing.Size(0, 20);
            this.lbl_bakiye.TabIndex = 13;
            // 
            // lbl_puan
            // 
            this.lbl_puan.AutoSize = true;
            this.lbl_puan.BackColor = System.Drawing.Color.Transparent;
            this.lbl_puan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_puan.Location = new System.Drawing.Point(403, 309);
            this.lbl_puan.Name = "lbl_puan";
            this.lbl_puan.Size = new System.Drawing.Size(0, 20);
            this.lbl_puan.TabIndex = 14;
            // 
            // lbl_atmtoplampara
            // 
            this.lbl_atmtoplampara.AutoSize = true;
            this.lbl_atmtoplampara.BackColor = System.Drawing.Color.Transparent;
            this.lbl_atmtoplampara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_atmtoplampara.Location = new System.Drawing.Point(12, 310);
            this.lbl_atmtoplampara.Name = "lbl_atmtoplampara";
            this.lbl_atmtoplampara.Size = new System.Drawing.Size(0, 16);
            this.lbl_atmtoplampara.TabIndex = 15;
            // 
            // lbl_atmdekipara
            // 
            this.lbl_atmdekipara.AutoSize = true;
            this.lbl_atmdekipara.BackColor = System.Drawing.Color.Transparent;
            this.lbl_atmdekipara.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_atmdekipara.Location = new System.Drawing.Point(165, 306);
            this.lbl_atmdekipara.Name = "lbl_atmdekipara";
            this.lbl_atmdekipara.Size = new System.Drawing.Size(0, 24);
            this.lbl_atmdekipara.TabIndex = 16;
            // 
            // btn_sansinidene
            // 
            this.btn_sansinidene.Location = new System.Drawing.Point(390, 347);
            this.btn_sansinidene.Name = "btn_sansinidene";
            this.btn_sansinidene.Size = new System.Drawing.Size(97, 23);
            this.btn_sansinidene.TabIndex = 17;
            this.btn_sansinidene.UseVisualStyleBackColor = true;
            this.btn_sansinidene.Click += new System.EventHandler(this.button7_Click);
            // 
            // lbl_kAciklama
            // 
            this.lbl_kAciklama.BackColor = System.Drawing.Color.Transparent;
            this.lbl_kAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kAciklama.Location = new System.Drawing.Point(4, 348);
            this.lbl_kAciklama.Name = "lbl_kAciklama";
            this.lbl_kAciklama.Size = new System.Drawing.Size(381, 31);
            this.lbl_kAciklama.TabIndex = 18;
            // 
            // pb_resim
            // 
            this.pb_resim.BackColor = System.Drawing.Color.Transparent;
            this.pb_resim.Image = global::bankaotomasyon.Properties.Resources.icons8_great_britain_96;
            this.pb_resim.Location = new System.Drawing.Point(445, 4);
            this.pb_resim.Name = "pb_resim";
            this.pb_resim.Size = new System.Drawing.Size(39, 35);
            this.pb_resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_resim.TabIndex = 19;
            this.pb_resim.TabStop = false;
            this.pb_resim.Click += new System.EventHandler(this.pb_resim_Click);
            // 
            // KullaniciEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bankaotomasyon.Properties.Resources._5630974;
            this.ClientSize = new System.Drawing.Size(491, 384);
            this.Controls.Add(this.pb_resim);
            this.Controls.Add(this.lbl_kAciklama);
            this.Controls.Add(this.btn_sansinidene);
            this.Controls.Add(this.lbl_atmdekipara);
            this.Controls.Add(this.lbl_atmtoplampara);
            this.Controls.Add(this.lbl_puan);
            this.Controls.Add(this.lbl_bakiye);
            this.Controls.Add(this.lbl_musteriadsoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_hosgeldiniz);
            this.Controls.Add(this.btn_kAskidaPara);
            this.Controls.Add(this.btn_puancevir);
            this.Controls.Add(this.btn_odeme);
            this.Controls.Add(this.btn_paratransfer);
            this.Controls.Add(this.btn_parayatir);
            this.Controls.Add(this.btn_paracek);
            this.Name = "KullaniciEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KullaniciEkran_FormClosing);
            this.Load += new System.EventHandler(this.KullaniciEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankaotomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_paracek;
        private System.Windows.Forms.Button btn_parayatir;
        private System.Windows.Forms.Button btn_paratransfer;
        private System.Windows.Forms.Button btn_odeme;
        private System.Windows.Forms.Button btn_puancevir;
        private System.Windows.Forms.Button btn_kAskidaPara;
        private bankaotomasyonDataSet bankaotomasyonDataSet;
        private System.Windows.Forms.BindingSource musteriBindingSource;
        private bankaotomasyonDataSetTableAdapters.musteriTableAdapter musteriTableAdapter;
        private System.Windows.Forms.BindingSource musteriBindingSource1;
        private System.Windows.Forms.Label lbl_hosgeldiniz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_musteriadsoyad;
        private System.Windows.Forms.Label lbl_bakiye;
        private System.Windows.Forms.Label lbl_puan;
        private System.Windows.Forms.Label lbl_atmtoplampara;
        private System.Windows.Forms.Label lbl_atmdekipara;
        private System.Windows.Forms.Button btn_sansinidene;
        private System.Windows.Forms.Label lbl_kAciklama;
        private System.Windows.Forms.PictureBox pb_resim;
    }
}