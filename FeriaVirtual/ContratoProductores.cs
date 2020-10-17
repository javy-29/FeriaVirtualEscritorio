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
    public partial class ContratoProductores : Form
    {
        public ContratoProductores()
        {
            InitializeComponent();
        }
        OracleConnection Conn = new OracleConnection("DATA SOURCE = xe ;PASSWORD = 1234 ;USER ID = FeriaV");


        private void btnCerrarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ContratoProductores_Load(object sender, EventArgs e)
        {

        }

        private void dtpFechaTermino_ValueChanged(object sender, EventArgs e)
        {

        }

        public void CargarContrato(ref Contrato contra)
        {
           
            contra.ID_CONTRA = Convert.ToInt32(txtIdContrato.Text);
            contra.NUME_CONTRATO = Convert.ToInt32(txtNumeroContrato.Text);
            
            DateTime fecha = (DateTime)dtpFechaInicio.Value.Date;
            string formato = "dd/MM/yyyy";
            contra.FECHA_INICIO = fecha.ToString(formato);

            DateTime fechater = (DateTime)dtpFechaTermino.Value.Date;
            string formatoter = "dd/MM/yyyy";
            contra.FECHA_VENCIMIENTO = fechater.ToString(formatoter);
            
            contra.VIGENCIA = Convert.ToString(comboBoxVigencia.Text);

        }
        private void btnRegistrarContrato_Click(object sender, EventArgs e)
        {
            Contrato contra = new Contrato();


            CargarContrato(ref contra);
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Conn.Open();
            OracleCommand comando = new OracleCommand("MostrarContrato", Conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("listarCo", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adap = new OracleDataAdapter();
            adap.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adap.Fill(tabla);
            dgvContrato.DataSource = tabla;

            Conn.Close();
        }

        EditarContratoProductores editarContra = new EditarContratoProductores();
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvContrato.SelectedRows.Count > 0)
            {
                editarContra.txtEditarIdContrato.Text = dgvContrato.CurrentRow.Cells["ID_CONTRA"].Value.ToString();
                editarContra.txtEditarNumeroContrato.Text = dgvContrato.CurrentRow.Cells["NUME_CONTRATO"].Value.ToString();
                editarContra.dtpEditarFechaInicio.Text = dgvContrato.CurrentRow.Cells["FECHA_INICIO"].Value.ToString();
                editarContra.dtpEditarFechaTermino.Text = dgvContrato.CurrentRow.Cells["FECHA_VENCIMIENTO"].Value.ToString();
                editarContra.comboBoxEditarVigencia.Text = dgvContrato.CurrentRow.Cells["VIGENCIA"].Value.ToString();

                editarContra.txtEditarIdContrato.Enabled = false;
                editarContra.txtEditarNumeroContrato.Enabled = false;
                editarContra.dtpEditarFechaInicio.Enabled = false;
                editarContra.ShowDialog();
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Contrato contra = new Contrato();

            if (dgvContrato.SelectedRows.Count > 0)
            {
                string dato = dgvContrato.CurrentRow.Cells["NUME_CONTRATO"].Value.ToString();
                contra.NUME_CONTRATO = Convert.ToInt32(dato);
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
