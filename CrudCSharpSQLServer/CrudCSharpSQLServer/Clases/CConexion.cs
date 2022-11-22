using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudCSharpSQLServer.Clases
{
    internal class CConexion
    {
        SqlConnection conex = new SqlConnection ();

        static String servidor = "localhost";
        static String bd = "colegioDB";
        static String usuario = "sa";
        static String contrasenia = "12345678";
        static String puerto = "1433";

        String cadenaConexion = "Data Source =" + servidor + "," + puerto + ";" + "user id=" + usuario + ";" + "password=" + contrasenia + ";" + "Initial Catalog=" + bd + ";" + "Persist Security info = true";
        public SqlConnection establecerConexion()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open ();
                //MessageBox.Show("Se conectó correctamente a la base de datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conectó correctamente a la base de datos, error: " + ex.ToString());
            }
            return conex;
         
        }
        public void cerrarConexion()
        {
            conex.Close();
        }
    }
}
