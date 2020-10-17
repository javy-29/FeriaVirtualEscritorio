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
    public class SolicitudRegistroDALC
    {
        OracleConnection conn = new OracleConnection("DATA SOURCE = xe ; PASSWORD = 1234 ;USER ID = FeriaV");

        public object DatabaseHelper { get; private set; }

        public int Eliminar(string rut)
        {
            conn.Open();
            OracleCommand comando = new OracleCommand("PACK_MANT_SOLICITUD_REGISTRO.SP_ELIMINAR_SOLICITUD_REGISTRO", conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("RUT", OracleType.NVarChar).Value = rut;
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }
    }
}
