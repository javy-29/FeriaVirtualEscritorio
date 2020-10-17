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
    public class TransportistaDALC
    {
        OracleConnection conn = new OracleConnection("DATA SOURCE = xe ; PASSWORD = 1234 ;USER ID = FeriaV");

        public object DatabaseHelper { get; private set; }

        public int Agregar(int id_trans, string rut, string nombretransp, string apellido_patertransp, string apellido_matertransp,  string correotransp, int telefonotransp, string patentetransp, int capacidadcarga,string Refrigeracion, string passtransp, string rol)
        {
            conn.Open();
            OracleCommand comando = new OracleCommand("PACK_MANT_TRANSPORTISTA.SP_INGRESAR_TRANSPORTISTA", conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("ID_TRANSPORTISTA", OracleType.Number).Value = id_trans;
            comando.Parameters.Add("RUT", OracleType.NVarChar).Value = rut;
            comando.Parameters.Add("NOMBRE", OracleType.NVarChar).Value = nombretransp;
            comando.Parameters.Add("APELLIDO_PATERNO", OracleType.NVarChar).Value = apellido_patertransp;
            comando.Parameters.Add("APELLIDO_MATERNO", OracleType.NVarChar).Value = apellido_matertransp;
            comando.Parameters.Add("CORREO", OracleType.NVarChar).Value = correotransp;
            comando.Parameters.Add("TELEFONO", OracleType.Number).Value = telefonotransp;
            comando.Parameters.Add("PATENTE", OracleType.NVarChar).Value = patentetransp;
            comando.Parameters.Add("CAPACIDAD", OracleType.Number).Value = capacidadcarga;
            comando.Parameters.Add("REFRI", OracleType.NVarChar).Value = Refrigeracion;
            comando.Parameters.Add("CONTRASENA", OracleType.NVarChar).Value = passtransp;
            comando.Parameters.Add("ROL", OracleType.NVarChar).Value = rol;

            int resultado = comando.ExecuteNonQuery();
            return resultado;

        }

        public int Modificar(int id_trans, string rut, string nombretransp, string apellido_patertransp, string apellido_matertransp, string correotransp, int telefonotransp, string patentetransp, int capacidadcarga, string Refrigeracion, string passtransp, string rol)
        {
            conn.Open();
            OracleCommand comando = new OracleCommand("PACK_MANT_TRANSPORTISTA.SP_MODIFICAR_TRANSPORTISTA", conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("ID_TRANSPORTISTA", OracleType.Number).Value = id_trans;
            comando.Parameters.Add("RUT", OracleType.NVarChar).Value = rut;
            comando.Parameters.Add("NOMBRE", OracleType.NVarChar).Value = nombretransp;
            comando.Parameters.Add("APELLIDO_PATERNO", OracleType.NVarChar).Value = apellido_patertransp;
            comando.Parameters.Add("APELLIDO_MATERNO", OracleType.NVarChar).Value = apellido_matertransp;
            comando.Parameters.Add("CORREO", OracleType.NVarChar).Value = correotransp;
            comando.Parameters.Add("TELEFONO", OracleType.Number).Value = telefonotransp;
            comando.Parameters.Add("PATENTE", OracleType.NVarChar).Value = patentetransp;
            comando.Parameters.Add("CAPACIDAD", OracleType.Number).Value = capacidadcarga;
            comando.Parameters.Add("REFRI", OracleType.NVarChar).Value = Refrigeracion;
            comando.Parameters.Add("CONTRASENA", OracleType.NVarChar).Value = passtransp;
            comando.Parameters.Add("ROL", OracleType.NVarChar).Value = rol;

            int resultado = comando.ExecuteNonQuery();
            return resultado;

        }

        public int Eliminar(int id_transp)
        {
            conn.Open();
            OracleCommand comando = new OracleCommand("PACK_MANT_TRANSPORTISTA.SP_ELIMINAR_TRANSPORTISTA", conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("ID_TRANSPORTISTA", OracleType.Number).Value = id_transp;
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }









    }
}
