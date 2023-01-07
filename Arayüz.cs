using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Security;

namespace ProjeÖdevi
{
    public partial class Arayüz : Form
    {
        public Arayüz()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand com = new SqlCommand();
        DataSet ds = new DataSet();

        private void label1_Click(object sender, EventArgs e)
        {
            Menu menu1 = new Menu();
            menu1.Show();
            menu1.Location = new Point(100, 100);
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu1 = new Menu();
            menu1.Show();
            menu1.Location = new Point(100, 100);
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Uygulamayı kapatmak mı istiyorsunuz?","Uygulama Çıkış", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {

                Application.Exit(); 
            }
            else
            { 

            }
            

        }

        private void Arayüz_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bankaProjeDataSet2.MusteriBilgi' table. You can move, or remove it, as needed.
            Oku();
            this.musteriBilgiTableAdapter2.Fill(this.bankaProjeDataSet2.MusteriBilgi);

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriBilgi where Tc like '%" + Giris.hsp + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = ALPER; Initial Catalog = BankaProje; Integrated Security = True");

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        public static string Hesap;
        public static int Para;
        
        void Oku()
        {
            DataTable dt = new DataTable();
            con = new SqlConnection("Data Source = ALPER; Initial Catalog = BankaProje; Integrated Security = True");
            da = new SqlDataAdapter("Select * From MusteriBilgi where Tc = " + Giris.hsp + "", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds);
            dt = ds.Tables[0];
            con.Close();

            Hesap =dt.Rows[0]["HesapNo"].ToString();
            Para = Convert.ToInt32(dt.Rows[0]["ParaMiktarı"].ToString());
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
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
