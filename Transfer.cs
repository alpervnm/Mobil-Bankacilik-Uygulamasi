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
    public partial class Transfer : Form
    {
        public Transfer()
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
            Application.Exit();

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
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=ALPER;Initial Catalog=BankaProje;Integrated Security=True");
            com = new SqlCommand();
            con.Open();

            com.Connection = con;
            com.CommandText = "Select HesapNo from MusteriBilgi where HesapNo = '" + textBox1.Text + "'";


            dr = com.ExecuteReader();
            if (Convert.ToInt32(textBox3.Text) < 10000 && Convert.ToInt32(textBox3.Text) > 1000)
            {
                MessageBox.Show("Talebiniz alınmıştır.");

            }
            else
            {
                MessageBox.Show("Hesabınızda yeterli miktarda varlık yok!");
            }


        }
    }
}
