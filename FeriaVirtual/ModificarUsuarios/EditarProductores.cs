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
    public partial class EditarProductores : Form
    {
        Productor pro = new Productor();

        public EditarProductores()
        {
            InitializeComponent();
        }

        OracleConnection Conn = new OracleConnection("DATA SOURCE = xe ;PASSWORD = 1234 ;USER ID = FeriaV");

       public void ModificarProductor (ref Productor pro)
        {

            pro.ID_PRODUC = Convert.ToInt32(txtIdEditarUsuarioProductor.Text);
            pro.NOM_PRODUC = txtEditarNombreProductor.Text;
            pro.APELLIDOP_PRODUC = txtEditarApellidoPProductor.Text;
            pro.APELLIDOM_PRODUC = txtEditarApellidoMProductor.Text;
            pro.DIRECCION_PRODUC = txtEditarDireccionProductor.Text;
            pro.CIUDAD_PRODUC = txtEditarCiudadProductor.Text;
            pro.TELEFONO_PRODUC = Convert.ToInt32(txtEditarTelefonoProductor.Text);
            pro.CORREO_PRODUC = txtEditarCorreoProductor.Text;
            pro.PASS_PRODUC = txtEditarContraseñaProductor.Text;

        }   
        
        
        private void btnModificarProductor_Click(object sender, EventArgs e)
        {
            Productor pro = new Productor();

            ModificarProductor(ref pro);
            try
            {
                if (pro.Modificar() == 1)
                {
                    MessageBox.Show("El usuario se modifico correctamente");
                    Conn.Close();
                    this.Close();
                }
                else if (pro.Modificar() == 0)
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
