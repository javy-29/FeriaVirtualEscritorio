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
    public partial class RegistroAdministrador : Form
    {
        public RegistroAdministrador()
        {
            InitializeComponent();
        }

        private void btnCerrarUsuarioRegistro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIdAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRutAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidoPAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidoMAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumeroAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistroAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void txtCorreoAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseñaAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        OracleConnection Conn = new OracleConnection("DATA SOURCE = xe ;PASSWORD = 1234 ;USER ID = FeriaV");

        public void CargarAdministrador(ref Administrador admin)
        {
            admin.ID_ADMIN = Convert.ToInt32(txtIdAdmin.Text);
            admin.RUT_ADMIN = txtRutAdmin.Text;
            admin.NOM_ADMIN = txtNombreAdmin.Text;
            admin.APELLIDOP_ADMIN = txtApellidoPAdmin.Text;
            admin.APELLIDOM_ADMIN = txtApellidoMAdmin.Text;
            admin.TELEFONO_ADMIN = Convert.ToInt32(txtNumeroAdmin.Text);
            admin.CORREO_ADMIN = txtCorreoAdmin.Text;
            admin.PASS_ADMIN = txtContraseñaAdmin.Text;
            admin.ROL_ID_ROL = comboBoxRol.Text;

        }

        private void btnRegistrarAdmin_Click(object sender, EventArgs e)
        {
            Administrador admin = new Administrador();


            CargarAdministrador(ref admin);
            try
            {
                if (admin.Agregar() == 1)
                {
                    MessageBox.Show("El usuario se creo correctamente");
                    Conn.Close();
                }
                else if (admin.Agregar() == 0)
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
