using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAPA_DATOS;


namespace CAPA_NEGOCIO
{
    public class CN_Alumnos
    {
        private CD_Alumnos objetoCD = new CD_Alumnos();
        public DataTable MostrarAlum()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        /*
        public void InsertarAlum(char Dni, string Nombre, string Apellido, string Estudios, int Edad, string Pais)
        {
            objetoCD.Insertar(Dni,Nombre,Apellido, Estudios,Convert.ToInt32(Edad), Pais);
    }
        public void EditarProd(string nombre, string desc, string marca, string precio, string stock,string id)
        {
            objetoCD.Editar(nombre, desc, marca, Convert.ToDouble(precio), Convert.ToInt32(stock),Convert.ToInt32(id));
        }
        public void EliminarPRod(string id) {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
        */
        
    }
}
