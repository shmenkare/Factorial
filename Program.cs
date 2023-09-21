using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {   // Factorial 2.0
           
            int num = 0;
            int fact = 1;

            
            Console.WriteLine("Ingrese el numero a sacar el factorial");
            num = Convert.ToInt32(Console.ReadLine());
            fact = Factorial(num);
            Console.Write("El factorial de {0} es {1}",num,fact);
            
            Console.ReadKey();
        }
        static int Factorial(int x)
        {
            int r = 1;
            for (int i = 1; i <= x; i++)
            {
                Thread.Sleep(500);

                r *= i;

                Console.WriteLine("i = {0}", i);
                Console.WriteLine("fact = fact * i ");
                Console.WriteLine();
                Console.WriteLine("fact = {0}", r);


            }
             return r;
        }
    }
}
