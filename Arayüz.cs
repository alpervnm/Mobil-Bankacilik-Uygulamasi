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

namespace ProjeÖdevi
{
    public partial class Arayüz : Form
    {
        public Arayüz()
        {
            InitializeComponent();
        }

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
            Application.Exit();

        }

        private void Arayüz_Load(object sender, EventArgs e)
        {

        }
    }
}
