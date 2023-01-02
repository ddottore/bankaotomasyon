namespace bankaotomasyon
{
    partial class ReferansGiris
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
            this.lblReferanskodu = new System.Windows.Forms.Label();
            this.txtReferansKodu = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.pb_resim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReferanskodu
            // 
            this.lblReferanskodu.AutoSize = true;
            this.lblReferanskodu.BackColor = System.Drawing.Color.Transparent;
            this.lblReferanskodu.Location = new System.Drawing.Point(8, 34);
            this.lblReferanskodu.Name = "lblReferanskodu";
            this.lblReferanskodu.Size = new System.Drawing.Size(0, 13);
            this.lblReferanskodu.TabIndex = 0;
            this.lblReferanskodu.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtReferansKodu
            // 
            this.txtReferansKodu.Location = new System.Drawing.Point(103, 31);
            this.txtReferansKodu.MaxLength = 10;
            this.txtReferansKodu.Name = "txtReferansKodu";
            this.txtReferansKodu.Size = new System.Drawing.Size(194, 20);
            this.txtReferansKodu.TabIndex = 1;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(153, 71);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(75, 23);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnReferansGiris_Click);
            // 
            // pb_resim
            // 
            this.pb_resim.BackColor = System.Drawing.Color.Transparent;
            this.pb_resim.Image = global::bankaotomasyon.Properties.Resources.icons8_great_britain_96;
            this.pb_resim.Location = new System.Drawing.Point(271, 67);
            this.pb_resim.Name = "pb_resim";
            this.pb_resim.Size = new System.Drawing.Size(39, 35);
            this.pb_resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_resim.TabIndex = 19;
            this.pb_resim.TabStop = false;
            this.pb_resim.Click += new System.EventHandler(this.pb_resim_Click);
            // 
            // ReferansGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bankaotomasyon.Properties.Resources._5630974;
            this.ClientSize = new System.Drawing.Size(314, 106);
            this.Controls.Add(this.pb_resim);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtReferansKodu);
            this.Controls.Add(this.lblReferanskodu);
            this.Name = "ReferansGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ReferansGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReferanskodu;
        private System.Windows.Forms.TextBox txtReferansKodu;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.PictureBox pb_resim;
    }
}