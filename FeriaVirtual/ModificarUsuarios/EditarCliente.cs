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
    public partial class EditarCliente : Form
    {
        Cliente cli = new Cliente();

        public EditarCliente()
        {
            InitializeComponent();
        }

        OracleConnection Conn = new OracleConnection("DATA SOURCE = xe ;PASSWORD = 1234 ;USER ID = FeriaV");

        public void ModificarCliente (ref Cliente cli)
        {
            cli.ID_CLIENTE = Convert.ToInt32(txtEditarIdUsuario.Text);
            //cli.RUT_CLIENTE = txtEditarRutCliente.Text;
            cli.NOM_CLIENTE = txtEditarNombreCliente.Text;
            cli.APELLIDOP_CLIENTE = txtEditarApellidoPCliente.Text;
            cli.APELLIDOM_CLIENTE = txtEditarApellidoMCliente.Text;
            cli.DIRECCION_RESIDENCIAL = txtEditarDireccionCliente.Text;
            cli.CIUDAD_RESIDENCIAL = txtEditarCiudadCliente.Text;
            cli.CORREO_ELECTRONICO = txtEditarCorreoCliente.Text;
            cli.NUMERO_TELEFONICO = Convert.ToInt32(txtEditarTelefonoCliente.Text);
            cli.CLIENTE_EXTRANJERO =Convert.ToString(comboBoxEditarClienteExterno.Text);
            cli.PASS_CLIENTE = txtEditarContraseñaCliente.Text;
            //cli.ROL_ID_ROL = Convert.ToInt32(comboBoxEditarRol.Text);
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {

            Cliente cli = new Cliente();

            ModificarCliente(ref cli);
            try
            {
                if (cli.Modificar() == 1)
                {
                    MessageBox.Show("El usuario se modifico correctamente");
                    Conn.Close();
                    this.Close();
                }
                else if (cli.Modificar() == 0)
                {
                    MessageBox.Show("El usuario ya existe ");
                    Conn.Close();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error de base de datos: "+ ex);
                Conn.Close();
            }
        } 
            
        











}
}
