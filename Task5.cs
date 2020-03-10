using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence with '()', '[]' and '{}'");
            string sentence = Console.ReadLine();

            Console.WriteLine(Check(sentence));
              Console.ReadKey();
                                   
        }

       public static string Check(string sentence)
        {
            int[] array = new int[sentence.Length];
            int mark = 0;

            if (sentence[0] == ')' || sentence[0] == ']' || sentence[0] == '}')
                return "No";

            for (int i = 0; i < sentence.Length;i++)
            {
                if (sentence[i] == '(')
                {
                    array[mark] = 1;
                    mark++;
                }

                if (sentence[i] == '[')
                {
                    array[mark] = 2;
                    mark++;
                }

                if (sentence[i] == '{')
                {
                    array[mark] = 3;
                    mark++;
                }


                if (sentence[i] == ')')
                {
                    if (mark == 0 || array[mark - 1] == 2 || array[mark - 1] == 3)
                        return "No";
                    else mark--;
                }

                if (sentence[i] == ']')
                {
                    if (mark == 0 || array[mark - 1] == 1 || array[mark - 1] == 3)
                        return "No";
                    else mark--;
                }

                if (sentence[i] == '}')
                {
                    if (mark == 0 || array[mark - 1] == 1 || array[mark - 1] == 2)
                        return "No";
                    else mark--;
                }
                
            }
                if (mark != 0) return "No";
                else return "Yes";
        }
    }
}
