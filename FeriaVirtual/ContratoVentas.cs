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
    public partial class ContratoVentas : Form
    {
        OracleConnection Conn = new OracleConnection("DATA SOURCE = xe ;PASSWORD = 1234 ;USER ID = FeriaVi");

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
            

        }


        ModificarContratoVenta contraVenta = new ModificarContratoVenta();
        private void btnEditarContratoVenta_Click(object sender, EventArgs e)
        {
            if (dgvContratoVenta.SelectedRows.Count > 0)    
            {
                contraVenta.textEditarIdVenta.Text = dgvContratoVenta.CurrentRow.Cells["ID_CONT"].Value.ToString();
                contraVenta.textEditarNumVenta.Text = dgvContratoVenta.CurrentRow.Cells["NUM_CONTRATO_VENTA"].Value.ToString();
                contraVenta.dateTimePickerEditarVenta.Text = dgvContratoVenta.CurrentRow.Cells["FECHA_INICIO"].Value.ToString();
                contraVenta.dateTimePickerEditarVentaTer.Text = dgvContratoVenta.CurrentRow.Cells["FECHA_TERMINO"].Value.ToString();
                contraVenta.comboBoxEditarVigenciaVenta.Text = dgvContratoVenta.CurrentRow.Cells["VIGENCIA"].Value.ToString();
                contraVenta.textEditarSoliVenta.Text = dgvContratoVenta.CurrentRow.Cells["SOLICITUD_VENTA_ID_SOLI"].Value.ToString();

                contraVenta.textEditarIdVenta.Enabled = false;
                contraVenta.textEditarNumVenta.Enabled = false;
                contraVenta.dateTimePickerEditarVenta.Enabled = false;
                contraVenta.textEditarSoliVenta.Enabled = false;
                contraVenta.ShowDialog();
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void btnActualizarContratoVenta_Click(object sender, EventArgs e)
        {
            Conn.Open();
            OracleCommand comando = new OracleCommand("MostrarContratoVenta", Conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("listarContVenta", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adap = new OracleDataAdapter();
            adap.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adap.Fill(tabla);
            dgvContratoVenta.DataSource = tabla;

            Conn.Close();
        }

        private void btnSoliVenta_Click(object sender, EventArgs e)
        {
            Conn.Open();
            OracleCommand comando = new OracleCommand("MostrarSolicitudVenta", Conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("listarSoliVenta", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adap = new OracleDataAdapter();
            adap.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adap.Fill(tabla);
            dgvSoliVentas.DataSource = tabla;

            Conn.Close();
        }
        public void CargarContratoVenta(ref ContratoVenta contraventa)
        {

            contraventa.ID_CONT = Convert.ToInt32(txtIdContratoVenta.Text);
            contraventa.NUM_CONTRATO_VENTA = Convert.ToInt32(txtNumeroVenta.Text);

            DateTime fecha = (DateTime)dtpFechaInicio.Value.Date;
            string formato = "dd/MM/yyyy";
            contraventa.FECHA_INICIO = fecha.ToString(formato);

            DateTime fechater = (DateTime)dtpFechaTermino.Value.Date;
            string formatoter = "dd/MM/yyyy";
            contraventa.FECHA_TERMINO = fechater.ToString(formatoter);

            contraventa.VIGENCIA = Convert.ToString(cmbVigencia.Text);
            contraventa.SOLICITUD_VENTA_ID_SOLI = Convert.ToInt32(txtSoliVenta.Text);

        }

        private void btnRegistrarContratoVenta_Click(object sender, EventArgs e)
        {
            ContratoVenta contra = new ContratoVenta();


            CargarContratoVenta(ref contra);
            try
            {
                if (contra.Agregar() == 1)
                {
                    MessageBox.Show("El contrato se creo correctamente");
                    Conn.Close();
                }
                else if (contra.Agregar() == 0)
                {
                    MessageBox.Show("El contrato ya existe o no se ingresaron todos los datos");
                    Conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Conexion: " + ex);
                Conn.Close();
            }
        }

        private void btnEliminarContratoVenta_Click(object sender, EventArgs e)
        {
            ContratoVenta contra = new ContratoVenta();

            if (dgvContratoVenta.SelectedRows.Count > 0)
            {
                string dato = dgvContratoVenta.CurrentRow.Cells["NUM_CONTRATO_VENTA"].Value.ToString();
                contra.NUM_CONTRATO_VENTA = Convert.ToInt32(dato);
                if (contra.Eliminar() == 1)
                {
                    MessageBox.Show("Contrato Eliminado");
                    Conn.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el contrato");
                }
            }
            else
                MessageBox.Show("Seleccione una fila");
        }
    }
}
