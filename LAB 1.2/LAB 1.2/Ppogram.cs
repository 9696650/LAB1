using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1._2
{
  
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Write a word: ");
                string input = Console.ReadLine() ?? "";

                MyString myStr = new MyString(input);

                Console.WriteLine($"Original word: {myStr.Value}");

                // Виконуємо автоматичну заміну A -> @
                myStr.ReplaceAWithAt();
                Console.WriteLine($"After replacing 'A' and 'a' with '@': {myStr.Value}");

              

                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            }
        }
    }