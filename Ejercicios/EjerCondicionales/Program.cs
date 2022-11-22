using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double compra, descuento, total;
            Console.Write("Ingresar el monto de compra: ");
            compra = Double.Parse(Console.ReadLine());
            if (compra > 100)
                descuento = 0.10 * compra;
            else
                descuento = 0;
            total = compra - descuento;
            Console.WriteLine("***Boleta de compra***");
            Console.WriteLine("El monto de compra es: " + compra);
            Console.WriteLine("El descuento es: " + descuento);
            Console.WriteLine("El total a pagar es: " + total);
            Console.ReadKey();

        }
    }
}
