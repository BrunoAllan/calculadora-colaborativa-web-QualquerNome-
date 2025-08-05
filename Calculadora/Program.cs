using System;

class Program
{
    static void Main()
    {

        
    }

    static void Multiplicacao ()
        {
            // Pedindo os números para o usuário:
            Console.WriteLine("Escreva o primeiro número:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o Segundo número:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Seu resultado é: {num1 * num2}");
        }
   
 

        
    

    static void subtração()
    {
         //Entrada dos números
        Console.WriteLine("Digite o primeiro número");
        int sub1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número");
        int sub2 = int.Parse(Console.ReadLine());

        //Resultado
        Console.WriteLine($"A subtração dos números é: {sub1 - sub2}");
    }


       
    
    static void divisao() 
        {
            Console.WriteLine("Digite o primeiro número");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o segundo número");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Resultado da Divisão: {a / b}");
        }
        
        static void soma()
        {
            Console.WriteLine("Digite o primeiro número");
            int soma1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o segundo número");
            int soma2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"A soma dos dois números digitados é igual a: {soma1 + soma2}");
        }
}

