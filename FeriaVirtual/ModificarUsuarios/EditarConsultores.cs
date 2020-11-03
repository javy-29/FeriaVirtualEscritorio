using FeriaVirtual.Negocio;
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

namespace FeriaVirtual.ModificarUsuarios
{
    public partial class EditarConsultores : Form
    {
        Consultor consul = new Consultor();

        public EditarConsultores()
        {
            InitializeComponent();
        }

        OracleConnection Conn = new OracleConnection("DATA SOURCE = xe ;PASSWORD = 1234 ;USER ID = FeriaVi");

        public void ModificarCliente(ref Consultor consul)
        {
            consul.RUT_CONSULTOR = txtEditarRutConsultor.Text;
            consul.NOM_CONSULTOR = txtEditarNombreConsultor.Text;
            consul.APELLIDOP_CONSULTOR = txtEditarApellidoPaternoConsultor.Text;
            consul.APELLIDOM_CONSULTOR = txtEditarApellidoMaternoConsultor.Text;
            consul.CORREO_CONSULTOR = txtEditarCorreoConsultor.Text;
            consul.NUMERO_CONSULTOR = Convert.ToInt32(txtEditarTelefonoConsultor.Text);
            consul.PASS_CONSULTOR = txtEditarContraseñaConsultor.Text;
            //consul.ROL_ID_ROL = textEditarConsulto.Text;
        }

        private void btnRegistrarConsultor_Click(object sender, EventArgs e)
        {

            Consultor consul = new Consultor();

            ModificarCliente(ref consul);
            try
            {
                if (consul.Modificar() == 1)
                {
                    MessageBox.Show("El usuario se modifico correctamente");
                    Conn.Close();
                    this.Close();
                }
                else if (consul.Modificar() == 0)
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
