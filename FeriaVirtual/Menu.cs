using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Web.UI.Design.WebControls;

namespace FeriaVirtual
{
    public partial class Menu : Form
    {   
        public Menu()
        {
            InitializeComponent();
            customizeDesing();
        }
        #region CerrarMinimizarMaximizar
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás segura de cerrar la aplicación?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void btnCerrarMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás segura de cerrar la aplicación?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnMinimizarMenu_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region ArrastrarMenu
        //cod para arrastrar el menu 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wHsg, int wParam, int lParam);
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region SubMenu
        //personalizar menu ,oculta el panel 
        private void customizeDesing()
        {
            panelSubMenuUsuarios.Visible = false;
            panelSubMenuVetas.Visible = false;
            //..
        }
        //metodo para ocultar el submenu 
        private void hideSubMenu()
        {
            if (panelSubMenuUsuarios.Visible == true)
                panelSubMenuUsuarios.Visible = false;

            if (panelSubMenuVetas.Visible == true)
                panelSubMenuVetas.Visible = false;
        }
        //metodo para mostrar el subMenu
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        
        private void btnslide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
                MenuVertical.Width = 250;
        }
        #endregion

        #region Usuario
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormularios<Usuario>();
            showSubMenu(panelSubMenuUsuarios);
        }

        private void btnSolicitudRegistro_Click(object sender, EventArgs e)
        {
            AbrirFormularios<Solicitud_de_Registro>();
            hideSubMenu();
        }

        private void btnRegistroUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormularios<Registro_de_Usuario>();
            hideSubMenu();
        }
        #endregion

        #region Ventas
        private void btnProcesoVenta_Click(object sender, EventArgs e)
        {
          //  this.Controls.Add(this.panelContenedor);
            showSubMenu(this.panelContenedor);
            showSubMenu(panelSubMenuVetas);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormularios<SolicitudVentas>();
            hideSubMenu();
        }





        #endregion

        //panel principal para los hijos 
        private void AbrirFormularios<MiPanel>()where MiPanel : Form, new()
        {
            Form formulario;
            formulario = panelContenedor.Controls.OfType<MiPanel>().FirstOrDefault();//busca en la coleccion el formulario 
            //si el formulario/instancia no existe
            if(formulario == null) {
                formulario = new MiPanel();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormularios<ContratoProductores>();
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormularios<ContratoVentas>();
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormularios<ProcesosDeVentas>();
            hideSubMenu();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormularios<Reportes>();
            hideSubMenu();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            AbrirFormularios<Productos>();
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormularios<Subasta>();
            hideSubMenu();
        }
    }

}
