using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace csharp
{
    class Program
    {
        static void Main()
        {
            {

                Console.Write("Write a word: ");

                string input = Console.ReadLine();


                MyString myStr = new MyString(input);

                Console.WriteLine("CAPS :  " + myStr.GetText());

                Console.WriteLine("Length : " + myStr.GetLength());


            }
        }

    }
