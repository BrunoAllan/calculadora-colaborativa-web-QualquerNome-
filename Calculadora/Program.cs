using System;

﻿class Program
{
    static void Main()
    {
        
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
 }
