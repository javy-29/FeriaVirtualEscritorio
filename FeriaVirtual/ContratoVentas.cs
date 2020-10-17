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
    public partial class ContratoVentas : Form
    {
        public ContratoVentas()
        {
            InitializeComponent();
        }

        private void btnCerrarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ContratoVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetContratoVentas.CONTRATO_VENTA' Puede moverla o quitarla según sea necesario.
            this.cONTRATO_VENTATableAdapter.Fill(this.dataSetContratoVentas.CONTRATO_VENTA);

        }
    }
}
