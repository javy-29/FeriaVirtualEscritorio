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

namespace FeriaVirtual.ModificarUsuarios
{
    public partial class EditarAdmin : Form
    {
        Administrador adm = new Administrador();

        public EditarAdmin()
        {
            InitializeComponent();
        }

        OracleConnection Conn = new OracleConnection("DATA SOURCE = xe ;PASSWORD = 1234 ;USER ID = FeriaVi");

        public void ModificarAdministrador(ref Administrador adm)
        {
            adm.RUT_ADMIN = txtEditarRutAdmin.Text;
            adm.NOM_ADMIN = txtEditarNombreAdmin.Text;
            adm.APELLIDOP_ADMIN = txtEditarApellidoPAdmin.Text;
            adm.APELLIDOM_ADMIN = txtEditarApellidoMAdmin.Text;
            adm.TELEFONO_ADMIN = Convert.ToInt32(txtEditarNumeroAdmin.Text);
            adm.CORREO_ADMIN = txtEditarCorreoAdmin.Text;
            adm.PASS_ADMIN = txtEditarContraseñaAdmin.Text;
            adm.ROL_ID_ROL = comboBoxEditarRol.Text;
        }



        private void btnRegistrarAdmin_Click(object sender, EventArgs e)
        {
            Administrador adm = new Administrador();

            ModificarAdministrador(ref adm);
            try
            {
                if (adm.Modificar() == 1)
                {
                    MessageBox.Show("El usuario se modifico correctamente");
                    Conn.Close();
                    this.Close();
                }
                else if (adm.Modificar() == 0)
                {
                    MessageBox.Show("El usuario ya existe ");
                    Conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de base de datos: " + ex);
                Conn.Close();
            }
        }
    }
}
