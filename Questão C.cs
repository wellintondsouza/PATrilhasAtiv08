using System;

class Program
{
	static int calculadora (int numero1,int numero2){
	
		
		return numero1 + numero2;
		
		
		
	}
     public static void Main()
    {
        Console.WriteLine("insira um numero");
        int num = int.Parse(Console.ReadLine());
        
        
        Console.WriteLine("insira um numero");
        int num2 = int.Parse(Console.ReadLine());
        
		
        int soma = calculadora(num,num2);
        
        Console.WriteLine("a quantodade de letras da palavra é : {0}", soma	);
        Console.ReadLine();
}
}
