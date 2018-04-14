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
    public partial class verventa : Form
    {
        public verventa()
        {
            InitializeComponent();
        }

        private void ventaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void verventa_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'automovilesDataSet.Vendedor' Puede moverla o quitarla según sea necesario.
                this.vendedorTableAdapter.Fill(this.automovilesDataSet.Vendedor);
                // TODO: esta línea de código carga datos en la tabla 'automovilesDataSet.Cliente' Puede moverla o quitarla según sea necesario.
                this.clienteTableAdapter.Fill(this.automovilesDataSet.Cliente);
                // TODO: esta línea de código carga datos en la tabla 'automovilesDataSet.Detalle' Puede moverla o quitarla según sea necesario.
                this.detalleTableAdapter.Venta(this.automovilesDataSet.Detalle);
            }
            catch
            {
                MessageBox.Show("Error en load de formulario.");

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.detalleTableAdapter.Buscar_cliente(this.automovilesDataSet.Detalle, clientecomboBox1.Text);
            }
            catch
            {
                MessageBox.Show("Error intentelo de nuevo.");

            }

        }

        private void vendedorcomboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.detalleTableAdapter.Buscar_vendedor(this.automovilesDataSet.Detalle, vendedorcomboBox2.Text);
            }
            catch
            {
                MessageBox.Show("Error intentelo de nuevo.");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.detalleTableAdapter.Venta(this.automovilesDataSet.Detalle);
        }

        private void detalleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
