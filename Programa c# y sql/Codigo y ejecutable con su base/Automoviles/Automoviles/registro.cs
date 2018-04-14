using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automoviles
{
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cliente cli = new cliente();
            this.Hide();
            cli.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vendedor ven = new Vendedor();
            this.Hide();
            ven.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Carro car = new Carro();
            this.Hide();
            car.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Articulos ar = new Articulos();
            this.Hide();
            ar.ShowDialog();
            this.Show();
        }
    }
}
