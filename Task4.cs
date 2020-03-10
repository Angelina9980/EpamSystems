using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Enter a positive number");

            long number = long.Parse(Console.ReadLine());
            while (number < 0)
            {
                Console.WriteLine("Error. Enter a positive number");
                number = long.Parse(Console.ReadLine());
            }

          Console.WriteLine("Factorial {0} = {1}", number, Factorial(number));

          Console.ReadKey();
        }
       
        static long Factorial(long number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }

        }
    }
}
