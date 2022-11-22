using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 15, b = 10, c = 9;

            if (a > b) //A es mayor
            {
                if(a > c) // a es mayor
                {
                    Console.WriteLine("A es mayor");
                }
                else // C es mayor 
                {
                    Console.WriteLine("C es mayor");
                }
            }
            else // B es mayor 
            {
                if (b > c)
                {
                    Console.WriteLine("B es mayor");
                }
                else // C es mayor 
                {
                    Console.WriteLine("C es mayor");
                }
            }
            Console.Read();
        }
    }
}
