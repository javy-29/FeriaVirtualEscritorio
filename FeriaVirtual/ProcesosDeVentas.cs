﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeriaVirtual
{
    public partial class ProcesosDeVentas : Form
    {
        public ProcesosDeVentas()
        {
            InitializeComponent();
        }

        private void btnCerrarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProcesosDeVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetProcesosVenta.PROCESO_VENTA' Puede moverla o quitarla según sea necesario.
            this.pROCESO_VENTATableAdapter1.Fill(this.dataSetProcesosVenta.PROCESO_VENTA);
            // TODO: esta línea de código carga datos en la tabla 'dataSetBDA.PROCESO_VENTA' Puede moverla o quitarla según sea necesario.
            this.pROCESO_VENTATableAdapter.Fill(this.dataSetBDA.PROCESO_VENTA);

        }
    }
}
