using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OracleClient;

namespace FeriaVirtual.DALC
{
    public class RolDALC
    {
        OracleConnection conn = new OracleConnection("DATA SOURCE = xe ; PASSWORD = 1234 ;USER ID = FeriaV");

        public object DatabaseHelper { get; private set; }

        public int ID_ROL { get; set; }
        public string NOM_ROL { get; set; }

    }
}
