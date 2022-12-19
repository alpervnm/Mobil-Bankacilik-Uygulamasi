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
    public partial class Sifre : Form
    {
        public Sifre()
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
            Ayarlar ayar1 = new Ayarlar();
            ayar1.Show();
            ayar1.Location = new Point(100, 100);
            this.Hide();
        }
    }
}
