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
using FeriaVirtual.ModificarUsuarios;
using FeriaVirtual.Negocio;


namespace FeriaVirtual
{
    public partial class Usuario : Form
    {
        OracleConnection Conn = new OracleConnection("DATA SOURCE = xe ;PASSWORD = 1234 ;USER ID = FeriaV");

        private bool Editar = false;

        public Usuario()
        {
            InitializeComponent();
        }

        private void btnCerrarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnCliente_Click(object sender, EventArgs e)
        {
            Conn.Open();
            OracleCommand comando = new OracleCommand("MostrarCliente", Conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("listar", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adap = new OracleDataAdapter();
            adap.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adap.Fill(tabla);
            dgvListar.DataSource = tabla;

            Conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conn.Open();
            OracleCommand comando = new OracleCommand("MostrarProductores", Conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("listarP", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adap = new OracleDataAdapter();
            adap.SelectCommand = comando;
            DataTable tabla1 = new DataTable();
            adap.Fill(tabla1);
            dgvListar.DataSource = tabla1;

            Conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conn.Open();
            OracleCommand comando = new OracleCommand("MostrarTransportista", Conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("listarT", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adap = new OracleDataAdapter();
            adap.SelectCommand = comando;
            DataTable tabla2 = new DataTable();
            adap.Fill(tabla2);
            dgvListar.DataSource = tabla2;

            Conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Conn.Open();
            OracleCommand comando = new OracleCommand("MostrarConsultor", Conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("listarC", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adap = new OracleDataAdapter();
            adap.SelectCommand = comando;
            DataTable tabla3 = new DataTable();
            adap.Fill(tabla3);
            dgvListar.DataSource = tabla3;

            Conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Conn.Open();
            OracleCommand comando = new OracleCommand("MostrarAdministrador", Conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("listarA", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adap = new OracleDataAdapter();
            adap.SelectCommand = comando;
            DataTable tabla4 = new DataTable();
            adap.Fill(tabla4);
            dgvListar.DataSource = tabla4;

            Conn.Close();
        }

        EditarCliente modificar = new EditarCliente();
        EditarProductores modificarProd = new EditarProductores();
        EditarTransportista modificarTrans = new EditarTransportista();
        EditarConsultores modificarConsul = new EditarConsultores();
        EditarAdmin modificarAdmin = new EditarAdmin();

        private void btnModificarUsuarios_Click(object sender, EventArgs e)
        {

            if (dgvListar.SelectedRows.Count > 0)
            {
                
                modificar.txtEditarIdUsuario.Text = dgvListar.CurrentRow.Cells["ID_CLIENTE"].Value.ToString();
                modificar.txtEditarRutCliente.Text = dgvListar.CurrentRow.Cells["RUT_CLIENTE"].Value.ToString();
                modificar.txtEditarNombreCliente.Text = dgvListar.CurrentRow.Cells["NOM_CLIENTE"].Value.ToString();
                modificar.txtEditarApellidoPCliente.Text = dgvListar.CurrentRow.Cells["APELLIDOP_CLIENTE"].Value.ToString();
                modificar.txtEditarApellidoMCliente.Text = dgvListar.CurrentRow.Cells["APELLIDOM_CLIENTE"].Value.ToString();
                modificar.txtEditarDireccionCliente.Text = dgvListar.CurrentRow.Cells["DIRECCION_RESIDENCIAL"].Value.ToString();
                modificar.txtEditarCiudadCliente.Text = dgvListar.CurrentRow.Cells["CIUDAD_RESIDENCIAL"].Value.ToString();
                modificar.txtEditarCorreoCliente.Text = dgvListar.CurrentRow.Cells["CORREO_ELECTRONICO"].Value.ToString();
                modificar.txtEditarTelefonoCliente.Text = dgvListar.CurrentRow.Cells["NUMERO_TELEFONICO"].Value.ToString();
                modificar.comboBoxEditarClienteExterno.Text = dgvListar.CurrentRow.Cells["CLIENTE_EXTRANJERO"].Value.ToString();
                modificar.txtEditarContraseñaCliente.Text = dgvListar.CurrentRow.Cells["PASS_CLIENTE"].Value.ToString();
                modificar.comboBoxEditarRol.Text = dgvListar.CurrentRow.Cells["ROL_ID_ROL"].Value.ToString();
                
                modificar.txtEditarIdUsuario.Enabled = false;
                modificar.txtEditarRutCliente.Enabled = false;
                modificar.ShowDialog();
            }
            else
                MessageBox.Show("Seleccione una fila");
        }



        private void btnModificarProduc_Click(object sender, EventArgs e)
        {
            if (dgvListar.SelectedRows.Count > 0)
            {
                modificarProd.txtIdEditarUsuarioProductor.Text = dgvListar.CurrentRow.Cells["ID_PRODUC"].Value.ToString();
                modificarProd.txtEditarRutProductor.Text = dgvListar.CurrentRow.Cells["RUT_PRODUC"].Value.ToString();
                modificarProd.txtEditarNombreProductor.Text = dgvListar.CurrentRow.Cells["NOM_PRODUC"].Value.ToString();
                modificarProd.txtEditarApellidoPProductor.Text = dgvListar.CurrentRow.Cells["APELLIDOP_PRODUC"].Value.ToString();
                modificarProd.txtEditarApellidoMProductor.Text = dgvListar.CurrentRow.Cells["APELLIDOM_PRODUC"].Value.ToString();
                modificarProd.txtEditarDireccionProductor.Text = dgvListar.CurrentRow.Cells["DIRECCION_PRODUC"].Value.ToString();
                modificarProd.txtEditarCiudadProductor.Text = dgvListar.CurrentRow.Cells["CIUDAD_PRODUC"].Value.ToString();
                modificarProd.txtEditarCorreoProductor.Text = dgvListar.CurrentRow.Cells["CORREO_PRODUC"].Value.ToString();
                modificarProd.txtEditarTelefonoProductor.Text = dgvListar.CurrentRow.Cells["TELEFONO_PRODUC"].Value.ToString();
                modificarProd.txtEditarContraseñaProductor.Text = dgvListar.CurrentRow.Cells["PASS_PRODUC"].Value.ToString();
                modificarProd.comboBoxEditarRol.Text = dgvListar.CurrentRow.Cells["ROL_ID_ROL"].Value.ToString();
                
                modificarProd.txtIdEditarUsuarioProductor.Enabled = false;
                modificarProd.txtEditarRutProductor.Enabled = false;
                modificarProd.txtEditarContratoProductor.Enabled = false;
                modificarProd.comboBoxEditarRol.Enabled = false;
                modificarProd.ShowDialog();
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void btnModificarTransportista_Click(object sender, EventArgs e)
        {
            if (dgvListar.SelectedRows.Count > 0)
            {
                modificarTrans.txtEditarIdTransportista.Text = dgvListar.CurrentRow.Cells["ID_TRANSP"].Value.ToString();
                modificarTrans.txtEditarRutTransportista.Text = dgvListar.CurrentRow.Cells["RUT_TRANSP"].Value.ToString();
                modificarTrans.txtEditarNombreTransportista.Text = dgvListar.CurrentRow.Cells["NOMBRE_TRANSP"].Value.ToString();
                modificarTrans.txtEditarApellidoPaternoTransp.Text = dgvListar.CurrentRow.Cells["APELLIDOP_TRANSP"].Value.ToString();
                modificarTrans.txtEditarApellidoMaternoTransp.Text = dgvListar.CurrentRow.Cells["APELLIDOM_TRANSP"].Value.ToString();
                modificarTrans.txtEditarCorreoTranps.Text = dgvListar.CurrentRow.Cells["CORREO_TRASP"].Value.ToString();
                modificarTrans.txtEditarTelefonoTransp.Text = dgvListar.CurrentRow.Cells["TELEFONO_TRANSO"].Value.ToString();
                modificarTrans.txtEditarPatenteTransp.Text = dgvListar.CurrentRow.Cells["PATENTE_VEHICULO"].Value.ToString();
                modificarTrans.txtEditarCapacidadCarga.Text = dgvListar.CurrentRow.Cells["CAPACIDAD_CARGA"].Value.ToString();
                modificarTrans.comboBoxEditarRefrigeracion.Text = dgvListar.CurrentRow.Cells["REFRIGERACION"].Value.ToString();
                modificarTrans.txtEditarContraseñaTransp.Text = dgvListar.CurrentRow.Cells["PASS_TRANSP"].Value.ToString();
                modificarTrans.comboBoxEditarRol.Text = dgvListar.CurrentRow.Cells["ROL_ID_ROL"].Value.ToString();

                modificarTrans.txtEditarIdTransportista.Enabled = false;
                modificarTrans.txtEditarRutTransportista.Enabled = false;
                modificarTrans.comboBoxEditarRol.Enabled = false;
                modificarTrans.ShowDialog();
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void btnModificarConsultor_Click(object sender, EventArgs e)
        {
            if (dgvListar.SelectedRows.Count > 0)
            {
                modificarConsul.txtEditarIdConsultor.Text = dgvListar.CurrentRow.Cells["ID_CONSULTOR"].Value.ToString();
                modificarConsul.txtEditarRutConsultor.Text = dgvListar.CurrentRow.Cells["RUT_CONSULTOR"].Value.ToString();
                modificarConsul.txtEditarNombreConsultor.Text = dgvListar.CurrentRow.Cells["NOM_CONSULTOR"].Value.ToString();
                modificarConsul.txtEditarApellidoPaternoConsultor.Text = dgvListar.CurrentRow.Cells["APELLIDOP_CONSULTOR"].Value.ToString();
                modificarConsul.txtEditarApellidoMaternoConsultor.Text = dgvListar.CurrentRow.Cells["APELLIDOM_CONSULTOR"].Value.ToString();
                modificarConsul.txtEditarTelefonoConsultor.Text = dgvListar.CurrentRow.Cells["NUMERO_CONSULTOR"].Value.ToString();
                modificarConsul.txtEditarCorreoConsultor.Text = dgvListar.CurrentRow.Cells["CORREO_CONSULTOR"].Value.ToString();
                modificarConsul.txtEditarContraseñaConsultor.Text = dgvListar.CurrentRow.Cells["PASS_CONSULTOR"].Value.ToString();
                modificarConsul.comboBoxEditarRol.Text = dgvListar.CurrentRow.Cells["ROL_ID_ROL"].Value.ToString();
                
                modificarConsul.txtEditarIdConsultor.Enabled = false;
                modificarConsul.txtEditarRutConsultor.Enabled = false;
                modificarConsul.comboBoxEditarRol.Enabled = false;
                modificarConsul.ShowDialog();
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        

        private void btnModificarAdmin_Click(object sender, EventArgs e)
        {
            if (dgvListar.SelectedRows.Count > 0)
            {
                modificarAdmin.txtEditarIdAdmin.Text = dgvListar.CurrentRow.Cells["ID_ADMIN"].Value.ToString();
                modificarAdmin.txtEditarRutAdmin.Text = dgvListar.CurrentRow.Cells["RUT_ADMIN"].Value.ToString();
                modificarAdmin.txtEditarNombreAdmin.Text = dgvListar.CurrentRow.Cells["NOM_ADMIN"].Value.ToString();
                modificarAdmin.txtEditarApellidoPAdmin.Text = dgvListar.CurrentRow.Cells["APELLIDOP_ADMIN"].Value.ToString();
                modificarAdmin.txtEditarApellidoMAdmin.Text = dgvListar.CurrentRow.Cells["APELLIDOM_ADMIN"].Value.ToString();
                modificarAdmin.txtEditarNumeroAdmin.Text = dgvListar.CurrentRow.Cells["TELEFONO_ADMIN"].Value.ToString();
                modificarAdmin.txtEditarCorreoAdmin.Text = dgvListar.CurrentRow.Cells["CORREO_ADMIN"].Value.ToString();
                modificarAdmin.txtEditarContraseñaAdmin.Text = dgvListar.CurrentRow.Cells["PASS_ADMIN"].Value.ToString();
                modificarAdmin.comboBoxEditarRol.Text = dgvListar.CurrentRow.Cells["ROL_ID_ROL"].Value.ToString();
                         
                modificarAdmin.txtEditarIdAdmin.Enabled = false;
                modificarAdmin.txtEditarRutAdmin.Enabled = false;
                modificarAdmin.comboBoxEditarRol.Enabled = false;
                modificarAdmin.ShowDialog();
            }
            else
                MessageBox.Show("Seleccione una fila");
        }



        

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            Cliente clien = new Cliente();

            if (dgvListar.SelectedRows.Count > 0)
            {
                string dato = dgvListar.CurrentRow.Cells["ID_CLIENTE"].Value.ToString();
                clien.ID_CLIENTE = Convert.ToInt32(dato);
                if (clien.Eliminar() == 1)
                {
                    MessageBox.Show("Usuario Eliminado");
                    Conn.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el usuario");
                }
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void btnEliminarProductor_Click(object sender, EventArgs e)
        {
            Productor produc = new Productor();

            if (dgvListar.SelectedRows.Count > 0)
            {
                string dato = dgvListar.CurrentRow.Cells["ID_PRODUC"].Value.ToString();
                produc.ID_PRODUC = Convert.ToInt32(dato);
                if (produc.Eliminar() == 1)
                {
                    MessageBox.Show("Usuario Eliminado");
                    Conn.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el usuario");
                }
            }
            else
                MessageBox.Show("Seleccione una fila");

        }

        private void btnEliminarTrasnportista_Click(object sender, EventArgs e)
        {
            Transportista transp = new Transportista();

            if (dgvListar.SelectedRows.Count > 0)
            {
                string dato = dgvListar.CurrentRow.Cells["ID_TRANSP"].Value.ToString();
                transp.ID_TRANSP = Convert.ToInt32(dato);
                if (transp.Eliminar() == 1)
                {
                    MessageBox.Show("Usuario Eliminado");
                    Conn.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el usuario");
                }
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void btnEliminarConsultor_Click(object sender, EventArgs e)
        {
            Consultor consul = new Consultor();

            if (dgvListar.SelectedRows.Count > 0)
            {
                string dato = dgvListar.CurrentRow.Cells["ID_CONSULTOR"].Value.ToString();
                consul.ID_CONSULTOR = Convert.ToInt32(dato);
                if (consul.Eliminar() == 1)
                {
                    MessageBox.Show("Usuario Eliminado");
                    Conn.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el usuario");
                }
            }
            else
                MessageBox.Show("Seleccione una fila");
        }


        private void btnEliminarAdministrador_Click(object sender, EventArgs e)
        {
            Administrador admin = new Administrador();

            if (dgvListar.SelectedRows.Count > 0)
            {
                string dato = dgvListar.CurrentRow.Cells["ID_ADMIN"].Value.ToString();
                admin.ID_ADMIN = Convert.ToInt32(dato);
                if (admin.Eliminar() == 1)
                {
                    MessageBox.Show("Usuario Eliminado");
                    Conn.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el usuario");
                }
            }
            else
                MessageBox.Show("Seleccione una fila");
        }
    }

}
