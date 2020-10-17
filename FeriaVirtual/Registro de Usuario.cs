using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace FeriaVirtual
{
    public partial class Registro_de_Usuario : Form
    {
        public Registro_de_Usuario()
        {
            InitializeComponent();
        }

        private void btnCerrarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        OracleConnection Conn = new OracleConnection("DATA SOURCE = xe ;PASSWORD = 1234 ;USER ID = FeriaV");

        private void AbrirFormularioUsuarios<MiPanel2>() where MiPanel2 : Form, new()
        {
            Form formulario;
            formulario = panelRegistroUsuarios.Controls.OfType<MiPanel2>().FirstOrDefault();//busca en la coleccion el formulario 
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiPanel2();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelRegistroUsuarios.Controls.Add(formulario);
                panelRegistroUsuarios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }


        private void btnClienteUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormularioUsuarios<RegistroCliente>();
            Conn.Close();
        }

        private void btnProductores_Click(object sender, EventArgs e)
        {
            AbrirFormularioUsuarios<RegistroProductores>();
        }

        private void btnTransportista_Click(object sender, EventArgs e)
        {
            AbrirFormularioUsuarios<RegistroTransportista>();
        }

        private void btnConsultor_Click(object sender, EventArgs e)
        {
            AbrirFormularioUsuarios<RegistrarConsultor>();
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            AbrirFormularioUsuarios<RegistroAdministrador>();
        }
    }
}
