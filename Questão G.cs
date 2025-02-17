
using System;

class Program
{
    // Método que retorna uma nova string com caracteres nas posições ímpares
    static string CaracteresImpares(string input)
    {
        string resultado = "";
        
        // Itera sobre os índices da string e seleciona apenas os índices ímpares
        for (int i = 1; i < input.Length; i += 2)
        {
            resultado += input[i];
        }
        
        return resultado;
    }

    public static void Main()
    {
        Console.WriteLine("Insira uma string:");
        string input = Console.ReadLine();
        
        // Chama o método para pegar os caracteres em posições ímpares
        string resultado = CaracteresImpares(input);
        
        // Exibe o resultado
        Console.WriteLine("A string com caracteres nas posições ímpares é: " + resultado);

        // Aguarda o usuário pressionar uma tecla para finalizar
        Console.ReadLine();
    }
}
