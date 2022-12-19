using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeÖdevi
{
    public partial class Ayarlar : Form
    {
        public Ayarlar()
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
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Sifre sif = new Sifre();
            sif.Show();
            sif.Location = new Point(100, 100);
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            delACC delACC = new delACC();
            delACC.Show();
            delACC.Location = new Point(100, 100);
            this.Hide();
        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OneriSikayet oner = new OneriSikayet();
            oner.Show();
            oner.Location = new Point(100, 100);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kayıp kyp = new Kayıp();
            kyp.Show();
            kyp.Location = new Point(100, 100);
            this.Hide();
        }
    }
}
