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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            registro reg = new registro();
            this.Hide();
            reg.ShowDialog();
            this.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            Text = "Bienvenido "+ login.Nombre ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ventas ven = new Ventas();
            this.Hide();
            ven.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Detalle deta = new Detalle();
            this.Hide();
            deta.ShowDialog();
            this.Show();
        }
    }
}
