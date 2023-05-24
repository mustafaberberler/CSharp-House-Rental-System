﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ev_KiralamaOtomasyonu
{
    public partial class Uye_Giris_Ekrani : Form
    {
        public Uye_Giris_Ekrani()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=MUSTAFA;Initial Catalog=EvKiralamaVeriTabani;Integrated Security=True");



        // Formlar arası veri aktarımında kullanılacak değişkenler

        public static string tcno;
        public static string ad;
        public static string soyad;
        public static string yetki;

        // Yerel değişkenler

        int hak = 3;
        bool durum = false;


        private void Kullanici_Giris_Load(object sender, EventArgs e)
        {
            this.Text = "Giriş Ekranı";
            lblKalanGirisHakki.ForeColor = Color.Red;            
            lblKalanGirisHakki.Text = Convert.ToString(hak);
            radioButton1.Checked = true;        
            panel1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\arkaplanresimler\\arkaplan2.png");
        }

        private void button1_Click(object sender, EventArgs e)    // giriş yap butonu
        {
            if (hak != 0)
            {
                baglanti.Open();    // veritabanı bağlantısı açıldı
                SqlCommand komut = new SqlCommand("Select * From Tbl_kullanicilar", baglanti);  // Tbl_kullanicilar tablosundaki bütün veriler seçildi
                SqlDataReader kayitoku = komut.ExecuteReader();   // Seçilen bütün veriler DataReader'a aktarıldı
                while (kayitoku.Read())   
                {
                    if (radioButton1.Checked == true) // Giriş yapan kişi kullanıcı ise
                    {
                        if (kayitoku["kullaniciadi"].ToString() == txtKullaniciAdi.Text && kayitoku["parola"].ToString() == txtSifre.Text && kayitoku["yetki"].ToString() == "Yönetici")
                        {  // Tbl_kullanıcılar tablosunda giriş yapan kişinin kullanıcı adı, şifresi ve yetkisine ait kayıt varsa
                            durum = true;  // Kişinin bulunduğunu belirtmek için durum değişkeni true olarak değiştirildi.
                            tcno = kayitoku.GetValue(0).ToString();  // Diğer formlarda da kullanılmak üzere tcno, ad ve soyad değişkenleri global değişken olarak ayarlandı 
                            ad = kayitoku.GetValue(1).ToString();    // Giriş yapan kişinin TC Kimlik Numarası, adı ve soyadı bu global değişkenlere atandı
                            soyad = kayitoku.GetValue(2).ToString();        
                            
                            this.Hide();
                            Yonetici yoneticiform = new Yonetici();   // Yönetici formuna yönlendirilmesi sağlandı
                            yoneticiform.Show();
                            break;
                        }
                    }
                    if (radioButton2.Checked == true)
                    {
                        if (kayitoku["kullaniciadi"].ToString() == txtKullaniciAdi.Text && kayitoku["parola"].ToString() == txtSifre.Text && kayitoku["yetki"].ToString() == "Kullanıcı")
                        {  // Giriş yapan kişinin yetkisi kullanıcı ise
                            durum = true;
                            tcno = kayitoku.GetValue(0).ToString();  // Global değişkenlere bilgileri atandı
                            ad = kayitoku.GetValue(1).ToString();
                            soyad = kayitoku.GetValue(2).ToString();       
                            this.Hide();
                            Kullanici kullaniciform = new Kullanici(); // Kullanıcı formuna yönlendirilmesi sağlandı
                            kullaniciform.Show();
                            break;
                        }
                    }
                }
                if (durum == false) // Eğer böyle bir kullanıcı sistemde bulunmuyorsa
                {  
                    hak--;   // Her yanlış kullanıcı adı ve şifre girdiğinde giriş yapma hakkı 1 azaldı
                }
                baglanti.Close();
            }
            lblKalanGirisHakki.Text = Convert.ToString(hak);
            if (hak == 0)  // Giriş hakkı kalmadığında
            {
                btn_GirisYap.Enabled = false;
                MessageBox.Show("Giriş hakkınız kalmamıştır.", "Metrekare Emlak", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btn_Cikis_Click(object sender, EventArgs e)    // çıkış butonu
        {
            DialogResult dialog2 = new DialogResult();
            dialog2 = MessageBox.Show("Gerçekten çıkış yapmak istiyor musunuz?", "Metrekare Emlak", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog2 == DialogResult.Yes)
            {
                MessageBox.Show("Bizi tercih ettiğiniz için teşekkür ederiz. İyi günler dileriz.", "Metrekare Emlak", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            else if (dialog2 == DialogResult.No)
            {

            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtSifre.UseSystemPasswordChar = false;
            }
            else
            {
                txtSifre.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kullanici_Kayit_Ol kayitol = new Kullanici_Kayit_Ol();
            kayitol.Show();
            this.Hide();
        }
    }
}
