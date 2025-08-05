using System;

﻿class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro número");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("\nDigite o segundo número");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"Resultado da Divisão: {a / b}");
    }
   
 }
