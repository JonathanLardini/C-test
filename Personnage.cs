using System;
using System.Collections;
using System.Collections.Generic;

class Test
{
    delegate void DelegateType(string text);
    delegate void DelegateType2(string text);
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
        DelegateType variableDelegate = Maj;
        DelegateType2 variableDelegate2 = Min;
        variableDelegate("Salut");
        variableDelegate2("Salut");
    }
}
