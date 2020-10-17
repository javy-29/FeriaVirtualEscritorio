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
        OracleConnection conn = new OracleConnection("DATA SOURCE = xe ; PASSWORD = 1234 ;USER ID = FeriaV");


        public int ID_PRODUC { get; set; }
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


        public int Agregar()
        {
            return new ProductorDALC().Agregar(this.ID_PRODUC, this.RUT_PRODUC, this.NOM_PRODUC, this.APELLIDOP_PRODUC, this.APELLIDOM_PRODUC, this.DIRECCION_PRODUC, this.CIUDAD_PRODUC, this.TELEFONO_PRODUC, this.CORREO_PRODUC, this.PASS_PRODUC,this.ROL_ID_ROL, this.CONTRATO_ID_CONTRA);
        }

        public int Modificar()
        {
            return new ProductorDALC().Modificar(this.ID_PRODUC, this.NOM_PRODUC, this.APELLIDOP_PRODUC, this.APELLIDOM_PRODUC, this.DIRECCION_PRODUC, this.CIUDAD_PRODUC, this.TELEFONO_PRODUC, this.CORREO_PRODUC, this.PASS_PRODUC );
        }
        public int Eliminar()
        {
            return new ProductorDALC().Eliminar(this.ID_PRODUC);
        }


    }
}
