using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number of elements");
            n = Int32.Parse(Console.ReadLine());
            int[] array = new int[n];

            Console.WriteLine("Enter your array");
            for (int i=0;i< array.Length;i++)
            {
                Console.Write("mas[{0}] = ", i);
                array[i] = Int32.Parse(Console.ReadLine());
            }

            BubbleSort(array);
            //!сортировка методом BubbleSort может быть заменена методом Sort
            //из класса Array.

            Console.WriteLine("Changed array");
            for (int i=0;i<n;i++)
            {
                Console.WriteLine(array[i]);
            }

          
            Console.WriteLine("Enter the number");
            int number = Int32.Parse(Console.ReadLine());
            Console.WriteLine(MySearch(array, number)); //сортируем упорядоченный массив

            //!поиск с помощью метода MySearch может быть заменен
            //методом BinarySearch из класса Array.

            Console.ReadKey();
        }

        static void BubbleSort(int[] array)
        {
            int t;
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }

        }

        
        static string MySearch(int[] array, int number)
        {
            int l = 0,
                r = array.Length - 1;
               
            while (l <= r)
            {
                int middle = (l + r) / 2;
                if (number == array[middle])
                {                   
                    return "Found: " + array[middle].ToString();
                }

                if (number < array[middle])
                {              
                    r = middle - 1;
                }

                else
                {
                    l = middle + 1;
                }
            } 
            return "Not Found";
        }
        
    }
}
