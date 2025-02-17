
using System;

class Program
{
    // Método para verificar se o número é par
    static bool VerificarPar(int numero)
    {
        return numero % 2 == 0;  // Retorna true se o número for par, false se for ímpar
    }

    public static void Main()
    {
        Console.WriteLine("Insira um número:");
        int num = int.Parse(Console.ReadLine());
        
        // Chama o método para verificar se o número é par
        bool resultado = VerificarPar(num);
        
        // Exibe o resultado
        if (resultado)
        {
            Console.WriteLine("O número {0} é par.", num);
        }
        else
        {
            Console.WriteLine("O número {0} é ímpar.", num);
        }

        // Aguarda o usuário pressionar uma tecla para finalizar
        Console.ReadLine();
    }
}
