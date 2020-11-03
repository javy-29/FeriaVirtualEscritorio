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
    public class Productor
    {
        OracleConnection conn = new OracleConnection("DATA SOURCE = xe ; PASSWORD = 1234 ;USER ID = FeriaVi");


        public string RUT_PRODUC { get; set; }
        public string NOM_PRODUC { get; set; }
        public string APELLIDOP_PRODUC { get; set; }
        public string APELLIDOM_PRODUC { get; set; }
        public string DIRECCION_PRODUC { get; set; }
        public string CIUDAD_PRODUC { get; set; }
        public int TELEFONO_PRODUC { get; set; }
        public string CORREO_PRODUC { get; set; }
        public string PASS_PRODUC { get; set; }
        public string ROL_ID_ROL { get; set; }
        public int CONTRATO_ID_CONTRA { get; set; }


        
        public int Eliminar()
        {
            return new ProductorDALC().Eliminar(this.RUT_PRODUC);
        }


    }
}
