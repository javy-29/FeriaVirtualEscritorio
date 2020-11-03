using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FeriaVirtual.DALC;

namespace FeriaVirtual.Negocio
{
   public class Transportista
    {
        public string RUT_TRANSP { get; set; }
        public string NOMBRE_TRANSP { get; set; }
        public string APELLIDOP_TRANSP { get; set; }
        public string APELLIDOM_TRANSP { get; set; }
        public string CORREO_TRASP { get; set; }
        public int TELEFONO_TRANSO { get; set; }
        public string PATENTE_VEHICULO { get; set; }
        public int CAPACIDAD_CARGA { get; set; }
        public String REFRIGERACION { get; set; }
        public string PASS_TRANSP { get; set; }
        public string ROL_ID_ROL { get; set; }

       
        public int Eliminar()
        {
            return new TransportistaDALC().Eliminar(this.RUT_TRANSP);
        }





    }
}
