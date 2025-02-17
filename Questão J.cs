using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    
    static int CalcularMenor(List<int> numeros)
    {
        if (numeros.Count == 0)  
        {
            throw new ArgumentException("A lista não pode estar vazia.");
        }

        return numeros.Min();  
    }

    public static void Main()
    {
        
        List<int> numeros = new List<int> { 10, 20, 30, 40, 50 };

        
        int menorNumero = CalcularMenor(numeros);
        
       
        Console.WriteLine("O menor número é: " + menorNumero);

      
        Console.ReadLine();
    }
}
