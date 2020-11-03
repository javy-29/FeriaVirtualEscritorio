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
    public class ContratoVentaDALC
    {
        OracleConnection conn = new OracleConnection("DATA SOURCE = xe ; PASSWORD = 1234 ;USER ID = FeriaVi");

        public object DatabaseHelper { get; private set; }

        public int Agregar(int id_contrato, int numero_contrato, string fecha_inicio, string fecha_termino, string vigencia, int solicitud_venta)
        {
            conn.Open();
            OracleCommand comando = new OracleCommand("PACK_MANT_CONTRATO_VENTA.SP_AGREGAR_CONTRATO_VENTA", conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("ID_CONT", OracleType.Number).Value = id_contrato;
            comando.Parameters.Add("NUMERO", OracleType.Number).Value = numero_contrato;
            comando.Parameters.Add("FECHA_INICIO", OracleType.NVarChar).Value = fecha_inicio;
            comando.Parameters.Add("FECHA_TERMINO", OracleType.NVarChar).Value = fecha_termino;
            comando.Parameters.Add("VIGEN", OracleType.NVarChar).Value = vigencia;
            comando.Parameters.Add("SOLI_VENTA", OracleType.Number).Value = solicitud_venta;

            int resultado = comando.ExecuteNonQuery();
            return resultado;

        }

        public int Modificar(int id_contrato, int numero_contrato, string fecha_inicio, string fecha_termino, string vigencia)
        {
            conn.Open();
            OracleCommand comando = new OracleCommand("PACK_MANT_CONTRATO_VENTA.SP_MODIFICAR_CONTRATO_VENTA", conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("ID_CONT", OracleType.Number).Value = id_contrato;
            comando.Parameters.Add("NUMERO", OracleType.Number).Value = numero_contrato;
            comando.Parameters.Add("FECHA_INI", OracleType.NVarChar).Value = fecha_inicio;
            comando.Parameters.Add("FECHA_TER", OracleType.NVarChar).Value = fecha_termino;
            comando.Parameters.Add("VIGEN", OracleType.NVarChar).Value = vigencia;

            int resultado = comando.ExecuteNonQuery();
            return resultado;

        }

        public int Eliminar(int numero)
        {
            conn.Open();
            OracleCommand comando = new OracleCommand("PACK_MANT_CONTRATO_VENTA.SP_ELIMINAR_CONTRATO_VENTA", conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("NUMERO", OracleType.Number).Value = numero;
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

    }
}
