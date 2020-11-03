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
        OracleConnection Conn = new OracleConnection("DATA SOURCE = xe ;PASSWORD = 1234 ;USER ID = FeriaVi");

        private bool Editar = false;

        public Usuario()
        {
            InitializeComponent();
        }

        private void btnCerrarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClienteIn_Click(object sender, EventArgs e)
        {
            Conn.Open();
            OracleCommand comando = new OracleCommand("MostrarClienteInterno", Conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("listarCliIN", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adap = new OracleDataAdapter();
            adap.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adap.Fill(tabla);
            dgvListar.DataSource = tabla;

            Conn.Close();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Conn.Open();
            OracleCommand comando = new OracleCommand("MostrarClienteExterno", Conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("listarCliEX", OracleType.Cursor).Direction = ParameterDirection.Output;

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

        EditarConsultores modificarConsul = new EditarConsultores();
        EditarAdmin modificarAdmin = new EditarAdmin();

        private void btnModificarUsuarios_Click(object sender, EventArgs e)
        {

            if (dgvListar.SelectedRows.Count > 0)
            {
                
               
            }
            else
                MessageBox.Show("Seleccione una fila");
        }



        private void btnModificarProduc_Click(object sender, EventArgs e)
        {
            if (dgvListar.SelectedRows.Count > 0)
            {
               
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void btnModificarTransportista_Click(object sender, EventArgs e)
        {
            if (dgvListar.SelectedRows.Count > 0)
            {
                
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        private void btnModificarConsultor_Click(object sender, EventArgs e)
        {
            if (dgvListar.SelectedRows.Count > 0)
            {
                modificarConsul.txtEditarRutConsultor.Text = dgvListar.CurrentRow.Cells["RUT_CONSULTOR"].Value.ToString();
                modificarConsul.txtEditarNombreConsultor.Text = dgvListar.CurrentRow.Cells["NOM_CONSULTOR"].Value.ToString();
                modificarConsul.txtEditarApellidoPaternoConsultor.Text = dgvListar.CurrentRow.Cells["APELLIDOP_CONSULTOR"].Value.ToString();
                modificarConsul.txtEditarApellidoMaternoConsultor.Text = dgvListar.CurrentRow.Cells["APELLIDOM_CONSULTOR"].Value.ToString();
                modificarConsul.txtEditarTelefonoConsultor.Text = dgvListar.CurrentRow.Cells["NUMERO_CONSULTOR"].Value.ToString();
                modificarConsul.txtEditarCorreoConsultor.Text = dgvListar.CurrentRow.Cells["CORREO_CONSULTOR"].Value.ToString();
                modificarConsul.txtEditarContraseñaConsultor.Text = dgvListar.CurrentRow.Cells["PASS_CONSULTOR"].Value.ToString();
                modificarConsul.textEditarConsulto.Text = dgvListar.CurrentRow.Cells["ROL_ID_ROL"].Value.ToString();
                
                modificarConsul.txtEditarRutConsultor.Enabled = false;
                modificarConsul.textEditarConsulto.Enabled = false;
                modificarConsul.ShowDialog();
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        

        private void btnModificarAdmin_Click(object sender, EventArgs e)
        {
            if (dgvListar.SelectedRows.Count > 0)
            {
                modificarAdmin.txtEditarRutAdmin.Text = dgvListar.CurrentRow.Cells["RUT_ADMIN"].Value.ToString();
                modificarAdmin.txtEditarNombreAdmin.Text = dgvListar.CurrentRow.Cells["NOM_ADMIN"].Value.ToString();
                modificarAdmin.txtEditarApellidoPAdmin.Text = dgvListar.CurrentRow.Cells["APELLIDOP_ADMIN"].Value.ToString();
                modificarAdmin.txtEditarApellidoMAdmin.Text = dgvListar.CurrentRow.Cells["APELLIDOM_ADMIN"].Value.ToString();
                modificarAdmin.txtEditarNumeroAdmin.Text = dgvListar.CurrentRow.Cells["TELEFONO_ADMIN"].Value.ToString();
                modificarAdmin.txtEditarCorreoAdmin.Text = dgvListar.CurrentRow.Cells["CORREO_ADMIN"].Value.ToString();
                modificarAdmin.txtEditarContraseñaAdmin.Text = dgvListar.CurrentRow.Cells["PASS_ADMIN"].Value.ToString();
                modificarAdmin.comboBoxEditarRol.Text = dgvListar.CurrentRow.Cells["ROL_ID_ROL"].Value.ToString();
                         
                modificarAdmin.txtEditarRutAdmin.Enabled = false;
                modificarAdmin.comboBoxEditarRol.Enabled = false;
                modificarAdmin.ShowDialog();
            }
            else
                MessageBox.Show("Seleccione una fila");
        }



        

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            ClienteEx clienex = new ClienteEx();

            if (dgvListar.SelectedRows.Count > 0)
            {
                string dato = dgvListar.CurrentRow.Cells["RUT_CLIENTE"].Value.ToString();
                clienex.RUT_CLIENTE = dato;
                if (clienex.Eliminar() == 1)
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
                string dato = dgvListar.CurrentRow.Cells["RUT_PRODUC"].Value.ToString();
                produc.RUT_PRODUC = dato;
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
                string dato = dgvListar.CurrentRow.Cells["RUT_TRANSP"].Value.ToString();
                transp.RUT_TRANSP = dato;
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
                string dato = dgvListar.CurrentRow.Cells["RUT_CONSULTOR"].Value.ToString();
                consul.RUT_CONSULTOR = dato;
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
                string dato = dgvListar.CurrentRow.Cells["RUT_ADMIN"].Value.ToString();
                admin.RUT_ADMIN = dato;
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

        private void btnEliminarCliLocal_Click(object sender, EventArgs e)
        {
            Cliente clien = new Cliente();

            if (dgvListar.SelectedRows.Count > 0)
            {
                string dato = dgvListar.CurrentRow.Cells["RUT_CLI_EX"].Value.ToString();
                clien.rut_cli_ex = dato;
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
    }

}
