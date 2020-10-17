using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
using FeriaVirtual.Negocio;
using FeriaVirtual.DALC;
using System.Reflection;


namespace FeriaVirtual
{
    public partial class Solicitud_de_Registro : Form
    {
        OracleConnection Conn = new OracleConnection("DATA SOURCE = xe ;PASSWORD = 1234 ;USER ID = FeriaV");

        public Solicitud_de_Registro()
        {
            InitializeComponent();
        }

        private void btnCerrarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizarRegistro_Click(object sender, EventArgs e)
        {
            Conn.Open();
            OracleCommand comando = new OracleCommand("MostrarRegistro", Conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("listarRegistro", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adap = new OracleDataAdapter();
            adap.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adap.Fill(tabla);
            dgvSolicitudRegistro.DataSource = tabla;

            Conn.Close();
        }

        private void btnEliminarSolicitud_Click(object sender, EventArgs e)
        {

            SolicitudRegistro soli = new SolicitudRegistro();

            

            if (dgvSolicitudRegistro.SelectedRows.Count > 0)
            {
                string dato = dgvSolicitudRegistro.CurrentRow.Cells["RUT_PERSONA"].Value.ToString();
                soli.RUT_PERSONA = dato;

                if (soli.Eliminar() == 1)
                {
                    MessageBox.Show("Solicitud  Eliminada");
                    Conn.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la solicitud");
                }
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void dgvSolicitudRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
