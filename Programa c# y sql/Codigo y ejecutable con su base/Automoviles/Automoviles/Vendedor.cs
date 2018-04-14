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
    public partial class Vendedor : Form
    {
        public Vendedor()
        {
            InitializeComponent();
        }
        int n = 0;
        private void vendedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automovilesDataSet);

        }

        private void Vendedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'automovilesDataSet.Vendedor' Puede moverla o quitarla según sea necesario.
            this.vendedorTableAdapter.Fill(this.automovilesDataSet.Vendedor);

        }

        public void msj()
            {

            MessageBox.Show("Se encuentra campo sin datos.");
            n = 1;
        }

        public void detetar()
        {

            if (Nombretex.Text == "") { Nombretex.Focus(); msj(); return; }
            if (cedulatex.Text == "") { cedulatex.Focus(); msj(); return; }
            if (cargotex.Text == "") { cargotex.Focus(); msj(); return; }
            if (passtext.Text == "") { passtext.Focus(); msj(); return; }
            if (Edadtext.Text == "") { Edadtext.Focus(); msj(); return; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = 0;
            detetar();
            if (n == 1) { return; }
            try
            {
                this.vendedorTableAdapter.InsertQuery(Nombretex.Text,cedulatex.Text,cargotex.Text,passtext.Text,int.Parse(Edadtext.Text));
                this.vendedorTableAdapter.Fill(this.automovilesDataSet.Vendedor);
                MessageBox.Show("Agredado correctamente.");
            }
            catch 
            {
                MessageBox.Show("No se permite nombre duplicado" );
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n = 0;
            detetar();
            if (n == 1) { return; }
            try
            {
                this.vendedorTableAdapter.UpdateQuery(Nombretex.Text, cedulatex.Text, cargotex.Text, passtext.Text, int.Parse(Edadtext.Text),idnombre.Text);
                this.vendedorTableAdapter.Fill(this.automovilesDataSet.Vendedor);
                MessageBox.Show("Editado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Nombretex.Text == "") { Nombretex.Focus(); MessageBox.Show("Selecione lo que desea eliminar."); return; }
                this.vendedorTableAdapter.DeleteQuery(Nombretex.Text);
                this.vendedorTableAdapter.Fill(this.automovilesDataSet.Vendedor);
                MessageBox.Show("Borrado correctamente.");
            }           
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
}
}
