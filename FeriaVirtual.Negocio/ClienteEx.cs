using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FeriaVirtual.DALC;

namespace FeriaVirtual
{
    public class ClienteEx
    {
        public string RUT_CLIENTE { get; set; }
        public string NOM_CLIENTE { get; set; }
        public string APELLIDOP_CLIENTE { get; set; }
        public string APELLIDOM_CLIENTE { get; set; }
        public string DIRECCION_RESIDENCIAL { get; set; }
        public string CIUDAD_RESIDENCIAL { get; set; }
        public string CORREO_ELECTRONICO { get; set; }
        public int NUMERO_TELEFONICO { get; set; }
        public string PASS_CLIENTE { get; set; }
        public string ROL_ID_ROL { get; set; }


        public int Eliminar()
        {
            return new ClienteExDALC().Eliminar(this.RUT_CLIENTE);
        }





















    }
}
