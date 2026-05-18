using System;
using System.Collections;
using System.Collections.Generic;

class Test
{
    delegate void MyDelegate(string text);
    delegate void MyDelegate2(string text);
    void Maj(string text)
    {
        Console.WriteLine(text.ToUpper());
    }
    void Min(string text)
    {
        Console.WriteLine(text.ToLower());
    }
    public void AfficherText()
    {
        MyDelegate variableDelegate=Maj;
        variableDelegate("Salut");
        MyDelegate2 variableDelegate2=Maj;
        variableDelegate2("Salut");
    }
}
