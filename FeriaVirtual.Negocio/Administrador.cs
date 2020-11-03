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
    public class Administrador
    {
        OracleConnection conn = new OracleConnection("DATA SOURCE = xe ; PASSWORD = 1234 ;USER ID = FeriaVi");


     
        public string RUT_ADMIN { get; set; }
        public string NOM_ADMIN { get; set; }
        public string APELLIDOP_ADMIN { get; set; }
        public string APELLIDOM_ADMIN { get; set; }
        public int TELEFONO_ADMIN { get; set; }
        public string CORREO_ADMIN { get; set; }
        public string PASS_ADMIN { get; set; }
        public string ROL_ID_ROL { get; set; }

        
        public bool Login()
        {
            return new AdministradorDALC().Login(this.RUT_ADMIN, this.PASS_ADMIN);
        }
        public int Agregar()
        {
            return new AdministradorDALC().Agregar( this.RUT_ADMIN, this.NOM_ADMIN, this.APELLIDOP_ADMIN, this.APELLIDOM_ADMIN, this.TELEFONO_ADMIN, this.CORREO_ADMIN, this.PASS_ADMIN, this.ROL_ID_ROL);
        }

        public int Modificar()
        {
            return new AdministradorDALC().Modificar(this.RUT_ADMIN, this.NOM_ADMIN, this.APELLIDOP_ADMIN, this.APELLIDOM_ADMIN, this.TELEFONO_ADMIN, this.CORREO_ADMIN, this.PASS_ADMIN);
        }

        public int Eliminar()
        {
            return new AdministradorDALC().Eliminar(this.RUT_ADMIN);
        }




    }

}

