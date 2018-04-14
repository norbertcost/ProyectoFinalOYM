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
    public partial class carroventa : Form
    {
        public carroventa()
        {
            InitializeComponent();
        }

        private void carroventa_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'automovilesDataSet.Detalle_completo' Puede moverla o quitarla según sea necesario.
            this.detalle_completoTableAdapter.Fill(this.automovilesDataSet.Detalle_completo);

        }
    }
}
