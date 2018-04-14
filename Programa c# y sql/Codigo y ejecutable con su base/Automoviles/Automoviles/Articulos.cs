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
    public partial class Articulos : Form
    {
        public Articulos()
        {
            InitializeComponent();
        }

        private void articulosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.articulosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automovilesDataSet);

        }

        private void Articulos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'automovilesDataSet.Articulos' Puede moverla o quitarla según sea necesario.
            this.articulosTableAdapter.Fill(this.automovilesDataSet.Articulos);
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.articulosTableAdapter.InsertQuery(articuloTextBox.Text,costoTextBox.Text);
                this.articulosTableAdapter.Fill(this.automovilesDataSet.Articulos);
            }
                        
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
  }

        private void button3_Click(object sender, EventArgs e)
        {
            if (iDTextBox.Text == "") { MessageBox.Show("Selecione lo que desea editar."); return; }
            if (articuloTextBox.Text == "") { MessageBox.Show("Campo sin dato.");  articuloTextBox.Focus(); return; }
            if (costoTextBox.Text == "") { MessageBox.Show("Campo sin dato."); costoTextBox.Focus(); return; }

            try
            {
                this.articulosTableAdapter.UpdateQuery(articuloTextBox.Text,costoTextBox.Text,int.Parse(iDTextBox.Text));
                this.articulosTableAdapter.Fill(this.automovilesDataSet.Articulos);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (iDTextBox.Text == "") { MessageBox.Show("Selecione lo que desea borrar."); return; }
            try
            {
                this.articulosTableAdapter.DeleteQuery(int.Parse(iDTextBox.Text));
                this.articulosTableAdapter.Fill(this.automovilesDataSet.Articulos);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
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
    }
}
