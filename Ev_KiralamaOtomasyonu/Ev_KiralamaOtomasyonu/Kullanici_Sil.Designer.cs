
namespace Ev_KiralamaOtomasyonu
{
    partial class Kullanici_Sil
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
            this.btn_Geri = new System.Windows.Forms.Button();
            this.btn_Cikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKullaniciSil = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.picBoxKullaniciFoto = new System.Windows.Forms.PictureBox();
            this.lblKullaniciAdSoyad = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_OturumuKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKullaniciFoto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Geri
            // 
            this.btn_Geri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Geri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Geri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Geri.Location = new System.Drawing.Point(12, 12);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(118, 44);
            this.btn_Geri.TabIndex = 3;
            this.btn_Geri.Text = "Geri";
            this.btn_Geri.UseVisualStyleBackColor = false;
            this.btn_Geri.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cikis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Cikis.Location = new System.Drawing.Point(1099, 12);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(118, 44);
            this.btn_Cikis.TabIndex = 4;
            this.btn_Cikis.Text = "Çıkış";
            this.btn_Cikis.UseVisualStyleBackColor = false;
            this.btn_Cikis.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Silmek İstediğiniz Kullanıcının TC Kimlik Numarasını Giriniz:";
            // 
            // txtKullaniciSil
            // 
            this.txtKullaniciSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtKullaniciSil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciSil.Location = new System.Drawing.Point(580, 177);
            this.txtKullaniciSil.Name = "txtKullaniciSil";
            this.txtKullaniciSil.Size = new System.Drawing.Size(245, 27);
            this.txtKullaniciSil.TabIndex = 0;
            this.txtKullaniciSil.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtKullaniciSil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(580, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 40);
            this.button3.TabIndex = 1;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(714, 222);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 40);
            this.button4.TabIndex = 2;
            this.button4.Text = "Temizle";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // picBoxKullaniciFoto
            // 
            this.picBoxKullaniciFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxKullaniciFoto.Location = new System.Drawing.Point(993, 86);
            this.picBoxKullaniciFoto.Name = "picBoxKullaniciFoto";
            this.picBoxKullaniciFoto.Size = new System.Drawing.Size(150, 150);
            this.picBoxKullaniciFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxKullaniciFoto.TabIndex = 4;
            this.picBoxKullaniciFoto.TabStop = false;
            // 
            // lblKullaniciAdSoyad
            // 
            this.lblKullaniciAdSoyad.AutoSize = true;
            this.lblKullaniciAdSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblKullaniciAdSoyad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdSoyad.Location = new System.Drawing.Point(989, 242);
            this.lblKullaniciAdSoyad.Name = "lblKullaniciAdSoyad";
            this.lblKullaniciAdSoyad.Size = new System.Drawing.Size(51, 20);
            this.lblKullaniciAdSoyad.TabIndex = 5;
            this.lblKullaniciAdSoyad.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_OturumuKapat);
            this.panel1.Controls.Add(this.btn_Geri);
            this.panel1.Controls.Add(this.lblKullaniciAdSoyad);
            this.panel1.Controls.Add(this.btn_Cikis);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picBoxKullaniciFoto);
            this.panel1.Controls.Add(this.txtKullaniciSil);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 400);
            this.panel1.TabIndex = 6;
            // 
            // btn_OturumuKapat
            // 
            this.btn_OturumuKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_OturumuKapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OturumuKapat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_OturumuKapat.Location = new System.Drawing.Point(975, 13);
            this.btn_OturumuKapat.Name = "btn_OturumuKapat";
            this.btn_OturumuKapat.Size = new System.Drawing.Size(118, 44);
            this.btn_OturumuKapat.TabIndex = 6;
            this.btn_OturumuKapat.Text = "Oturumu Kapat";
            this.btn_OturumuKapat.UseVisualStyleBackColor = false;
            this.btn_OturumuKapat.Click += new System.EventHandler(this.btn_OturumuKapat_Click);
            // 
            // Kullanici_Sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 398);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Kullanici_Sil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanici_Sil";
            this.Load += new System.EventHandler(this.Kullanici_Sil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKullaniciFoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Geri;
        private System.Windows.Forms.Button btn_Cikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKullaniciSil;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox picBoxKullaniciFoto;
        private System.Windows.Forms.Label lblKullaniciAdSoyad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_OturumuKapat;
    }
}