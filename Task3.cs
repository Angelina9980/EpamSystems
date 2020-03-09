using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string");
            string s = Console.ReadLine();

            char[] marks = {' ', '.', ',', '!', '?', ':', ';' , '-'};
            string[] array = s.Split(marks, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;

                for (int j=0; j < array.Length; j++)
                {
                    if (array[i].Equals(array[j]))
                        count++;
                }

                if (count < 2)
                    Console.WriteLine(array[i]);
            }
             Console.ReadKey();   
        }
    }
}
