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
    public partial class SolicitudVentas : Form
    {
        public SolicitudVentas()
        {
            InitializeComponent();
        }

        private void btnCerrarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SolicitudVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetSolicitudVentas.SOLICITUD_VENTA' Puede moverla o quitarla según sea necesario.
            this.sOLICITUD_VENTATableAdapter.Fill(this.dataSetSolicitudVentas.SOLICITUD_VENTA);

        }
    }
}
