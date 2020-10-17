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
    public class ConsultorDALC
    {
        OracleConnection conn = new OracleConnection("DATA SOURCE = xe ; PASSWORD = 1234 ;USER ID = FeriaV");

        public object DatabaseHelper { get; private set; }

        public int Agregar(int id_consultor, string rutconsul, string nombreconsul, string apellido_paterconsul, string apellido_materconsul, string correoconsul, int telefonoconsul, string passconsul, string rol) 
        {

            conn.Open();
            OracleCommand comando = new OracleCommand("PACK_MANT_CONSULTOR.SP_INGRESAR_CONSULTOR", conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("ID_CONSUL", OracleType.Number).Value = id_consultor;
            comando.Parameters.Add("RUT", OracleType.NVarChar).Value = rutconsul;
            comando.Parameters.Add("NOMBRE", OracleType.NVarChar).Value = nombreconsul;
            comando.Parameters.Add("APELLIDO_PATERNO", OracleType.NVarChar).Value = apellido_paterconsul;
            comando.Parameters.Add("APELLIDO_MATERNO", OracleType.NVarChar).Value = apellido_materconsul;
            comando.Parameters.Add("CORREO", OracleType.NVarChar).Value = correoconsul;
            comando.Parameters.Add("NUMERO", OracleType.Number).Value = telefonoconsul;
            comando.Parameters.Add("PASS", OracleType.NVarChar).Value = passconsul;
            comando.Parameters.Add("ROL", OracleType.NVarChar).Value = rol;


            int resultado = comando.ExecuteNonQuery();
            return resultado;

        }

        public int Modificar(int id_consultor, string nombreconsul, string apellido_paterconsul, string apellido_materconsul, string correoconsul, int telefonoconsul, string passconsul, string rol)
        {

            conn.Open();
            OracleCommand comando = new OracleCommand("PACK_MANT_CONSULTOR.SP_MODIFICAR_CONSULTOR", conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("ID_CONSUL", OracleType.Number).Value = id_consultor;
            comando.Parameters.Add("NOMBRE", OracleType.NVarChar).Value = nombreconsul;
            comando.Parameters.Add("APELLIDO_PATERNO", OracleType.NVarChar).Value = apellido_paterconsul;
            comando.Parameters.Add("APELLIDO_MATERNO", OracleType.NVarChar).Value = apellido_materconsul;
            comando.Parameters.Add("CORREO", OracleType.NVarChar).Value = correoconsul;
            comando.Parameters.Add("NUMERO", OracleType.Number).Value = telefonoconsul;
            comando.Parameters.Add("PASS", OracleType.NVarChar).Value = passconsul;
            comando.Parameters.Add("ROL", OracleType.NVarChar).Value = rol;


            int resultado = comando.ExecuteNonQuery();
            return resultado;

        }
        public int Eliminar(int id_consultor)
        {
            conn.Open();
            OracleCommand comando = new OracleCommand("PACK_MANT_CONSULTOR.SP_ELIMINAR_CONSULTOR", conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("ID_CONSUL", OracleType.Number).Value = id_consultor;
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }







    }
}
