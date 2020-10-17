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

        public int ID_CLIENTE { get; set; }
        public string RUT_CLIENTE { get; set; }
        public string NOM_CLIENTE { get; set; }
        public string APELLIDOP_CLIENTE { get; set; }
        public string APELLIDOM_CLIENTE { get; set; }
        public string DIRECCION_RESIDENCIAL{ get; set; }
        public string CIUDAD_RESIDENCIAL { get; set; }
        public string CORREO_ELECTRONICO { get; set; }
        public int NUMERO_TELEFONICO { get; set; }
        public string CLIENTE_EXTRANJERO { get; set; }
        public string PASS_CLIENTE { get; set; }
        public string ROL_ID_ROL { get; set; }

        public int Agregar()
        {
            return new ClienteDALC().Agregar(this.ID_CLIENTE, this.RUT_CLIENTE, this.NOM_CLIENTE, this.APELLIDOP_CLIENTE, this.APELLIDOM_CLIENTE, this.DIRECCION_RESIDENCIAL, this.CIUDAD_RESIDENCIAL, this.CORREO_ELECTRONICO, this.NUMERO_TELEFONICO, this.CLIENTE_EXTRANJERO, this.PASS_CLIENTE, this.ROL_ID_ROL);
        }

        public int Modificar()
        {
            return new ClienteDALC().Modificar(this.ID_CLIENTE, this.NOM_CLIENTE, this.APELLIDOP_CLIENTE, this.APELLIDOM_CLIENTE, this.DIRECCION_RESIDENCIAL, this.CIUDAD_RESIDENCIAL, this.CORREO_ELECTRONICO, this.NUMERO_TELEFONICO, this.CLIENTE_EXTRANJERO, this.PASS_CLIENTE);
        }


        public int Eliminar()
        {
            return new ClienteDALC().Eliminar(this.ID_CLIENTE);
        }



























    }

  
}
