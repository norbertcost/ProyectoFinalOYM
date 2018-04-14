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
    public partial class clienteyarticulo : Form
    {
        public clienteyarticulo()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void clienteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {

        }

        private void clienteyarticulo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'automovilesDataSet1.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.automovilesDataSet1.Cliente);
            clientecomboBox1.SelectedIndex = -1;
         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.detalleTableAdapter.Buscar_cliente(this.automovilesDataSet.Detalle,clientecomboBox1.Text);
            this.clienteTableAdapter.Buscacliente(this.automovilesDataSet.Cliente, clientecomboBox1.Text);
            this.articulos_ventasTableAdapter.buscarID(this.automovilesDataSet.Articulos_ventas,0);
            canitdadlabel.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                canitdadlabel.Text = "";
                if (IDlabel.Text == "") { MessageBox.Show("Porfavol selecione un carro"); return; }
                this.articulos_ventasTableAdapter.buscarID(this.automovilesDataSet.Articulos_ventas, int.Parse(IDlabel.Text));
                int total = (int)this.articulos_ventasTableAdapter.IDsuma(int.Parse(IDlabel.Text));
                canitdadlabel.Text = Convert.ToString(total);
            }
            catch
            {
             
            }
        }
    }
}
