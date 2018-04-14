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
    public partial class cliente : Form
    {
        public cliente()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automovilesDataSet);

        }

        private void cliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'automovilesDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.automovilesDataSet.Cliente);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.clienteTableAdapter.InsertQuery(nombretext.Text,niftext.Text,domiciliotext.Text);
                this.clienteTableAdapter.Fill(this.automovilesDataSet.Cliente);
                MessageBox.Show("Agregado correctamente. ");
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
                this.clienteTableAdapter.DeleteQuery(nombretext.Text);
                this.clienteTableAdapter.Fill(this.automovilesDataSet.Cliente);
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
                this.clienteTableAdapter.UpdateQuery(nombretext.Text,niftext.Text,domiciliotext.Text,nombreedit.Text);
                this.clienteTableAdapter.Fill(this.automovilesDataSet.Cliente);
                MessageBox.Show("Editado correctamente. ");
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
