#pragma once
#include <string>
using namespace std;

class String_Class {
private:
   string value;

public:
    String_Class();

    void Set_Word(const string str);
    string Get_Word();

    
    size_t Get_Length();

    void To_Upper();
   
};
