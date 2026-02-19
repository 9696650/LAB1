#include "lab1.h" 
using namespace std;

String_Class::String_Class() {
    value = "";
}

string String_Class::Get_Word() {
    return value;
}

void String_Class::Set_Word(const string str) {
    value = str;
}

size_t String_Class::Get_Length() {
    return value.length();
}

void String_Class::To_Upper() {
 
    for (size_t i = 0; i < value.length(); i++) {
        value[i] = (char)toupper((unsigned char)value[i]);
    }
}

void String_Class::Replace_Char(char oldChar, char newChar) {
    for (size_t i = 0; i < value.length(); i++) {
        if (value[i] == oldChar) {
            value[i] = newChar;
        }
    }
}

