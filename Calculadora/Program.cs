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
   
 }
