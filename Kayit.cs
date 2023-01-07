using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjeÖdevi
{
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }

        private void Kayit_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox8_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Giris grs = new Giris();
            grs.Show();
            grs.Location = new Point(100, 100);
            this.Hide();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ALPER;Initial Catalog=BankaProje;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Length < 11 || textBox5.Text.Length<5)
            {
                MessageBox.Show("Lütfen Zorunlu Alanları Kurala Uygun Doldurun!","Uyarı");
            }
            else
            {
                Random random = new Random();
                int hesap = random.Next(1000, 9999);
                int para = random.Next(2000, 10000);
                baglanti.Open();
                SqlCommand kyt = new SqlCommand("insert into MusteriBilgi (İsim,Soyisim,Tc,Telefon,Şifre,Mail,DoğumTarihi,DoğumYeri,HesapNo,ParaMiktarı) values (@k1,@k2,@k3,@k4,@k5,@k7,@k8,@k9,@k10,@k11)", baglanti);
                kyt.Parameters.AddWithValue("@k1", textBox1.Text);
                kyt.Parameters.AddWithValue("@k2", textBox2.Text);
                kyt.Parameters.AddWithValue("@k3", textBox3.Text);
                kyt.Parameters.AddWithValue("@k4", textBox4.Text);
                kyt.Parameters.AddWithValue("@k5", textBox5.Text);
                kyt.Parameters.AddWithValue("@k7", textBox7.Text);
                kyt.Parameters.AddWithValue("@k8", textBox8.Text);
                kyt.Parameters.AddWithValue("@k9", textBox9.Text);
                kyt.Parameters.AddWithValue("@k10", hesap);
                kyt.Parameters.AddWithValue("@k11", para);

                kyt.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kayıt başarıyla tamamlandı!");

            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
