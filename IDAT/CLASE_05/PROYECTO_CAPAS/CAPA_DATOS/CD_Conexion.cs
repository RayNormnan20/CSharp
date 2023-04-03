using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CAPA_DATOS
{
    public class CD_Conexion
    {
        private SqlConnection Conexion = new SqlConnection("Data Source=LAPTOP-ICDV7HGC\\SQLEXPRESS01;Initial Catalog=ALUMNOS_IDAT;Integrated Security=True");
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
