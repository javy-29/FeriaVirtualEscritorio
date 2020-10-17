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
    public partial class RegistroProductores : Form
    {
        public RegistroProductores()
        {
            InitializeComponent();
        }

        private void btnCerrarUsuarioRegistro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIdUsuarioProductor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRutProductor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreProductor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidoPProductor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidoMProductor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCiudadProductor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccionProductor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefonoProductor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreoProductor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseñaProductor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContratoProductor_TextChanged(object sender, EventArgs e)
        {

        }
        OracleConnection Conn = new OracleConnection("DATA SOURCE = xe ;PASSWORD = 1234 ;USER ID = FeriaV");

        public void CargarProductor(ref Productor produc)
        {
            produc.ID_PRODUC = Convert.ToInt32(txtIdUsuarioProductor.Text);
            produc.RUT_PRODUC = txtRutProductor.Text;
            produc.NOM_PRODUC = txtNombreProductor.Text;
            produc.APELLIDOP_PRODUC = txtApellidoPProductor.Text;
            produc.APELLIDOM_PRODUC = txtApellidoMProductor.Text;
            produc.DIRECCION_PRODUC = txtDireccionProductor.Text;
            produc.CIUDAD_PRODUC  = txtCiudadProductor.Text;
            produc.CORREO_PRODUC = txtCorreoProductor.Text;
            produc.TELEFONO_PRODUC = Convert.ToInt32(txtTelefonoProductor.Text);
            produc.PASS_PRODUC = txtContraseñaProductor.Text;
            produc.ROL_ID_ROL = comboBoxRol.Text;
            produc.CONTRATO_ID_CONTRA = Convert.ToInt32(txtContratoProductor.Text);

        }
        private void btnRegistrarProductor_Click(object sender, EventArgs e)
        {
            Productor produc = new Productor();


            CargarProductor(ref produc);
            try
            {
                if (produc.Agregar() == 1)
                {
                    MessageBox.Show("El usuario se creo correctamente");
                    Conn.Close();
                }
                else if (produc.Agregar() == 0)
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

        private void comboBoxRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
