using System;

class Program
{
	static int contaLetras (string palavra){
	
		
		return palavra.Length;
		
		
		
	}
     public static void Main()
    {
        Console.WriteLine("insira uma palavra");
        string entrada1 = (Console.ReadLine());
		
        int quantidadeLetras = contaLetras(entrada1);
        
        Console.WriteLine("a quantodade de letras da palavra é : {0}", quantidadeLetras);
        Console.ReadLine();
}
}
