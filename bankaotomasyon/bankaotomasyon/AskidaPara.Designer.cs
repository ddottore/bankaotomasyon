namespace bankaotomasyon
{
    partial class AskidaPara
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
            this.btn_Bagis = new System.Windows.Forms.Button();
            this.txt_askidapara = new System.Windows.Forms.TextBox();
            this.lbl_YapilacakBagis = new System.Windows.Forms.Label();
            this.lbl_AskidakiToplamPara = new System.Windows.Forms.Label();
            this.lbl_AskidakiPara = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_resim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Bagis
            // 
            this.btn_Bagis.Location = new System.Drawing.Point(92, 161);
            this.btn_Bagis.Name = "btn_Bagis";
            this.btn_Bagis.Size = new System.Drawing.Size(75, 23);
            this.btn_Bagis.TabIndex = 0;
            this.btn_Bagis.UseVisualStyleBackColor = true;
            this.btn_Bagis.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_askidapara
            // 
            this.txt_askidapara.Location = new System.Drawing.Point(142, 122);
            this.txt_askidapara.Name = "txt_askidapara";
            this.txt_askidapara.Size = new System.Drawing.Size(100, 20);
            this.txt_askidapara.TabIndex = 1;
            // 
            // lbl_YapilacakBagis
            // 
            this.lbl_YapilacakBagis.AutoSize = true;
            this.lbl_YapilacakBagis.BackColor = System.Drawing.Color.Transparent;
            this.lbl_YapilacakBagis.Location = new System.Drawing.Point(19, 125);
            this.lbl_YapilacakBagis.Name = "lbl_YapilacakBagis";
            this.lbl_YapilacakBagis.Size = new System.Drawing.Size(0, 13);
            this.lbl_YapilacakBagis.TabIndex = 2;
            // 
            // lbl_AskidakiToplamPara
            // 
            this.lbl_AskidakiToplamPara.AutoSize = true;
            this.lbl_AskidakiToplamPara.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AskidakiToplamPara.Location = new System.Drawing.Point(71, 25);
            this.lbl_AskidakiToplamPara.Name = "lbl_AskidakiToplamPara";
            this.lbl_AskidakiToplamPara.Size = new System.Drawing.Size(0, 13);
            this.lbl_AskidakiToplamPara.TabIndex = 4;
            // 
            // lbl_AskidakiPara
            // 
            this.lbl_AskidakiPara.AutoSize = true;
            this.lbl_AskidakiPara.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AskidakiPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_AskidakiPara.Location = new System.Drawing.Point(76, 46);
            this.lbl_AskidakiPara.Name = "lbl_AskidakiPara";
            this.lbl_AskidakiPara.Size = new System.Drawing.Size(0, 20);
            this.lbl_AskidakiPara.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::bankaotomasyon.Properties.Resources.icons8_wicker_basket_50;
            this.pictureBox1.Location = new System.Drawing.Point(34, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pb_resim
            // 
            this.pb_resim.BackColor = System.Drawing.Color.Transparent;
            this.pb_resim.Image = global::bankaotomasyon.Properties.Resources.icons8_great_britain_96;
            this.pb_resim.Location = new System.Drawing.Point(211, 4);
            this.pb_resim.Name = "pb_resim";
            this.pb_resim.Size = new System.Drawing.Size(39, 35);
            this.pb_resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_resim.TabIndex = 19;
            this.pb_resim.TabStop = false;
            this.pb_resim.Click += new System.EventHandler(this.pb_resim_Click);
            // 
            // AskidaPara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::bankaotomasyon.Properties.Resources._5630974;
            this.ClientSize = new System.Drawing.Size(257, 202);
            this.Controls.Add(this.pb_resim);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_AskidakiPara);
            this.Controls.Add(this.lbl_AskidakiToplamPara);
            this.Controls.Add(this.lbl_YapilacakBagis);
            this.Controls.Add(this.txt_askidapara);
            this.Controls.Add(this.btn_Bagis);
            this.Name = "AskidaPara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AskidaPara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Bagis;
        private System.Windows.Forms.TextBox txt_askidapara;
        private System.Windows.Forms.Label lbl_YapilacakBagis;
        private System.Windows.Forms.Label lbl_AskidakiToplamPara;
        private System.Windows.Forms.Label lbl_AskidakiPara;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pb_resim;
    }
}