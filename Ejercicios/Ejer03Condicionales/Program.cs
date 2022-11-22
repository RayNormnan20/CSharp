using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer03Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, resultado;

            Console.Write("Ingresar el primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingresar el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2) 
                resultado = num1 / num2;
            else
                resultado = num2 / num1;
            Console.WriteLine("La división es: " + resultado);
            Console.ReadKey();
        }
    }
}
