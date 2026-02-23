using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace csharp
{
    public class MyString
    {
       
        private string text;

       
        public MyString(string input)
        {
            text = input.ToUpper(); 
        }

        
        public string GetText()
        {
            return text;
        }

        
        public int GetLength()
        {
            return text.Length;
        }

       
    }
}
