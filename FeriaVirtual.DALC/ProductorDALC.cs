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
    public class ProductorDALC
    {
        OracleConnection conn = new OracleConnection("DATA SOURCE = xe ; PASSWORD = 1234 ;USER ID = FeriaV");

        public object DatabaseHelper { get; private set; }

        public int Agregar(int id_productor, string rut, string nombreproductor, string apellido_paterproduc, string apellido_materproduc, string direccionproduc, string ciudadproduc,  int telefonoproduc, string correoproduc,  string passproductor, string rol, int contrato)
        {
            conn.Open();
            OracleCommand comando = new OracleCommand("PACK_MANT_PRODUCTOR.SP_AGREGAR_PRODUCTOR", conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("ID_PRODUCTOR", OracleType.Number).Value = id_productor;
            comando.Parameters.Add("RUT", OracleType.NVarChar).Value = rut;
            comando.Parameters.Add("NOMBRE", OracleType.NVarChar).Value = nombreproductor;
            comando.Parameters.Add("APELLIDOP", OracleType.NVarChar).Value = apellido_paterproduc;
            comando.Parameters.Add("APELLIDOM", OracleType.NVarChar).Value = apellido_materproduc;
            comando.Parameters.Add("DIRECCION", OracleType.NVarChar).Value = direccionproduc;
            comando.Parameters.Add("CIUDAD", OracleType.NVarChar).Value = ciudadproduc;
            comando.Parameters.Add("TELEFONO", OracleType.Number).Value = telefonoproduc;
            comando.Parameters.Add("CORREO", OracleType.NVarChar).Value = correoproduc;
            comando.Parameters.Add("CONTRASEÑA", OracleType.NVarChar).Value = passproductor;
            comando.Parameters.Add("ROL", OracleType.NVarChar).Value = rol;
            comando.Parameters.Add("CONTRATO", OracleType.Number).Value = contrato;


            int resultado = comando.ExecuteNonQuery();
            return resultado;

        }

        public int Modificar(int id_productor,  string nombreproductor, string apellido_paterproduc, string apellido_materproduc, string direccionproduc, string ciudadproduc, int telefonoproduc, string correoproduc, string passproductor)
        {
            conn.Open();
            OracleCommand comando = new OracleCommand("PACK_MANT_PRODUCTOR.SP_MODIFICAR_PRODUCTO", conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("ID_PRODUCTOR", OracleType.Number).Value = id_productor;
            comando.Parameters.Add("NOMBRE", OracleType.NVarChar).Value = nombreproductor;
            comando.Parameters.Add("APELLIDOP", OracleType.NVarChar).Value = apellido_paterproduc;
            comando.Parameters.Add("APELLIDOM", OracleType.NVarChar).Value = apellido_materproduc;
            comando.Parameters.Add("DIRECCION", OracleType.NVarChar).Value = direccionproduc;
            comando.Parameters.Add("CIUDAD", OracleType.NVarChar).Value = ciudadproduc;
            comando.Parameters.Add("TELEFONO", OracleType.Number).Value = telefonoproduc;
            comando.Parameters.Add("CORREO", OracleType.NVarChar).Value = correoproduc;
            comando.Parameters.Add("CONTRASEÑA", OracleType.NVarChar).Value = passproductor;


            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public int Eliminar(int id_produc)
        {
            conn.Open();
            OracleCommand comando = new OracleCommand("PACK_MANT_PRODUCTOR.SP_ELIMINAR_PRODUCTOR", conn);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("ID_PRODUCTOR", OracleType.Number).Value = id_produc;
            int resultado = comando.ExecuteNonQuery();
            return resultado;
        }
















    }
}
