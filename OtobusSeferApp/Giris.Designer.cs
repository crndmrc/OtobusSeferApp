﻿namespace OtobusSeferApp
{
    partial class Giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_kullaniciAdi = new System.Windows.Forms.Label();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.txt_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.btn_girisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_kullaniciAdi
            // 
            this.lbl_kullaniciAdi.AutoSize = true;
            this.lbl_kullaniciAdi.Location = new System.Drawing.Point(74, 45);
            this.lbl_kullaniciAdi.Name = "lbl_kullaniciAdi";
            this.lbl_kullaniciAdi.Size = new System.Drawing.Size(64, 13);
            this.lbl_kullaniciAdi.TabIndex = 0;
            this.lbl_kullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Location = new System.Drawing.Point(74, 72);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(28, 13);
            this.lbl_sifre.TabIndex = 1;
            this.lbl_sifre.Text = "Şifre";
            // 
            // txt_kullaniciAdi
            // 
            this.txt_kullaniciAdi.Location = new System.Drawing.Point(180, 42);
            this.txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            this.txt_kullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.txt_kullaniciAdi.TabIndex = 2;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(180, 69);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(100, 20);
            this.txt_sifre.TabIndex = 3;
            // 
            // btn_girisYap
            // 
            this.btn_girisYap.Location = new System.Drawing.Point(205, 106);
            this.btn_girisYap.Name = "btn_girisYap";
            this.btn_girisYap.Size = new System.Drawing.Size(75, 23);
            this.btn_girisYap.TabIndex = 4;
            this.btn_girisYap.Text = "Giriş Yap";
            this.btn_girisYap.UseVisualStyleBackColor = true;
            this.btn_girisYap.Click += new System.EventHandler(this.btn_girisYap_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 179);
            this.Controls.Add(this.btn_girisYap);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kullaniciAdi);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_kullaniciAdi);
            this.Name = "Giris";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_kullaniciAdi;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.TextBox txt_kullaniciAdi;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Button btn_girisYap;
    }
}

