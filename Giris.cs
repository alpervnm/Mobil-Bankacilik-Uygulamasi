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
using System.Data.Sql;



namespace ProjeÖdevi
{
    public partial class Giris : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;

        public Giris()
        {
            InitializeComponent();
        }
        public static string şfr;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" && textBox2.Text == "Admin")
            {
                AdminPanel adm = new AdminPanel();
                adm.Show();
                adm.Location = new Point(100, 100);
                this.Hide();

            }
            else
            {
                string user = textBox1.Text;
                string password = textBox2.Text;
                şfr = textBox2.Text;

                con = new SqlConnection("Data Source=ALPER;Initial Catalog=BankaProje;Integrated Security=True");
                com = new SqlCommand();

                con.Open();
                com.Connection = con;
                com.CommandText = "Select * From MusteriBilgi where Tc = '" + textBox1.Text + "'And Şifre = '" + textBox2.Text + "'";
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    Arayüz arayuz1 = new Arayüz();
                    arayuz1.Show();
                    arayuz1.Location = new Point(100, 100);
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Girdiğiniz bilgilere ait kullanıcı bulunmamaktadır.", "Kullanıcı bulunamadı");
                }
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kayit kyt = new Kayit();
            kyt.Show();
            kyt.Location = new Point(100, 100);
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            forget forget = new forget();
            forget.Show();
            forget.Location = new Point(100, 100);
            this.Hide();
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            İletişim İlet = new İletişim();
            İlet.Show();
            İlet.Location = new Point(100, 100);
            this.Hide();

        }
        public static string hsp;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            hsp = textBox1.Text;
        }
    }
}
