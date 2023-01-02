namespace bankaotomasyon
{
    partial class ParaCekme
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
            this.btnParacek = new System.Windows.Forms.Button();
            this.lbl_CekilecekTutar = new System.Windows.Forms.Label();
            this.txtParaCekme = new System.Windows.Forms.TextBox();
            this.pb_resim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnParacek
            // 
            this.btnParacek.Location = new System.Drawing.Point(61, 77);
            this.btnParacek.Name = "btnParacek";
            this.btnParacek.Size = new System.Drawing.Size(75, 23);
            this.btnParacek.TabIndex = 0;
            this.btnParacek.UseVisualStyleBackColor = true;
            this.btnParacek.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_CekilecekTutar
            // 
            this.lbl_CekilecekTutar.AutoSize = true;
            this.lbl_CekilecekTutar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CekilecekTutar.Location = new System.Drawing.Point(43, 16);
            this.lbl_CekilecekTutar.Name = "lbl_CekilecekTutar";
            this.lbl_CekilecekTutar.Size = new System.Drawing.Size(0, 13);
            this.lbl_CekilecekTutar.TabIndex = 1;
            // 
            // txtParaCekme
            // 
            this.txtParaCekme.Location = new System.Drawing.Point(46, 33);
            this.txtParaCekme.Name = "txtParaCekme";
            this.txtParaCekme.Size = new System.Drawing.Size(100, 20);
            this.txtParaCekme.TabIndex = 2;
            // 
            // pb_resim
            // 
            this.pb_resim.BackColor = System.Drawing.Color.Transparent;
            this.pb_resim.Image = global::bankaotomasyon.Properties.Resources.icons8_great_britain_96;
            this.pb_resim.Location = new System.Drawing.Point(164, 77);
            this.pb_resim.Name = "pb_resim";
            this.pb_resim.Size = new System.Drawing.Size(39, 35);
            this.pb_resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_resim.TabIndex = 19;
            this.pb_resim.TabStop = false;
            this.pb_resim.Click += new System.EventHandler(this.pb_resim_Click);
            // 
            // ParaCekme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bankaotomasyon.Properties.Resources._5630974;
            this.ClientSize = new System.Drawing.Size(215, 124);
            this.Controls.Add(this.pb_resim);
            this.Controls.Add(this.txtParaCekme);
            this.Controls.Add(this.lbl_CekilecekTutar);
            this.Controls.Add(this.btnParacek);
            this.Name = "ParaCekme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ParaCekme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnParacek;
        private System.Windows.Forms.Label lbl_CekilecekTutar;
        private System.Windows.Forms.TextBox txtParaCekme;
        private System.Windows.Forms.PictureBox pb_resim;
    }
}