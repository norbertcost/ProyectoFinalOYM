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
    public partial class Modelo : Form
    {
        public Modelo()
        {
            InitializeComponent();
        }

        private void modelosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void Modelo_Load(object sender, EventArgs e)
        {
            MARCA.Text = Carro.marcaa;
            // TODO: esta línea de código carga datos en la tabla 'automovilesDataSet.Modelos' Puede moverla o quitarla según sea necesario.
            try
            {
                this.modelosTableAdapter.verpormarca(this.automovilesDataSet.Modelos, Carro.marcaa);
        }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

}

        private void button1_Click(object sender, EventArgs e)
        {

            if (modelotext.Text == "" ) 
                {
                MessageBox.Show("Campo sin informacion.");
                modelotext.Focus();
                return;
            }

            try
                {

                
                    this.modelosTableAdapter.InsertQuery(modelotext.Text, Carro.marcaa);
                this.modelosTableAdapter.verpormarca(this.automovilesDataSet.Modelos, Carro.marcaa);
            }
                catch 
                {
                    MessageBox.Show("Canselado. Dato repetido o marca incorrecta. Regrese y seleciones la marca de nuevo.");
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (modelotext.Text == "")
            {
                MessageBox.Show("Selecione lo que desea eliminar.");
                modelotext.Show();
            }
            else
            {
                try
                {
                    this.modelosTableAdapter.DeleteQuery(modelotext.Text);
                    this.modelosTableAdapter.verpormarca(this.automovilesDataSet.Modelos, Carro.marcaa);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
        }

        private void modelotext_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
