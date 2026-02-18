#include <iostream>
#include "lab1.h" 
using namespace std;

int main()
{
    
    String_Class word;
   string value;

    cout << "Write a word: ";
  cin >> value;

    
    word.Set_Word(value);

    
    cout << "Length : " << word.Get_Length() << endl;

    
    word.To_Upper();
    cout << "CAPS : " << word.Get_Word() << endl;

    
    word.Replace_Char('a', '@');
    word.Replace_Char('A', '@');
    cout << "After replacement: " << word.Get_Word() << endl;

    return 0;
}