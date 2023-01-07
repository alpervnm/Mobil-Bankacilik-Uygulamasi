using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ProjeÖdevi
{
    public partial class Sifre : Form
    {
        public Sifre()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Arayüz arayüz1 = new Arayüz();
            arayüz1.Show();
            arayüz1.Location = new Point(100, 100);
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Uygulamayı kapatmak mı istiyorsunuz?", "Uygulama Çıkış", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {

                Application.Exit();
            }
            else
            {

            };

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ayarlar ayar1 = new Ayarlar();
            ayar1.Show();
            ayar1.Location = new Point(100, 100);
            this.Hide();
        }

        private void Sifre_Load(object sender, EventArgs e)
        {
            
        }
        SqlConnection baglanti = new SqlConnection("Data Source = ALPER; Initial Catalog = BankaProje; Integrated Security = True");
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Giris.şfr)
            {

                if (textBox2.Text == textBox3.Text)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("update MusteriBilgi set Şifre = @k1 where HesapNo = @k2", baglanti);
                    komut.Parameters.AddWithValue("@k2", Arayüz.Hesap);
                    komut.Parameters.AddWithValue("@k1", textBox2.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Şifreniz başarıyla DEĞİŞTİRİLDİ.","Başarılı");

                }
                else
                {
                    MessageBox.Show("Girdiğiniz yeni şifreler aynı olmak zorunda!","Uyarı");
                }
                

            }

            else
            {
                MessageBox.Show("Şifrenizi yanlış girdiniz Lütfen tekrar deneyin.","Uyarı");
            }
            

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Giris grs = new Giris();
            grs.Show();
            grs.Location = new Point(100, 100);
            this.Hide();
        }
    }
}
