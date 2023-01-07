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
    public partial class forget : Form
    {
        public forget()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand com = new SqlCommand();
        DataSet ds = new DataSet();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                con = new SqlConnection("Data Source = ALPER; Initial Catalog = BankaProje; Integrated Security = True");
                da = new SqlDataAdapter("Select * From MusteriBilgi where Tc = " + textBox3.Text + "", con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds);
                dt = ds.Tables[0];
                string isim = dt.Rows[0]["İsim"].ToString().Trim().Replace(" ", string.Empty);
                string telefon = dt.Rows[0]["Telefon"].ToString().Trim().Replace(" ", string.Empty);
                string Dogum = dt.Rows[0]["DoğumYeri"].ToString().Trim().Replace(" ", string.Empty);



                if (isim == textBox7.Text && telefon == textBox4.Text && Dogum == textBox9.Text)
                {
                    MessageBox.Show("ŞİFRENİZ: " + dt.Rows[0]["Şifre"].ToString(), "Doğrulama başarılı");

                }
                else
                {
                    MessageBox.Show("Böyle bir kullanıcı bulunmamaktadır", "Hatalı giriş");
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Hatalı giriş yaptınız!");
            }
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Giris grs = new Giris();
            grs.Show();
            grs.Location = new Point(100, 100);
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
    }
}
