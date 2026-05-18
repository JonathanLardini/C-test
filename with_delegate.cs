using System;
using System.Collections;
using System.Collections.Generic;

class Test
{
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
        Maj("Salut");
        Min("Salut");
    }
}
