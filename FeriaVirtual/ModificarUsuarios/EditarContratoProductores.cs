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
using FeriaVirtual.Negocio;

namespace FeriaVirtual.ModificarUsuarios
{
    public partial class EditarContratoProductores : Form
    {
        Contrato contra = new Contrato();

        public EditarContratoProductores()
        {
            InitializeComponent();
        }

        OracleConnection Conn = new OracleConnection("DATA SOURCE = xe ;PASSWORD = 1234 ;USER ID = FeriaVi");

        public void ModificarAdministrador(ref Contrato contra)
        {
            contra.ID_CONTRA = Convert.ToInt32(txtEditarIdContrato.Text);
            contra.NUME_CONTRATO = Convert.ToInt32(txtEditarNumeroContrato.Text);

            DateTime fecha = (DateTime)dtpEditarFechaInicio.Value.Date;
            string formato = "dd/MM/yyyy";
            contra.FECHA_INICIO = fecha.ToString(formato);

            DateTime fechater = (DateTime)dtpEditarFechaTermino.Value.Date;
            string formatoter = "dd/MM/yyyy";
            contra.FECHA_VENCIMIENTO = fechater.ToString(formatoter);

            contra.VIGENCIA = Convert.ToString(comboBoxEditarVigencia.Text);

        }


        private void btnRegistrarContrato_Click(object sender, EventArgs e)
        {
            Contrato contra = new Contrato();

            ModificarAdministrador(ref contra);
            try
            {
                if (contra.Modificar() == 1)
                {
                    MessageBox.Show("El contrato se modifico correctamente");
                    Conn.Close();
                    this.Close();
                }
                else if (contra.Modificar() == 0)
                {
                    MessageBox.Show("El contrato ya existe ");
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
