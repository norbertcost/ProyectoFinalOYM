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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        public static string Nombre;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.vendedorTableAdapter.validar(this.automovilesDataSet.Vendedor, textBox1.Text, textBox2.Text);


               

                if (textBox1.Text == "")
                {
                    MessageBox.Show("Por favor introduzca su nombre");
                    textBox1.Focus();
                    return;
                }


                if (textBox1.Text == iD_NombreTextBox.Text & textBox2.Text == passTextBox.Text)
                {
                    Nombre = iD_NombreTextBox.Text;
                    menu menu = new menu();
                    this.Hide();
                    menu.ShowDialog();
                    this.Show();

                }
                else
                {

                    MessageBox.Show("Usuario o contrasena incorrecta");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void vendedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automovilesDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
            // TODO: esta línea de código carga datos en la tabla 'automovilesDataSet.Vendedor' Puede moverla o quitarla según sea necesario.
            this.vendedorTableAdapter.Fill(this.automovilesDataSet.Vendedor);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Carro menu = new Carro();
            this.Hide();
            menu.ShowDialog();
            this.Show();
        }
    }
}
