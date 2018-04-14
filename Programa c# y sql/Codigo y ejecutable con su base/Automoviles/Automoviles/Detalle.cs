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
    public partial class Detalle : Form
    {
        public Detalle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verventa ven = new verventa();
            this.Hide();
            ven.ShowDialog();
            this.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            carroventa carven = new carroventa();
            this.Hide();
            carven.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clienteyarticulo cliear = new clienteyarticulo();
            this.Hide();
            cliear.ShowDialog();
            this.Show();
        }
    }
}
