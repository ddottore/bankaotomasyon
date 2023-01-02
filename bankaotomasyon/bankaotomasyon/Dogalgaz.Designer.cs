namespace bankaotomasyon
{
    partial class Dogalgaz
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
            this.btn_faturaode = new System.Windows.Forms.Button();
            this.lbl_tutar = new System.Windows.Forms.Label();
            this.lbl_faturamesaj = new System.Windows.Forms.Label();
            this.lbl_odenecektutar = new System.Windows.Forms.Label();
            this.pb_resim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_faturaode
            // 
            this.btn_faturaode.Location = new System.Drawing.Point(20, 71);
            this.btn_faturaode.Name = "btn_faturaode";
            this.btn_faturaode.Size = new System.Drawing.Size(88, 26);
            this.btn_faturaode.TabIndex = 7;
            this.btn_faturaode.UseVisualStyleBackColor = true;
            this.btn_faturaode.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_tutar
            // 
            this.lbl_tutar.AutoSize = true;
            this.lbl_tutar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tutar.Location = new System.Drawing.Point(128, 29);
            this.lbl_tutar.Name = "lbl_tutar";
            this.lbl_tutar.Size = new System.Drawing.Size(0, 16);
            this.lbl_tutar.TabIndex = 6;
            // 
            // lbl_faturamesaj
            // 
            this.lbl_faturamesaj.AutoSize = true;
            this.lbl_faturamesaj.BackColor = System.Drawing.Color.Transparent;
            this.lbl_faturamesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_faturamesaj.Location = new System.Drawing.Point(31, 125);
            this.lbl_faturamesaj.Name = "lbl_faturamesaj";
            this.lbl_faturamesaj.Size = new System.Drawing.Size(0, 15);
            this.lbl_faturamesaj.TabIndex = 5;
            // 
            // lbl_odenecektutar
            // 
            this.lbl_odenecektutar.AutoSize = true;
            this.lbl_odenecektutar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_odenecektutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_odenecektutar.Location = new System.Drawing.Point(12, 29);
            this.lbl_odenecektutar.Name = "lbl_odenecektutar";
            this.lbl_odenecektutar.Size = new System.Drawing.Size(0, 16);
            this.lbl_odenecektutar.TabIndex = 4;
            // 
            // pb_resim
            // 
            this.pb_resim.BackColor = System.Drawing.Color.Transparent;
            this.pb_resim.Image = global::bankaotomasyon.Properties.Resources.icons8_great_britain_96;
            this.pb_resim.Location = new System.Drawing.Point(224, 4);
            this.pb_resim.Name = "pb_resim";
            this.pb_resim.Size = new System.Drawing.Size(39, 35);
            this.pb_resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_resim.TabIndex = 20;
            this.pb_resim.TabStop = false;
            this.pb_resim.Click += new System.EventHandler(this.pb_resim_Click);
            // 
            // Dogalgaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bankaotomasyon.Properties.Resources._5630974;
            this.ClientSize = new System.Drawing.Size(269, 149);
            this.Controls.Add(this.pb_resim);
            this.Controls.Add(this.btn_faturaode);
            this.Controls.Add(this.lbl_tutar);
            this.Controls.Add(this.lbl_faturamesaj);
            this.Controls.Add(this.lbl_odenecektutar);
            this.Name = "Dogalgaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Dogalgaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_faturaode;
        private System.Windows.Forms.Label lbl_tutar;
        private System.Windows.Forms.Label lbl_faturamesaj;
        private System.Windows.Forms.Label lbl_odenecektutar;
        private System.Windows.Forms.PictureBox pb_resim;
    }
}