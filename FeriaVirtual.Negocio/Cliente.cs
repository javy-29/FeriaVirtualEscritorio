using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FeriaVirtual.DALC;

namespace FeriaVirtual
{
    public class Cliente
    {

        public string rut_cli_ex { get; set; }
        public string NOM_CLIEN_IN { get; set; }
        public string APELLIDOP_CLIEN_IN { get; set; }
        public string APELLIDOM_CLIENTEIN { get; set; }
        public string DIRECCION_CLIEN_IN { get; set; }
        public string CIUDAD_CLIEN_IN { get; set; }
        public string CORREO_CLIEN_IN { get; set; }
        public int NUMERO_CLIENTE_IN { get; set; }
        public string PASS_CLIENTE { get; set; }
        public string ROL_ID_ROL { get; set; }

       

        public int Eliminar()
        {
            return new ClienteDALC().Eliminar(this.rut_cli_ex);
        }



























    }

  
}
