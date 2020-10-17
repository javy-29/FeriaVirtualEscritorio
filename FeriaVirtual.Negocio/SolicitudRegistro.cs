using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FeriaVirtual.DALC;

namespace FeriaVirtual.Negocio
{
    public class SolicitudRegistro
    {
        public string RUT_PERSONA { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO_PATERNO { get; set; }
        public string APELLIDO_MATERNO { get; set; }
        public string DIRECCION { get; set; }
        public string CIUDAD { get; set; }
        public string CORREO { get; set; }
        public int TELEFONO { get; set; }
        public string PASS { get; set; }
        public string ROL_PERSONA { get; set; }
        public string INFORMACION_EXTRA { get; set; }


        public int Eliminar()
        {
            return new SolicitudRegistroDALC().Eliminar(this.RUT_PERSONA);
        }
    }
}
