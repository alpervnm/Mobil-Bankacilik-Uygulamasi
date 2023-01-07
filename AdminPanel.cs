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
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ProjeÖdevi
{
    public partial class AdminPanel : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=ALPER;Initial Catalog=BankaProje;Integrated Security=True");

        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }


        //Listeleme
        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from MusteriBilgi", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        //Silme
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("Delete From MusteriBilgi where İsim=@ad", baglanti);
            sil.Parameters.AddWithValue("@ad", textBox1.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();
        }

        //Güncelleme
        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("update MusteriBilgi set İsim = @k1 , Soyisim = @k2 , ParaMiktarı = @k3 , HesapNo = @k4 where Soyisim = @k2", baglanti);
            komutguncelle.Parameters.AddWithValue("@k1", textBox1.Text);
            komutguncelle.Parameters.AddWithValue("@k2", textBox2.Text);
            komutguncelle.Parameters.AddWithValue("@k3", textBox3.Text);
            komutguncelle.Parameters.AddWithValue("@k4", textBox4.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Giris grs = new Giris();
            grs.Show();
            grs.Location = new Point(100, 100);
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            string AD = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            string SOYAD = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            string Para = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            string HesapNo = dataGridView1.Rows[secilen].Cells[8].Value.ToString();

            textBox1.Text = AD;
            textBox2.Text = SOYAD;
            textBox3.Text = Para;
            textBox4.Text = HesapNo;
        }
    }
}
