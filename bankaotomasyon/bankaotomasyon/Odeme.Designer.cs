namespace bankaotomasyon
{
    partial class Odeme
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
            this.btnSu = new System.Windows.Forms.Button();
            this.btnDogalgaz = new System.Windows.Forms.Button();
            this.btnElektrik = new System.Windows.Forms.Button();
            this.lblOdenecekFatura = new System.Windows.Forms.Label();
            this.pb_resim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSu
            // 
            this.btnSu.Location = new System.Drawing.Point(22, 113);
            this.btnSu.Name = "btnSu";
            this.btnSu.Size = new System.Drawing.Size(129, 49);
            this.btnSu.TabIndex = 0;
            this.btnSu.UseVisualStyleBackColor = true;
            this.btnSu.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDogalgaz
            // 
            this.btnDogalgaz.Location = new System.Drawing.Point(22, 168);
            this.btnDogalgaz.Name = "btnDogalgaz";
            this.btnDogalgaz.Size = new System.Drawing.Size(129, 49);
            this.btnDogalgaz.TabIndex = 1;
            this.btnDogalgaz.UseVisualStyleBackColor = true;
            this.btnDogalgaz.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnElektrik
            // 
            this.btnElektrik.Location = new System.Drawing.Point(22, 58);
            this.btnElektrik.Name = "btnElektrik";
            this.btnElektrik.Size = new System.Drawing.Size(129, 49);
            this.btnElektrik.TabIndex = 2;
            this.btnElektrik.UseVisualStyleBackColor = true;
            this.btnElektrik.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblOdenecekFatura
            // 
            this.lblOdenecekFatura.AutoSize = true;
            this.lblOdenecekFatura.BackColor = System.Drawing.Color.Transparent;
            this.lblOdenecekFatura.Location = new System.Drawing.Point(19, 18);
            this.lblOdenecekFatura.Name = "lblOdenecekFatura";
            this.lblOdenecekFatura.Size = new System.Drawing.Size(0, 13);
            this.lblOdenecekFatura.TabIndex = 3;
            // 
            // pb_resim
            // 
            this.pb_resim.BackColor = System.Drawing.Color.Transparent;
            this.pb_resim.Image = global::bankaotomasyon.Properties.Resources.icons8_great_britain_96;
            this.pb_resim.Location = new System.Drawing.Point(133, 223);
            this.pb_resim.Name = "pb_resim";
            this.pb_resim.Size = new System.Drawing.Size(39, 35);
            this.pb_resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_resim.TabIndex = 19;
            this.pb_resim.TabStop = false;
            this.pb_resim.Click += new System.EventHandler(this.pb_resim_Click);
            // 
            // Odeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bankaotomasyon.Properties.Resources._5630974;
            this.ClientSize = new System.Drawing.Size(174, 260);
            this.Controls.Add(this.pb_resim);
            this.Controls.Add(this.lblOdenecekFatura);
            this.Controls.Add(this.btnElektrik);
            this.Controls.Add(this.btnDogalgaz);
            this.Controls.Add(this.btnSu);
            this.Name = "Odeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Odeme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSu;
        private System.Windows.Forms.Button btnDogalgaz;
        private System.Windows.Forms.Button btnElektrik;
        private System.Windows.Forms.Label lblOdenecekFatura;
        private System.Windows.Forms.PictureBox pb_resim;
    }
}