using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int num = 0;
            int fact = 1;
            
            Console.WriteLine("Ingrese el numero a sacar el factorial");
            num = Convert.ToInt32(Console.ReadLine());
            

            for (i = 1; i <= num; i++)
            {
                Thread.Sleep(500);

                fact *= i;
               
                Console.WriteLine(i);
                Console.Write("por ");
                Console.Write(fact);
                Console.WriteLine();
                
            }
            Console.Write("El factorial de {0} es {1}",num,fact);
            Console.ReadKey();
        }
    }
}
