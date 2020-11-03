using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using Microsoft.SqlServer.Server;
using System.CodeDom;
using FeriaVirtual.DALC;
using System.Data.OracleClient;

namespace FeriaVirtual.Negocio
{
    public class ContratoVenta
    {
        OracleConnection conn = new OracleConnection("DATA SOURCE = xe ; PASSWORD = 1234 ;USER ID = FeriaVi");


        public int ID_CONT { get; set; }
        public int NUM_CONTRATO_VENTA { get; set; }
        public string FECHA_INICIO { get; set; }
        public string FECHA_TERMINO { get; set; }
        public string VIGENCIA { get; set; }
        public int SOLICITUD_VENTA_ID_SOLI { get; set; }


        public int Agregar()
        {
            return new ContratoVentaDALC().Agregar(this.ID_CONT, this.NUM_CONTRATO_VENTA, this.FECHA_INICIO, this.FECHA_TERMINO, this.VIGENCIA, this.SOLICITUD_VENTA_ID_SOLI);

        }

        public int Modificar()
        {
            return new ContratoVentaDALC().Modificar(this.ID_CONT, this.NUM_CONTRATO_VENTA, this.FECHA_INICIO, this.FECHA_TERMINO, this.VIGENCIA);

        }

        public int Eliminar()
        {
            return new ContratoVentaDALC().Eliminar(this.NUM_CONTRATO_VENTA);

        }

    }
}