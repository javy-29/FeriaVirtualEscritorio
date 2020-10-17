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

namespace FeriaVirtual
{
    public partial class RegistroTransportista : Form
    {
        public RegistroTransportista()
        {
            InitializeComponent();
        }

        private void btnCerrarUsuarioRegistro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIdTransportista_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRutTransportista_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreTransportista_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidoPaternoTransp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidoMaternoTransp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreoTranps_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefonoTransp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPatenteTransp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCapacidadCarga_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxRefrigeración_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseñaTransp_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        OracleConnection Conn = new OracleConnection("DATA SOURCE = xe ;PASSWORD = 1234 ;USER ID = FeriaV");


        public void CargarTransportista(ref Transportista transp)
        {
            transp.ID_TRANSP = Convert.ToInt32(txtIdTransportista.Text);
            transp.RUT_TRANSP = txtRutTransportista.Text;
            transp.NOMBRE_TRANSP = txtNombreTransportista.Text;
            transp.APELLIDOP_TRANSP = txtApellidoPaternoTransp.Text;
            transp.APELLIDOM_TRANSP = txtApellidoMaternoTransp.Text;
            transp.CORREO_TRASP = txtCorreoTranps.Text;
            transp.TELEFONO_TRANSO = Convert.ToInt32(txtTelefonoTransp.Text);
            transp.PATENTE_VEHICULO = txtPatenteTransp.Text;
            transp.CAPACIDAD_CARGA = Convert.ToInt32(txtCapacidadCarga.Text);
            transp.REFRIGERACION = Convert.ToString(comboBoxRefrigeracion.Text);
            transp.PASS_TRANSP = txtContraseñaTransp.Text;
            transp.ROL_ID_ROL = comboBoxRol.Text;


        }

        private void btnRegistrarTransportista_Click(object sender, EventArgs e)
        {
            Transportista trans = new Transportista();


            CargarTransportista(ref trans);
            try
            {
                if (trans.Agregar() == 1)
                {
                    MessageBox.Show("El usuario se creo correctamente");
                    Conn.Close();
                }
                else if (trans.Agregar() == 0)
                {
                    MessageBox.Show("El usuario ya existe o no se ingresaron todos los datos");
                    Conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de Conexion: " + ex);
                Conn.Close();
            }
        }

        private void comboBoxRefrigeracion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
