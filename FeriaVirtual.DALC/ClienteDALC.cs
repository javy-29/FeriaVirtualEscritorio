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
    public class ClienteDALC
    {
        OracleConnection conn = new OracleConnection("DATA SOURCE = xe ; PASSWORD = 1234 ;USER ID = FeriaVi");

        public object DatabaseHelper { get; private set; }

        public int Eliminar(string rut_cli_ex)
        {
            conn.Open();
            OracleCommand comando = new OracleCommand("PACK_MANT_CLIENTE_INTERNO.SP_ELIMINAR_CLIENTE_INTERNO", conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("RUT", OracleType.NVarChar).Value = rut_cli_ex;
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }










































    }
}
