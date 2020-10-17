using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FeriaVirtual.DALC;

namespace FeriaVirtual.Negocio
{
    public class Consultor
    {
        public int ID_CONSULTOR { get; set; }
        public string RUT_CONSULTOR { get; set; }
        public string NOM_CONSULTOR { get; set; }
        public string APELLIDOP_CONSULTOR { get; set; }
        public string APELLIDOM_CONSULTOR { get; set; }
        public string CORREO_CONSULTOR { get; set; }
        public int NUMERO_CONSULTOR { get; set; }
        public string PASS_CONSULTOR { get; set; }
        public string ROL_ID_ROL { get; set; }

        public int Agregar()
        {
            return new ConsultorDALC().Agregar(this.ID_CONSULTOR, this.RUT_CONSULTOR, this.NOM_CONSULTOR, this.APELLIDOP_CONSULTOR, this.APELLIDOM_CONSULTOR, this.CORREO_CONSULTOR, this.NUMERO_CONSULTOR, this.PASS_CONSULTOR, this.ROL_ID_ROL);
        }

        public int Modificar()
        {
            return new ConsultorDALC().Modificar(this.ID_CONSULTOR, this.NOM_CONSULTOR, this.APELLIDOP_CONSULTOR, this.APELLIDOM_CONSULTOR, this.CORREO_CONSULTOR, this.NUMERO_CONSULTOR, this.PASS_CONSULTOR, this.ROL_ID_ROL);
        }

        public int Eliminar()
        {
            return new ConsultorDALC().Eliminar(this.ID_CONSULTOR);
        }

    }
}
