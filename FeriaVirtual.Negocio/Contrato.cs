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
    public class Contrato
    {
        OracleConnection conn = new OracleConnection("DATA SOURCE = xe ; PASSWORD = 1234 ;USER ID = FeriaV");


        public int ID_CONTRA { get; set; }
        public int NUME_CONTRATO { get; set; }
        public string FECHA_INICIO{ get; set; }
        public string FECHA_VENCIMIENTO { get; set; }
        public string VIGENCIA { get; set; }

        public int Agregar()
        {
            return new ContratoDALC().Agregar(this.ID_CONTRA, this.NUME_CONTRATO, this.FECHA_INICIO, this.FECHA_VENCIMIENTO, this.VIGENCIA);
    
        }

        public int Modificar()
        {
            return new ContratoDALC().Modificar(this.ID_CONTRA, this.NUME_CONTRATO, this.FECHA_INICIO, this.FECHA_VENCIMIENTO, this.VIGENCIA);

        }

        public int Eliminar()
        {
            return new ContratoDALC().Eliminar(this.NUME_CONTRATO);

        }

    }
}
