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
    public partial class Carro : Form
    {
        public Carro()
        {
            InitializeComponent();
        }

        private void carroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automovilesDataSet);

        }

        private void Carro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'automovilesDataSet.Detalle_completo' Puede moverla o quitarla según sea necesario.
            this.detalle_completoTableAdapter.Fill(this.automovilesDataSet.Detalle_completo);

           
            this.marcaTableAdapter.Fill(this.automovilesDataSet.Marca);
            // TODO: esta línea de código carga datos en la tabla 'automovilesDataSet.Carro' Puede moverla o quitarla según sea necesario.
            this.carroTableAdapter.Fill(this.automovilesDataSet.Carro);
            this.modelosTableAdapter.verpormarca(this.automovilesDataSet.Modelos, marcacombox.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(modelocomboBox2.SelectedValue) == "")

            {
                MessageBox.Show("Selecione un modelo.");
                modelocomboBox2.Focus();
                return;


            }



            
           int idmodelo = int.Parse( modelocomboBox2.SelectedValue.ToString());
            try
            {
                this.detalle_completoTableAdapter.InsertQuery(serieTextBox.Text, precioTextBox.Text, descuentoTextBox.Text, potenciaTextBox.Text, cilindroTextBox.Text,equipamientoTextBox.Text,extraTextBox.Text, idmodelo);
                this.detalle_completoTableAdapter.Fill(this.automovilesDataSet.Detalle_completo);
                MessageBox.Show("Agregado correctamente. ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
        
            try
            {
                this.detalle_completoTableAdapter.DeleteQuery(int.Parse(IDCARRO.Text));
                this.detalle_completoTableAdapter.Fill(this.automovilesDataSet.Detalle_completo);
                MessageBox.Show("Eliminado correctamente. ");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            try
            {
                this.detalle_completoTableAdapter.UpdateQueri(serieTextBox.Text,precioTextBox.Text,descuentoTextBox.Text,potenciaTextBox.Text,cilindroTextBox.Text,equipamientoTextBox.Text,extraTextBox.Text, int.Parse(IDCARRO.Text));
                this.detalle_completoTableAdapter.Fill(this.automovilesDataSet.Detalle_completo);
                MessageBox.Show("Editado correctamente. ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        public static string marcaa;
        private void button1_Click(object sender, EventArgs e)
        {
            

            marcaa = marcacombox.Text;
            if (marcaa == "")
            {
                MessageBox.Show("Selecione una marca.");
                marcacombox.Show();
                return;
            }
            Modelo mod = new Modelo();
            
            mod.ShowDialog();
            this.modelosTableAdapter.verpormarca(this.automovilesDataSet.Modelos, marcacombox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Marca mar = new Marca();

            mar.ShowDialog();
            this.marcaTableAdapter.Fill(this.automovilesDataSet.Marca);
        }

        private void marcacomboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clilindroTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void marcacombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                this.modelosTableAdapter.verpormarca(this.automovilesDataSet.Modelos, marcacombox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void detalle_completoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
        }

        private void IDCARRO_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
