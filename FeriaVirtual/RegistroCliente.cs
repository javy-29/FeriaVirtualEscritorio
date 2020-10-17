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

namespace FeriaVirtual
{
    public partial class RegistroCliente : Form
    {
        public RegistroCliente()
        {
            InitializeComponent();
        }

        public void btnCerrarUsuarioRegistro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void txtRutCliente_TextChanged(object sender, EventArgs e)
        {
        
        }

        public void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtApellidoPCliente_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtApellidoMCliente_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtDireccionCliente_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtCiudadCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void txtCorreoCliente_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtTelefonoCliente_TextChanged(object sender, EventArgs e)
        {
        }

        public void radioButtonClienteInterno_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void radioButtonClienteExterno_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void txtContraseñaCliente_TextChanged(object sender, EventArgs e)
        {

        }

        OracleConnection Conn = new OracleConnection("DATA SOURCE = xe ;PASSWORD = 1234 ;USER ID = FeriaV");

        public void comboBoxRol_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        public void CargarCliente(ref Cliente clien)
        {
            clien.ID_CLIENTE = Convert.ToInt32(txtIdUsuario.Text);
            clien.RUT_CLIENTE = txtRutCliente.Text;
            clien.NOM_CLIENTE = txtNombreCliente.Text;
            clien.APELLIDOP_CLIENTE = txtApellidoPCliente.Text;
            clien.APELLIDOM_CLIENTE = txtApellidoMCliente.Text;
            clien.DIRECCION_RESIDENCIAL = txtDireccionCliente.Text;
            clien.CIUDAD_RESIDENCIAL =txtCiudadCliente.Text;
            clien.CORREO_ELECTRONICO = txtCorreoCliente.Text;
            clien.NUMERO_TELEFONICO = Convert.ToInt32(txtTelefonoCliente.Text);
            clien.CLIENTE_EXTRANJERO = Convert.ToString(comboBoxClienteExterno.Text);
            clien.PASS_CLIENTE = txtContraseñaCliente.Text;
            clien.ROL_ID_ROL = comboBoxRol.Text;

        }

        public void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            Cliente clien = new Cliente();


            CargarCliente(ref clien);
            try
            {
                if (clien.Agregar() == 1)
                {
                    MessageBox.Show("El usuario se creo correctamente");
                    Conn.Close();
                }
                else if (clien.Agregar() == 0)
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

        private void txtIdUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRutCliente_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBoxClienteExterno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
