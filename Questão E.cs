using System;
using System.Collections.Generic;

class Program
{
    static string ConcatenarStrings(List<string> lista)
    {
        return string.Join("", lista);
    }

    static void Main()
    {
        List<string> lista = new List<string> { "Olá", " ", "mundo", "!", " Como", " vai?" };
        string resultado = ConcatenarStrings(lista);
        Console.WriteLine(resultado);
        Console.ReadKey();
    }
    
}
