using System;
using System.Collections.Generic;

class Program
{
    // Método que recebe uma lista de inteiros e retorna a média
    static double CalcularMedia(List<int> numeros)
    {
        if (numeros.Count == 0)  // Verifica se a lista está vazia
        {
            return 0;  // Retorna 0 se a lista estiver vazia
        }

        int soma = 0;

        // Soma todos os números da lista
        foreach (int numero in numeros)
        {
            soma += numero;
        }

        // Calcula a média
        double media = (double)soma / numeros.Count;
        return media;
    }

    public static void Main()
    {
        // Criando a lista de números inteiros
        List<int> numeros = new List<int> { 10, 20, 30, 40, 50 };

        // Chama o método para calcular a média
        double media = CalcularMedia(numeros);
        Console.WriteLine("A média dos números é: " + media);

        // Aguarda o usuário pressionar uma tecla para finalizar
        Console.ReadLine();
    }
}
