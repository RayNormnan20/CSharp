using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer02Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double sueldo, aumento, total;
            Console.Write("Ingrese el sueldo: ");
            sueldo = Double.Parse(Console.ReadLine());

            if (sueldo < 500)
                aumento = 0.15 * sueldo;
            else
                aumento = 0.10 * sueldo;

            total = sueldo + aumento;
            Console.WriteLine("===Boleta de trabajador===" );
            Console.WriteLine("El sueldo del trabajador es: " + sueldo);
            Console.WriteLine("El aumento es: " + aumento);
            Console.WriteLine("El total es: " + total);
            Console.ReadKey();
        }
    }
}
