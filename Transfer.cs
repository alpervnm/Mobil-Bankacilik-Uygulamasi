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
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjeÖdevi
{
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand com = new SqlCommand();
        DataSet ds = new DataSet();


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
            this.Hide(); ;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        public int Para2;
        void Oku()
        {
            DataTable dt = new DataTable();
            con = new SqlConnection("Data Source = ALPER; Initial Catalog = BankaProje; Integrated Security = True");
            da = new SqlDataAdapter("Select * From MusteriBilgi where HesapNo = " + textBox1.Text + "", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "0");
            dt = ds.Tables[0];
            con.Close();

            Para2 = Convert.ToInt32(dt.Rows[0]["ParaMiktarı"].ToString());
        }

        SqlConnection baglanti = new SqlConnection("Data Source = ALPER; Initial Catalog = BankaProje; Integrated Security = True");
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
            if (Arayüz.Hesap != textBox1.Text)
            {
                
                try
                {
                    Oku();
                    int a = Convert.ToInt32(textBox3.Text);
                    int b = Para2 + a;
                    int c = Arayüz.Para - a;

                    if (c > 0)
                    {
                        baglanti.Open();

                        //Gönderilen Hesap
                        SqlCommand komutguncelle = new SqlCommand("update MusteriBilgi set ParaMiktarı = @k1 where HesapNo = @k2", baglanti);
                        komutguncelle.Parameters.AddWithValue("@k2", textBox1.Text);
                        komutguncelle.Parameters.AddWithValue("@k1", b);
                        komutguncelle.ExecuteNonQuery();


                        //Gönderici Hesap
                        SqlCommand komut = new SqlCommand("update MusteriBilgi set ParaMiktarı = @k1 where HesapNo = @k2", baglanti);
                        komut.Parameters.AddWithValue("@k2", Arayüz.Hesap);
                        komut.Parameters.AddWithValue("@k1", c);
                        komut.ExecuteNonQuery();

                        baglanti.Close();
                        MessageBox.Show("İşleminiz başarıyla gerçekleşmiştir.", "Başarılı");
                    }
                    else
                    {
                        MessageBox.Show("Hesabınızda yeterli miktarda para yok!", "Uyarı");
                    }

                }
                catch
                {
                    MessageBox.Show("Lütfen Bilgileri Doğru Giriniz!");
                }

               
            }
            else
            {
                MessageBox.Show("Kendi Hesabınıza para gönderemezsiniz!","Uyarı");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Giris grs = new Giris();
            grs.Show();
            grs.Location = new Point(100, 100);
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Transfer_Load(object sender, EventArgs e)
        {

        }
    }
}
