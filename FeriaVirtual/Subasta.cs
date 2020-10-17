using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeriaVirtual
{
    public partial class Subasta : Form
    {
        public Subasta()
        {
            InitializeComponent();
        }

        private void btnCerrarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Subasta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetBDA.SUBASTA' Puede moverla o quitarla según sea necesario.
            this.sUBASTATableAdapter.Fill(this.dataSetBDA.SUBASTA);

        }
    }
}
