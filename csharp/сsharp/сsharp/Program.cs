using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace сsharp
{

    namespace StringLab
    {
        class Program
        {
            static void Main(string[] args)
            {
            
                Console.Write("Write a word: ");
                string input = Console.ReadLine() ?? "";

                /
                StringHandler handler = new StringHandler(input);


                Console.WriteLine($"CAPS: {handler.GetUpperCaseValue()}");

               
                Console.WriteLine($"Length: {handler.GetLength()}");

                handler.ReplaceChar('A', '@');
                handler.ReplaceChar('a', '@');

              

                Console.WriteLine($"After replacement: {handler.GetCurrentValue()}");

             
            }
        }
    }
}
