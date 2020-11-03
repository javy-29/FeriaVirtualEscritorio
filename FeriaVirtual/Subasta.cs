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

namespace FeriaVirtual
{
    public partial class Subasta : Form
    {
        OracleConnection Conn = new OracleConnection("DATA SOURCE = xe ;PASSWORD = 1234 ;USER ID = FeriaVi");

        public Subasta()
        {
            InitializeComponent();
        }

        private void btnCerrarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Subasta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetBDA.SUBASTA' Puede moverla o quitarla según sea necesario.

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 

        }

        private void btnActualizarSubasta_Click(object sender, EventArgs e)
        {
            Conn.Open();
            OracleCommand comando = new OracleCommand("MostrarSubasta", Conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("listarSu", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adap = new OracleDataAdapter();
            adap.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adap.Fill(tabla);
            dgvSubasta.DataSource = tabla;
        }
    }
}
