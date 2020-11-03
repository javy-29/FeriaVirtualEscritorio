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
    public partial class ModificarContratoVenta : Form
    {
        ContratoVenta contraVenta = new ContratoVenta();
        public ModificarContratoVenta()
        {
            InitializeComponent();
        }

        OracleConnection Conn = new OracleConnection("DATA SOURCE = xe ;PASSWORD = 1234 ;USER ID = FeriaVi");

        public void ModificarContrato(ref ContratoVenta contraVenta)
        {
            contraVenta.ID_CONT = Convert.ToInt32(textEditarIdVenta.Text);
            contraVenta.NUM_CONTRATO_VENTA = Convert.ToInt32(textEditarNumVenta.Text);

            DateTime fecha = (DateTime)dateTimePickerEditarVenta.Value.Date;
            string formato = "dd/MM/yyyy";
            contraVenta.FECHA_INICIO = fecha.ToString(formato);

            DateTime fechater = (DateTime)dateTimePickerEditarVentaTer.Value.Date;
            string formatoter = "dd/MM/yyyy";
            contraVenta.FECHA_TERMINO = fechater.ToString(formatoter);

            contraVenta.VIGENCIA = Convert.ToString(comboBoxEditarVigenciaVenta.Text);
            contraVenta.SOLICITUD_VENTA_ID_SOLI = Convert.ToInt32(textEditarSoliVenta.Text);
        }

        private void btnRegistrarContratoVenta_Click(object sender, EventArgs e)
        {
            ContratoVenta contraVenta = new ContratoVenta();

            ModificarContrato(ref contraVenta);
            try
            {
                if (contraVenta.Modificar() == 1)
                {
                    MessageBox.Show("El contrato se modifico correctamente");
                    Conn.Close();
                    this.Close();
                }
                else if (contraVenta.Modificar() == 0)
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
