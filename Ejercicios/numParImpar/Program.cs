using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numParImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Ingresar numero: ");
            numero  = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("Es par");
            else
                Console.WriteLine("Es impar");
            Console.ReadKey();

        }
    }
}
