using System;

namespace Atividade_08
{
    class Program
    {
        // Static method to sum numbers
        public static int quadrado(int numeros)
        {
        	return numeros * numeros;
       
        }
      
        public static void Main(string[] args)
        {
           Console.WriteLine("Digite um número");
        	int numero = int.Parse(Console.ReadLine());
        	int resultado = quadrado(numero);
            
          Console.WriteLine("O quadrado do número é: " + resultado);
        Console.ReadKey();
        }
        
    }
}
