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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjeÖdevi
{
    public partial class delACC : Form
    {
        public delACC()
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

        private void button4_Click(object sender, EventArgs e)
        {
            Ayarlar ayar1 = new Ayarlar();
            ayar1.Show();
            ayar1.Location = new Point(100, 100);
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
        SqlConnection baglanti = new SqlConnection("Data Source = ALPER; Initial Catalog = BankaProje; Integrated Security = True");
        private void button1_Click(object sender, EventArgs e)
        {
            if (Arayüz.Hesap == textBox3.Text)
            {
                if (Giris.şfr == textBox4.Text)
                {
                    baglanti.Open();
                    SqlCommand sil = new SqlCommand("Delete From MusteriBilgi where HesapNo=@no", baglanti);
                    sil.Parameters.AddWithValue("@no", textBox3.Text);
                    sil.ExecuteNonQuery();
                    baglanti.Close();
                   
                    DialogResult result1 = MessageBox.Show("Hesabınızı silmeyi onaylıyor musunuz?", "Önemli Uyarı", MessageBoxButtons.YesNo);
                    if (result1 == DialogResult.Yes)
                    {
                        Giris grs = new Giris();
                        grs.Show();
                        grs.Location = new Point(100, 100);
                        this.Hide();
                    }
                    else
                    {

                    };
                   
                }
                else
                {
                    MessageBox.Show("Şifrenizi yanlış girdiniz.","Hata");
                }
                
            }
            else
            {
                MessageBox.Show("Hesap Numaranızı yanlış girdiniz.","Hata");
            }
            
        }

        private void delACC_Load(object sender, EventArgs e)
        {

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
