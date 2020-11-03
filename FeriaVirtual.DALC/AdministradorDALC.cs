using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OracleClient;


namespace FeriaVirtual.DALC
{
    public class AdministradorDALC
    {
        OracleConnection conn = new OracleConnection("DATA SOURCE = xe ; PASSWORD = 1234 ;USER ID = FeriaVI");

        public object DatabaseHelper { get; private set; }

        public bool Login(string usuario, string contraseña)
        {

            conn.Open();
            OracleCommand comando = new OracleCommand("SELECT * FROM ADMINISTRADOR WHERE RUT_ADMIN = :usuario AND PASS_ADMIN = :contra", conn);
            comando.Parameters.AddWithValue(":usuario", usuario);
            comando.Parameters.AddWithValue(":contra", contraseña);
            OracleDataReader lector = comando.ExecuteReader();

            bool resultado = lector.Read();

            return resultado;
        }

        public int Agregar( string RUT_ADMIN, string NOM_ADMIN, string APELLIDOP_ADMIN, 
            string APELLIDOM_ADMIN,  int TELEFONO_ADMIN, string CORREO_ADMIN,
            string PASS_ADMIN, string ROL_ID_ROL)
        {

            conn.Open();
            OracleCommand comando = new OracleCommand("PACK_MANT_ADMINISTRADOR.SP_INGRESAR_ADMINISTRADOR", conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("RUT", OracleType.NVarChar).Value = RUT_ADMIN;
            comando.Parameters.Add("NOMBRE", OracleType.NVarChar).Value = NOM_ADMIN;
            comando.Parameters.Add("APELLIDO_PATERNO", OracleType.NVarChar).Value = APELLIDOP_ADMIN;
            comando.Parameters.Add("APELLIDO_MATERNO", OracleType.NVarChar).Value = APELLIDOM_ADMIN;
            comando.Parameters.Add("TELEFONO", OracleType.Number).Value = TELEFONO_ADMIN;
            comando.Parameters.Add("CORREO", OracleType.NVarChar).Value = CORREO_ADMIN;
            comando.Parameters.Add("CONTRASEÑA", OracleType.NVarChar).Value = PASS_ADMIN;
            comando.Parameters.Add("ROL", OracleType.NVarChar).Value = ROL_ID_ROL;


            int resultado = comando.ExecuteNonQuery();
            return resultado;

        }

        public int Modificar(string RUT_ADMIN, string NOM_ADMIN, string APELLIDOP_ADMIN, string APELLIDOM_ADMIN, int TELEFONO_ADMIN, string CORREO_ADMIN, string PASS_ADMIN )
        {

            conn.Open();
            OracleCommand comando = new OracleCommand("PACK_MANT_ADMINISTRADOR.SP_MODIFICAR_ADMINISTRADOR", conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("RUT", OracleType.NVarChar).Value = RUT_ADMIN;
            comando.Parameters.Add("NOMBRE", OracleType.NVarChar).Value = NOM_ADMIN;
            comando.Parameters.Add("APELLIDO_PATERNO", OracleType.NVarChar).Value = APELLIDOP_ADMIN;
            comando.Parameters.Add("APELLIDO_MATERNO", OracleType.NVarChar).Value = APELLIDOM_ADMIN;
            comando.Parameters.Add("TELEFONO", OracleType.Number).Value = TELEFONO_ADMIN;
            comando.Parameters.Add("CORREO", OracleType.NVarChar).Value = CORREO_ADMIN;
            comando.Parameters.Add("CONTRASEÑA", OracleType.NVarChar).Value = PASS_ADMIN;

            int resultado = comando.ExecuteNonQuery();
            return resultado;

        }

        public int Eliminar(string RUT_ADMIN) 
        {
            conn.Open();
            OracleCommand comando = new OracleCommand("PACK_MANT_ADMINISTRADOR.SP_ELIMINAR_ADMINISTRADOR", conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("RUT_ADMINISTRADOR", OracleType.Number).Value = RUT_ADMIN;
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }
    }

}
