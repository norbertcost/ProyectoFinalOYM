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
    public partial class Marca : Form
    {
        public Marca()
        {
            InitializeComponent();
        }

        private void Marca_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'automovilesDataSet.Marca' Puede moverla o quitarla según sea necesario.
            this.marcaTableAdapter.Fill(this.automovilesDataSet.Marca);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text== "")
            {
                MessageBox.Show("Campo sin informacion.");
                textBox1.Show();
            }
            else
            { 
            try
            {


               this.marcaTableAdapter.InsertQuery(textBox1.Text);
                    this.marcaTableAdapter.Fill(this.automovilesDataSet.Marca);
                }
            catch 
            {
                MessageBox.Show("Canselado. Dato repetido.");
            }
        }
    }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Selecione lo que decea eliminar.");
                textBox1.Show();
            }
            else
            {
                try
            {
                this.marcaTableAdapter.DeleteQuery(textBox1.Text);
                    this.marcaTableAdapter.Fill(this.automovilesDataSet.Marca);
                
                }
            catch 
            {
                MessageBox.Show("Esta marca no se puede borrar porque tiene modelo vinculado a ello. Prosiga a borra los modelo vinculado a estar marca. " );
            }
            }
        }
    }
}
