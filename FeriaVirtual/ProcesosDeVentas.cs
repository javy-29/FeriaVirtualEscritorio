using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FeriaVirtual.Negocio;
using System.Data.OracleClient;
using FeriaVirtual.DALC;
using System.Reflection;
using FeriaVirtual.ModificarUsuarios;

namespace FeriaVirtual
{

    public partial class ProcesosDeVentas : Form
    {    
        OracleConnection Conn = new OracleConnection("DATA SOURCE = xe ;PASSWORD = 1234 ;USER ID = FeriaVi");

        public ProcesosDeVentas()
        {
            InitializeComponent();
        }

        private void btnCerrarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProcesosDeVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetProcesosVenta.PROCESO_VENTA' Puede moverla o quitarla según sea necesario.
            // TODO: esta línea de código carga datos en la tabla 'dataSetBDA.PROCESO_VENTA' Puede moverla o quitarla según sea necesario.

        }

        private void btnActualizarProcVenta_Click(object sender, EventArgs e)
        {
            Conn.Open();
            OracleCommand comando = new OracleCommand("MostrarProcVenta", Conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("listarProcVenta", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adap = new OracleDataAdapter();
            adap.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adap.Fill(tabla);
            dgvProcesoVenta.DataSource = tabla;

            Conn.Close();
        }
    }
}
