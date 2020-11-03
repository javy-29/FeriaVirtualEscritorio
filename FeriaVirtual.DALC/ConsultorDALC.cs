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
        OracleConnection conn = new OracleConnection("DATA SOURCE = xe ; PASSWORD = 1234 ;USER ID = FeriaVi");

        public object DatabaseHelper { get; private set; }

        public int Agregar( string RUT_CONSULTOR, string NOM_CONSULTOR, string APELLIDOP_CONSULTOR, string APELLIDOM_CONSULTOR,
            string CORREO_CONSULTOR, int NUMERO_CONSULTOR, string PASS_CONSULTOR, string ROL_ID_ROL) 
        {

            conn.Open();
            OracleCommand comando = new OracleCommand("PACK_MANT_CONSULTOR.SP_INGRESAR_CONSULTOR", conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("RUT", OracleType.NVarChar).Value = RUT_CONSULTOR;
            comando.Parameters.Add("NOMBRE", OracleType.NVarChar).Value = NOM_CONSULTOR;
            comando.Parameters.Add("APELLIDO_PATERNO", OracleType.NVarChar).Value = APELLIDOP_CONSULTOR;
            comando.Parameters.Add("APELLIDO_MATERNO", OracleType.NVarChar).Value = APELLIDOM_CONSULTOR;
            comando.Parameters.Add("CORREO", OracleType.NVarChar).Value = CORREO_CONSULTOR;
            comando.Parameters.Add("NUMERO", OracleType.Number).Value = NUMERO_CONSULTOR;
            comando.Parameters.Add("PASS", OracleType.NVarChar).Value = PASS_CONSULTOR;
            comando.Parameters.Add("ROL_CONSULTOR", OracleType.NVarChar).Value = ROL_ID_ROL;


            int resultado = comando.ExecuteNonQuery();
            return resultado;

        }

        public int Modificar( string NOM_CONSULTOR, string APELLIDOP_CONSULTOR, string APELLIDOM_CONSULTOR,
            string CORREO_CONSULTOR, int NUMERO_CONSULTOR, string PASS_CONSULTOR)
        {

            conn.Open();
            OracleCommand comando = new OracleCommand("PACK_MANT_CONSULTOR.SP_MODIFICAR_CONSULTOR", conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("NOMBRE", OracleType.NVarChar).Value = NOM_CONSULTOR;
            comando.Parameters.Add("APELLIDO_PATERNO", OracleType.NVarChar).Value = APELLIDOP_CONSULTOR;
            comando.Parameters.Add("APELLIDO_MATERNO", OracleType.NVarChar).Value = APELLIDOM_CONSULTOR;
            comando.Parameters.Add("CORREO", OracleType.NVarChar).Value = CORREO_CONSULTOR;
            comando.Parameters.Add("NUMERO", OracleType.Number).Value = NUMERO_CONSULTOR;
            comando.Parameters.Add("PASS", OracleType.NVarChar).Value = PASS_CONSULTOR;


            int resultado = comando.ExecuteNonQuery();
            return resultado;

        }
        public int Eliminar(string RUT_CONSULTOR)
        {
            conn.Open();
            OracleCommand comando = new OracleCommand("PACK_MANT_CONSULTOR.SP_ELIMINAR_CONSULTOR", conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("RUT", OracleType.NVarChar).Value = RUT_CONSULTOR;
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }







    }
}
