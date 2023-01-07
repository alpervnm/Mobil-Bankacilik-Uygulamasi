using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeÖdevi
{
    public partial class Odemeler : Form
    {
        public Odemeler()
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

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu m1 = new Menu();
            m1.Show();
            m1.Location = new Point(100, 100);
            this.Hide();
        }

        private void Odemeler_Load(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection("Data Source = ALPER; Initial Catalog = BankaProje; Integrated Security = True");
        
        private void button3_Click(object sender, EventArgs e)
        {
            
            if (Arayüz.Para >= 3000)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update MusteriBilgi set ParaMiktarı = @k1 where HesapNo = @k2", baglanti);
                komut.Parameters.AddWithValue("@k2", Arayüz.Hesap);
                komut.Parameters.AddWithValue("@k1", Arayüz.Para - 3000);
                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Ödemeniz Başarıyla gerçekleşmiştir, Teşekkür ederiz.", "Başarılı");
                Arayüz.Para = Arayüz.Para - 3000;
            }
            else
            {
                MessageBox.Show("Yeterli bakiyeniz yoktur.","Yetersiz Bakiye");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Arayüz.Para >= 200)
            {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MusteriBilgi set ParaMiktarı = @k1 where HesapNo = @k2", baglanti);
            komut.Parameters.AddWithValue("@k2", Arayüz.Hesap);
            komut.Parameters.AddWithValue("@k1", Arayüz.Para - 200);
            komut.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Ödemeniz Başarıyla gerçekleşmiştir, Teşekkür ederiz.", "Başarılı");
            Arayüz.Para = Arayüz.Para - 200;

            }
            else
            {
                MessageBox.Show("Yeterli bakiyeniz yoktur.", "Yetersiz Bakiye");
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Arayüz.Para >= 150)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update MusteriBilgi set ParaMiktarı = @k1 where HesapNo = @k2", baglanti);
                komut.Parameters.AddWithValue("@k2", Arayüz.Hesap);
                komut.Parameters.AddWithValue("@k1", Arayüz.Para - 150);
                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Ödemeniz Başarıyla gerçekleşmiştir, Teşekkür ederiz.", "Başarılı");
                Arayüz.Para = Arayüz.Para - 150;
            }
            else
            {
                MessageBox.Show("Yeterli bakiyeniz yoktur.", "Yetersiz Bakiye");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Arayüz.Para >= 750)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update MusteriBilgi set ParaMiktarı = @k1 where HesapNo = @k2", baglanti);
                komut.Parameters.AddWithValue("@k2", Arayüz.Hesap);
                komut.Parameters.AddWithValue("@k1", Arayüz.Para - 750);
                komut.ExecuteNonQuery();
                Arayüz.Para = Arayüz.Para - 750;

                baglanti.Close();
                MessageBox.Show("Ödemeniz Başarıyla gerçekleşmiştir, Teşekkür ederiz.", "Başarılı");

            }
            else
            {
                MessageBox.Show("Yeterli bakiyeniz yoktur.", "Yetersiz Bakiye");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Arayüz.Para >= 500)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update MusteriBilgi set ParaMiktarı = @k1 where HesapNo = @k2", baglanti);
                komut.Parameters.AddWithValue("@k2", Arayüz.Hesap);
                komut.Parameters.AddWithValue("@k1", Arayüz.Para - 500);
                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Ödemeniz Başarıyla gerçekleşmiştir, Teşekkür ederiz.", "Başarılı");
                Arayüz.Para = Arayüz.Para - 500;
            }
            else
            {
                MessageBox.Show("Yeterli bakiyeniz yoktur.", "Yetersiz Bakiye");
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Oturumu kapatmak mı istiyorsunuz?", "Oturum Durumu", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                Giris grs = new Giris();
                grs.Show();
                grs.Location = new Point(100, 100);
                this.Hide();
            }
            else
            {

            }
        }
    }
}
