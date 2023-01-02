namespace bankaotomasyon
{
    partial class ParaYatirma
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
            this.txtParaYatir = new System.Windows.Forms.TextBox();
            this.lblYatiralacakTutar = new System.Windows.Forms.Label();
            this.btnParayatir = new System.Windows.Forms.Button();
            this.pb_resim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).BeginInit();
            this.SuspendLayout();
            // 
            // txtParaYatir
            // 
            this.txtParaYatir.Location = new System.Drawing.Point(102, 28);
            this.txtParaYatir.Name = "txtParaYatir";
            this.txtParaYatir.Size = new System.Drawing.Size(100, 20);
            this.txtParaYatir.TabIndex = 5;
            // 
            // lblYatiralacakTutar
            // 
            this.lblYatiralacakTutar.AutoSize = true;
            this.lblYatiralacakTutar.BackColor = System.Drawing.Color.Transparent;
            this.lblYatiralacakTutar.Location = new System.Drawing.Point(3, 31);
            this.lblYatiralacakTutar.Name = "lblYatiralacakTutar";
            this.lblYatiralacakTutar.Size = new System.Drawing.Size(0, 13);
            this.lblYatiralacakTutar.TabIndex = 4;
            // 
            // btnParayatir
            // 
            this.btnParayatir.Location = new System.Drawing.Point(63, 72);
            this.btnParayatir.Name = "btnParayatir";
            this.btnParayatir.Size = new System.Drawing.Size(75, 23);
            this.btnParayatir.TabIndex = 3;
            this.btnParayatir.UseVisualStyleBackColor = true;
            this.btnParayatir.Click += new System.EventHandler(this.button1_Click);
            // 
            // pb_resim
            // 
            this.pb_resim.BackColor = System.Drawing.Color.Transparent;
            this.pb_resim.Image = global::bankaotomasyon.Properties.Resources.icons8_great_britain_96;
            this.pb_resim.Location = new System.Drawing.Point(170, 81);
            this.pb_resim.Name = "pb_resim";
            this.pb_resim.Size = new System.Drawing.Size(39, 35);
            this.pb_resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_resim.TabIndex = 20;
            this.pb_resim.TabStop = false;
            this.pb_resim.Click += new System.EventHandler(this.pb_resim_Click);
            // 
            // ParaYatirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bankaotomasyon.Properties.Resources._5630974;
            this.ClientSize = new System.Drawing.Size(221, 118);
            this.Controls.Add(this.pb_resim);
            this.Controls.Add(this.txtParaYatir);
            this.Controls.Add(this.lblYatiralacakTutar);
            this.Controls.Add(this.btnParayatir);
            this.Name = "ParaYatirma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ParaYatirma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtParaYatir;
        private System.Windows.Forms.Label lblYatiralacakTutar;
        private System.Windows.Forms.Button btnParayatir;
        private System.Windows.Forms.PictureBox pb_resim;
    }
}