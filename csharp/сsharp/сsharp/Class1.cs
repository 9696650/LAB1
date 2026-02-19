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
        
            private string _data;

            
            public StringHandler(string input)
            {
                _data = input;
            }

            
            public string GetUpperCaseValue()
            {
                return _data.ToUpper();
            }

            
            public int GetLength()
            {
                return _data.Length;
            }

           
            public void ReplaceChar(char oldChar, char newChar)
            {
                _data = _data.Replace(oldChar, newChar);
            }

            
            public string GetCurrentValue()
            {
                return _data;
            }
        }
    }
}
