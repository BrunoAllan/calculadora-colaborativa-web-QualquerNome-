using System;

﻿class Program
{
    static void Main()
    {
       
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



