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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void ventaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ventaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automovilesDataSet);

        }

        private void Ventas_Load(object sender, EventArgs e)
        {
         
            //Eliminar todo los datos temporales 1
            this.articulos_ventasTableAdapter.eliminartemporal();
            this.ventaTableAdapter.Eliminartemporal();
            // TODO: esta línea de código carga datos en la tabla 'automovilesDataSet.codigo' Puede moverla o quitarla según sea necesario.
            this.codigoTableAdapter.codigo(this.automovilesDataSet.codigo);
            // TODO: esta línea de código carga datos en la tabla 'automovilesDataSet1.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.automovilesDataSet1.Cliente);
            // TODO: esta línea de código carga datos en la tabla 'automovilesDataSet.Articulos_ventas' Puede moverla o quitarla según sea necesario.
            this.articulos_ventasTableAdapter.Fill(this.automovilesDataSet.Articulos_ventas);
            // TODO: esta línea de código carga datos en la tabla 'automovilesDataSet.Articulos' Puede moverla o quitarla según sea necesario.
            this.articulosTableAdapter.Fill(this.automovilesDataSet.Articulos);

            // TODO: esta línea de código carga datos en la tabla 'automovilesDataSet.Marca' Puede moverla o quitarla según sea necesario.
            this.marcaTableAdapter.Fill(this.automovilesDataSet.Marca);
            total_con_articulosTextBox.Text = "0";
            marcacomboBox.SelectedIndex = -1;
            ArticuloscomboBox1.SelectedIndex = -1;
            Clientecombo.SelectedIndex = -1;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.modelosTableAdapter.verpormarca(this.automovilesDataSet.Modelos, marcacomboBox.Text);
                this.detalle_completoTableAdapter.verpormodeloymarca(this.automovilesDataSet.Detalle_completo, Convert.ToInt32(ModelocomboBox.SelectedValue));
            }
            catch
            {
                
            }
            }

        private void ModelocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.detalle_completoTableAdapter.verpormodeloymarca(this.automovilesDataSet.Detalle_completo,Convert.ToInt32(ModelocomboBox.SelectedValue));
        }
            catch
            {
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.detalle_completoTableAdapter.Fill(this.automovilesDataSet.Detalle_completo);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.detalle_completoTableAdapter.verpormodeloymarca(this.automovilesDataSet.Detalle_completo, 0);
            }
            catch
            {

            }
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
            marcacomboBox.SelectedIndex = -1;
            ArticuloscomboBox1.SelectedIndex = -1;
            Clientecombo.SelectedIndex = -1;
        }
        int n=0;
        private void button3_Click(object sender, EventArgs e)
        {
            if (IDserietextbox.Text == "") { MessageBox.Show("Porfavol selecione un veiculo."); return; }
            if(n==0)
            {

            if (MessageBox.Show("Esta seguro en esta selecion: "+marcacomboBox.Text+ " "+ModelocomboBox.Text+ ". Serie: "+serieTextBox.Text+ "?" , "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                detalle_completoDataGridView.Enabled = false;
                marcacomboBox.Enabled = false;
                ModelocomboBox.Enabled = false;
                    n = 1;
                }
            }
            try
            {
                this.codigoTableAdapter.codigo(this.automovilesDataSet.codigo);
                if (codigotexbox.Text == "")
                {
                     // crea datos de registro en venta con codigo 1 para datos temporales
                    this.ventaTableAdapter.InsertQuery(login.Nombre,int.Parse(IDserietextbox.Text));

                    //Presentar codigo
                    this.codigoTableAdapter.codigo(this.automovilesDataSet.codigo);

                    //crear tablas de articulos con codigo 1
                    int costo = int.Parse(Costoarticulo.Text);
                    this.articulos_ventasTableAdapter.Insertararticulos(int.Parse(IDventa.Text),ArticuloscomboBox1.Text,costo);

                    this.articulos_ventasTableAdapter.Fill(automovilesDataSet.Articulos_ventas);
                 
                }
                else
                    {
                    int costo = int.Parse(Costoarticulo.Text);
                    this.articulos_ventasTableAdapter.Insertararticulos(int.Parse(IDventa.Text), ArticuloscomboBox1.Text, costo);
                    this.articulos_ventasTableAdapter.Fill(automovilesDataSet.Articulos_ventas);
                    }
                }
            catch (Exception ex)
            {
                MessageBox.Show("Error en articulos");
                MessageBox.Show("Error: " + ex);
                
                return;
            }

            int total = (int)this.articulos_ventasTableAdapter.suma();
            int precio_carro = int.Parse(preciocarrotextBox1.Text);
            int carro_articulo = total + precio_carro;
            total_con_articulosTextBox.Text = Convert.ToString( carro_articulo);
            totaltext.Text = Convert.ToString(total);
        }

        private void iDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModelocomboBox_TextUpdate(object sender, EventArgs e)
        {
          
        }

        private void button5_Click(object sender, EventArgs e)
        {

            detalle_completoDataGridView.Enabled = true;
            marcacomboBox.Enabled = true;
            ModelocomboBox.Enabled = true;
            //Eliminar todo los datos temporales 1
            this.articulos_ventasTableAdapter.eliminartemporal();
            this.ventaTableAdapter.Eliminartemporal();
            n = 0;
            marcacomboBox.SelectedIndex = -1;
            ArticuloscomboBox1.SelectedIndex = -1;
            Clientecombo.SelectedIndex = -1;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                this.articulos_ventasTableAdapter.borrararticulo(ArticuloscomboBox1.Text);
                this.articulos_ventasTableAdapter.Fill(automovilesDataSet.Articulos_ventas);
            }
            catch
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cliente cli = new cliente();
            this.Hide();
            cli.ShowDialog();
            this.Show();
            this.clienteTableAdapter.Fill(this.automovilesDataSet1.Cliente);
        }

        int p = 0;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (total_con_articulosTextBox.Text == "") { total_con_articulosTextBox.Text="0"; return; }
            if (serieTextBox.Text == "") { MessageBox.Show("Selecione un carro."); return; }
            if (Clientecombo.Text == "") { MessageBox.Show("Selecione un cliente."); return; }
            if (Formapagocombo.Text == "") { MessageBox.Show("Selecione una forma de pago."); return; }

            this.codigoTableAdapter.codigo(this.automovilesDataSet.codigo);

            if (codigotexbox.Text == "")
            {
                if (MessageBox.Show("No quiere agregarle algun articulo al carro?", "AVISO DE VENTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                { ArticuloscomboBox1.Focus(); return; }
            }

            if (codigotexbox.Text == "")
            {
                // crea datos de registro en venta con codigo 1 para datos temporales
                this.ventaTableAdapter.InsertQuery(login.Nombre, int.Parse(IDserietextbox.Text));
                p = 1;
            }




            try { 
            this.ventaTableAdapter.Vender_update(Clientecombo.Text, Formapagocombo.Text, fechadeentregadateTimePicker1.Text, fechaventadateTimePicker2.Text, int.Parse(total_con_articulosTextBox.Text));
                if (p == 0)
                {
                    this.articulos_ventasTableAdapter.cambiotemp_articuloenventa();
                    p = 0;
                }
                MessageBox.Show("Carro vendido");
                this.articulos_ventasTableAdapter.Fill(automovilesDataSet.Articulos_ventas);
                //Limpiar luego de vender
                detalle_completoDataGridView.Enabled = true;
                marcacomboBox.Enabled = true;
                ModelocomboBox.Enabled = true;
                preciocarrotextBox1.Text = "0";
                total_con_articulosTextBox.Text = "0";
                p = 0;
                marcacomboBox.SelectedIndex = -1;
                ArticuloscomboBox1.SelectedIndex = -1;
                Clientecombo.SelectedIndex = -1;
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        ctrl.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex);
            }
           
        }

        private void ArticuloscomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void serieLabel1_Click(object sender, EventArgs e)
        {

        }

        private void modeloLabel_Click(object sender, EventArgs e)
        {

        }

        private void marcaLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            verventa ven = new verventa();
            this.Hide();
            ven.ShowDialog();
            this.Show();

        }
    }
}
