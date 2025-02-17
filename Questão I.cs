using System;

class Program
{
  
    static bool CalcularPrimo(int num)
    {
        if (num <= 1)
        {
            Console.WriteLine(num + " não é um número primo.");
            return false;
        }
        
       
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)  
            {
                Console.WriteLine(num + " não é um número primo.");
                return false;
            }
        }

        Console.WriteLine(num + " é um número primo.");
        return true;
    }

    public static void Main()
    {
        Console.WriteLine("Insira um número:");
        int num = int.Parse(Console.ReadLine());

        
        bool isPrimo = CalcularPrimo(num);
        
      
        if (isPrimo)
        {
            Console.WriteLine("O número é primo.");
        }
        else
        {
            Console.WriteLine("O número não é primo.");
        }

        Console.ReadLine();
    }
}
