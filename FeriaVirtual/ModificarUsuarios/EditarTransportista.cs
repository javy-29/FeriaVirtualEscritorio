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
    public partial class EditarTransportista : Form
    {
        Transportista trans = new Transportista();

        public EditarTransportista()
        {
            InitializeComponent();
        }

        OracleConnection Conn = new OracleConnection("DATA SOURCE = xe ;PASSWORD = 1234 ;USER ID = FeriaV");

        public void ModificarTransportista(ref Transportista trans)
        {
            trans.ID_TRANSP = Convert.ToInt32(txtEditarIdTransportista.Text);
            trans.RUT_TRANSP = txtEditarRutTransportista.Text;
            trans.NOMBRE_TRANSP = txtEditarNombreTransportista.Text;
            trans.APELLIDOP_TRANSP = txtEditarApellidoPaternoTransp.Text;
            trans.APELLIDOM_TRANSP = txtEditarApellidoMaternoTransp.Text;
            trans.CORREO_TRASP = txtEditarCorreoTranps.Text;
            trans.TELEFONO_TRANSO = Convert.ToInt32(txtEditarTelefonoTransp.Text);
            trans.PATENTE_VEHICULO = txtEditarPatenteTransp.Text;
            trans.CAPACIDAD_CARGA = Convert.ToInt32(txtEditarCapacidadCarga.Text);
            trans.REFRIGERACION = Convert.ToString(comboBoxEditarRefrigeracion.Text);
            trans.PASS_TRANSP = txtEditarContraseñaTransp.Text;
            trans.ROL_ID_ROL = Convert.ToString(comboBoxEditarRol.Text);
        }

        private void btnModificarTransportista_Click(object sender, EventArgs e)
        {
            Transportista trans = new Transportista();

            ModificarTransportista (ref trans);
            try
            {
                if (trans.Modificar() == 1)
                {
                    MessageBox.Show("El usuario se modifico correctamente");
                    Conn.Close();
                    this.Close();
                }
                else if (trans.Modificar() == 0)
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
