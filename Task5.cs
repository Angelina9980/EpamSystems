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

            Stack<char> check = new Stack<char>();
            for (int i = 0; i < sentence.Length; i++)
            {
                if ((sentence[i].Equals('(')) || (sentence[i].Equals('[')) || (sentence[i].Equals('{')))
                {
                    check.Push(sentence[i]);
                }
                
                if ( ((sentence[i].Equals(')')) && (check.Pop() == ')') ||
                     ((sentence[i].Equals('}')) && (check.Pop() == '}')) || 
                     ((sentence[i].Equals(']')) && (check.Pop() == ']')))
                {
                        check.Pop();
                }
              
            }
           
            foreach(char elem in check)
            {
                if ((elem == '(') || (elem == '[') || (elem == '{'))
                {
                    Console.WriteLine("No");
                }
                else
                {
                    Console.WriteLine("Yes");
                }
            }
            Console.ReadKey();
        }
    }
}
