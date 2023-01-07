using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeÖdevi
{
    public partial class Kayıp : Form
    {
        public Kayıp()
        {
            InitializeComponent();
        }

        private void Kayıp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Talebiniz alındı, yeni kartınız en kısa sürede adresinize iletilecektir.","Başarılı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Talebiniz alındı, yeni kartınız en kısa sürede adresinize iletilecektir.","Başarılı");
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

        private void button9_Click(object sender, EventArgs e)
        {
            Giris grs = new Giris();
            grs.Show();
            grs.Location = new Point(100, 100);
            this.Hide();
        }
    }
}
