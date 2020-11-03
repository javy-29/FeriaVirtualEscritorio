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
    public partial class RegistrarConsultor : Form
    {
        public RegistrarConsultor()
        {
            InitializeComponent();
        }

        private void btnCerrarUsuarioRegistro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRutConsultor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreConsultor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidoMaternoConsultor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccionConsultor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefonoConsultor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreoConsultor_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtApellidoPaternoConsultor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseñaConsultor_TextChanged(object sender, EventArgs e)
        {

        }
        OracleConnection Conn = new OracleConnection("DATA SOURCE = xe ;PASSWORD = 1234 ;USER ID = FeriaVi");

        public void CargarConsultor(ref Consultor consul)
        {
            consul.RUT_CONSULTOR = txtRutConsultor.Text;
            consul.NOM_CONSULTOR = txtNombreConsultor.Text;
            consul.APELLIDOP_CONSULTOR = txtApellidoPaternoConsultor.Text;
            consul.APELLIDOM_CONSULTOR = txtApellidoMaternoConsultor.Text;
            consul.CORREO_CONSULTOR = txtCorreoConsultor.Text;
            consul.NUMERO_CONSULTOR = Convert.ToInt32(txtTelefonoConsultor.Text);
            consul.PASS_CONSULTOR = txtContraseñaConsultor.Text;
            consul.ROL_ID_ROL = textConsulto.Text;

        }

        private void btnRegistrarConsultor_Click(object sender, EventArgs e)
        {
            Consultor consul = new Consultor();


            CargarConsultor(ref consul);
            try
            {
                if (consul.Agregar() == 1)
                {
                    MessageBox.Show("El usuario se creo correctamente");
                    Conn.Close();
                }
                else if (consul.Agregar() == 0)
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
    }
}
