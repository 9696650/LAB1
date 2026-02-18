using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace сsharp
{
  

    namespace StringLab
    {
        public class StringHandler
        {
            // Приватне поле для зберігання рядка
            private string _data;

            // Конструктор класу
            public StringHandler(string input)
            {
                _data = input;
            }

            // Метод для повернення значення рядка (у великих буквах)
            public string GetUpperCaseValue()
            {
                return _data.ToUpper();
            }

            // Метод для обчислення довжини рядка
            public int GetLength()
            {
                return _data.Length;
            }

            // Метод для заміни одного символу на інший
            public void ReplaceChar(char oldChar, char newChar)
            {
                _data = _data.Replace(oldChar, newChar);
            }

            // Метод для отримання поточного стану рядка
            public string GetCurrentValue()
            {
                return _data;
            }
        }
    }
}
