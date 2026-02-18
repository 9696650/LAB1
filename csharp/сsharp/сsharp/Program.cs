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
                // 1. Введення даних користувачем
                Console.Write("Write a word: ");
                string input = Console.ReadLine() ?? "";

                // 2. Створення об'єкта класу (екземпляра)
                StringHandler handler = new StringHandler(input);


                // Вивід рядка великими літерами
                Console.WriteLine($"CAPS: {handler.GetUpperCaseValue()}");

                // Вивід довжини
                Console.WriteLine($"Length: {handler.GetLength()}");

                // 4. Автоматична заміна символів (A та a на @)
                // Викликаємо метод двічі: для великої та малої літери
                handler.ReplaceChar('A', '@');
                handler.ReplaceChar('a', '@');

              

                // 5. Вивід зміненого рядка
                Console.WriteLine($"After replacement: {handler.GetCurrentValue()}");

             
            }
        }
    }
}
