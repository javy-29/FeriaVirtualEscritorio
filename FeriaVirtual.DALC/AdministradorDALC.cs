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
        OracleConnection conn = new OracleConnection("DATA SOURCE = xe ; PASSWORD = 1234 ;USER ID = FeriaV");

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

        public int Agregar(int id_administrador, string rutadmin, string nombreadmin, string apellido_pateradmin, string apellido_materadmin,  int telefonoadmin, string correoadmin, string passadmin, string rol)
        {

            conn.Open();
            OracleCommand comando = new OracleCommand("PACK_MANT_ADMINISTRADOR.SP_INGRESAR_ADMINISTRADOR", conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("ID_ADMINISTRADOR", OracleType.Number).Value = id_administrador;
            comando.Parameters.Add("RUT", OracleType.NVarChar).Value = rutadmin;
            comando.Parameters.Add("NOMBRE", OracleType.NVarChar).Value = nombreadmin;
            comando.Parameters.Add("APELLIDO_PATERNO", OracleType.NVarChar).Value = apellido_pateradmin;
            comando.Parameters.Add("APELLIDO_MATERNO", OracleType.NVarChar).Value = apellido_materadmin;
            comando.Parameters.Add("TELEFONO", OracleType.Number).Value = telefonoadmin;
            comando.Parameters.Add("CORREO", OracleType.NVarChar).Value = correoadmin;
            comando.Parameters.Add("CONTRASEÑA", OracleType.NVarChar).Value = passadmin;
            comando.Parameters.Add("ROL", OracleType.NVarChar).Value = rol;


            int resultado = comando.ExecuteNonQuery();
            return resultado;

        }

        public int Modificar(int id_administrador, string nombreadmin, string apellido_pateradmin, string apellido_materadmin, int telefonoadmin, string correoadmin, string passadmin)
        {

            conn.Open();
            OracleCommand comando = new OracleCommand("PACK_MANT_ADMINISTRADOR.SP_MODIFICAR_ADMINISTRADOR", conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("ID_ADMINISTRADOR", OracleType.Number).Value = id_administrador;
            comando.Parameters.Add("NOMBRE", OracleType.NVarChar).Value = nombreadmin;
            comando.Parameters.Add("APELLIDO_PATERNO", OracleType.NVarChar).Value = apellido_pateradmin;
            comando.Parameters.Add("APELLIDO_MATERNO", OracleType.NVarChar).Value = apellido_materadmin;
            comando.Parameters.Add("TELEFONO", OracleType.Number).Value = telefonoadmin;
            comando.Parameters.Add("CORREO", OracleType.NVarChar).Value = correoadmin;
            comando.Parameters.Add("CONTRASEÑA", OracleType.NVarChar).Value = passadmin;

            int resultado = comando.ExecuteNonQuery();
            return resultado;

        }

        public int Eliminar(int id_administrador) 
        {
            conn.Open();
            OracleCommand comando = new OracleCommand("PACK_MANT_ADMINISTRADOR.SP_ELIMINAR_ADMINISTRADOR", conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("ID_ADMINISTRADOR", OracleType.Number).Value = id_administrador;
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }
    }

}
