using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Diagnostics.Eventing.Reader;
using System.Data;

namespace FeriaVirtual.DALC
{
    public class ClienteExDALC
    {

        OracleConnection conn = new OracleConnection("DATA SOURCE = xe ; PASSWORD = 1234 ;USER ID = FeriaVi");

        public object DatabaseHelper { get; private set; }

        public int Eliminar(string rut_cliente)
        {
            conn.Open();
            OracleCommand comando = new OracleCommand("PACK_MANT_CLIENTE_EXTERNO.SP_ELIMINAR_CLIENTE_EXTERNO", conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("RUT", OracleType.NVarChar).Value = rut_cliente;
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }






    }
}
