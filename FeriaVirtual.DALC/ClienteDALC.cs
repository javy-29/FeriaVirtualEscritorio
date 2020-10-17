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
        OracleConnection conn = new OracleConnection("DATA SOURCE = xe ; PASSWORD = 1234 ;USER ID = FeriaV");

        public object DatabaseHelper { get; private set; }

        public int Agregar(int id_cliente, string rut, string nombrecli, string apellido_pater, string apellido_mater, string direccion, string ciudad, string correo, int telefono, string cliente_extranjero, string passcli, string rol)
        {
            conn.Open();
            OracleCommand comando = new OracleCommand("PACK_MANT_CLIENTE.SP_AGREGAR_CLIENTE", conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("ID_CLI", OracleType.Number).Value = id_cliente;
            comando.Parameters.Add("RUT", OracleType.NVarChar).Value = rut;
            comando.Parameters.Add("NOMBRE", OracleType.NVarChar).Value = nombrecli;
            comando.Parameters.Add("APELLIDOP", OracleType.NVarChar).Value = apellido_pater;
            comando.Parameters.Add("APELLIDOM", OracleType.NVarChar).Value = apellido_mater;
            comando.Parameters.Add("DIRECCION", OracleType.NVarChar).Value = direccion;
            comando.Parameters.Add("CIUDAD", OracleType.NVarChar).Value = ciudad;
            comando.Parameters.Add("CORREO", OracleType.NVarChar).Value = correo;
            comando.Parameters.Add("TELEFONO", OracleType.Number).Value = telefono;
            comando.Parameters.Add("CLIENTE_EX", OracleType.NVarChar).Value = cliente_extranjero;
            comando.Parameters.Add("CONTRASEÑA", OracleType.NVarChar).Value = passcli;
            comando.Parameters.Add("ROL", OracleType.NVarChar).Value = rol;
           

            int resultado = comando.ExecuteNonQuery();
            return resultado;

        }

        public int Modificar(int id_cliente,  string nombrecli, string apellido_pater, string apellido_mater, string direccion, string ciudad, string correo, int telefono, string cliente_extranjero, string passcli)
        {
            conn.Open();
            OracleCommand comando = new OracleCommand("PACK_MANT_CLIENTE.SP_MODIFICAR_CLIENTE", conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("ID_CLI", OracleType.Number).Value = id_cliente;
            comando.Parameters.Add("NOMBRE", OracleType.NVarChar).Value = nombrecli;
            comando.Parameters.Add("APELLIDOP", OracleType.NVarChar).Value = apellido_pater;
            comando.Parameters.Add("APELLIDOM", OracleType.NVarChar).Value = apellido_mater;
            comando.Parameters.Add("DIRECCION", OracleType.NVarChar).Value = direccion;
            comando.Parameters.Add("CIUDAD", OracleType.NVarChar).Value = ciudad;
            comando.Parameters.Add("CORREO", OracleType.NVarChar).Value = correo;
            comando.Parameters.Add("TELEFONO", OracleType.Number).Value = telefono;
            comando.Parameters.Add("EXTRANJERO", OracleType.NVarChar).Value = cliente_extranjero;
            comando.Parameters.Add("CONTRASEÑA", OracleType.NVarChar).Value = passcli;

            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }



        public int Eliminar(int id_cliente)
        {
            conn.Open();
            OracleCommand comando = new OracleCommand("PACK_MANT_CLIENTE.SP_ELIMINAR_CLIENTE", conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("ID_CLI", OracleType.Number).Value = id_cliente;
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }










































    }
}
