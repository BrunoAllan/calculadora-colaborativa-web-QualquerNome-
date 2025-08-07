using System;

    /// <summary>
    /// essa e a classe principal do projeto
    /// </summary>

class Program
{
    /// <summary>
    /// esse e o metodo inicial do projeto
    /// </summary>

    static void Main()
    {
         bool continuacao = true; // define continuação com sempre verdadeira

        while (continuacao)
        {
            // exibe o menu
            Console.WriteLine("\n=== CALCULADORA ===");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            Console.Write("Opção: ");
            string opcao = Console.ReadLine(); // pega a opção escolhida e cria uma variável com ela

            // chama a classe correspondente a escolha do usuário
            switch (opcao)
            {
                case "1": soma(); break;
                case "2": subtracao(); break;
                case "3": multiplicacao(); break;
                case "4": divisao(); break;
                case "5": sair(); break;
                default:
                    Console.WriteLine("Opção inválida, tente novamente."); // exibe que a opção é invalida
                    continuar(); // chama a classe continuar
                    break;
            }
        }

        
    }

    /// <summary>
    /// Exibe uma mensagem de saida e termina o progama
    /// </summary>

    static void sair()
    {
        Console.WriteLine("Saindo..."); // exibe mensagem de saída
        Environment.Exit(0); // termina o programa
    }

    /// <summary>
    /// Esse metodo exibe uma mensagem para o usuario clicar, verifica se ele clicou, apaga o console e volta pro menu
    /// </summary>

    static void continuar()
    {
        Console.WriteLine("Clique para continuar..."); // exibe mensagem pedindo o usuário clicar para continuar
        Console.ReadKey(); // espera o usuário clicar para continuar
        Console.Clear(); // apaga o console
        Main(); // volta a classe principal
    }

    /// <summary>
    /// Esse metodo pergunta dois numeros, pega eles, multiplica e exibe o resultado
    /// </summary>

    static void multiplicacao ()
        {

            Console.Clear(); // apaga o console

             //Entrada dos números
            Console.WriteLine("Escreva o primeiro número:"); // pedindo o primeiro número
            int num1 = int.Parse(Console.ReadLine()); // criando a variável do primeiro número

            Console.WriteLine("Escreva o Segundo número:"); // pedindo o segundo número
            int num2 = int.Parse(Console.ReadLine()); // criando a variável do segundo número

             //Resultado
            Console.WriteLine($"Seu resultado é: {num1 * num2}"); // imprime o resultado da multiplicacação dos dois números
            continuar(); // chama a classe continuar
        }
        
    /// <summary>
    /// Esse metodo pergunta dois numeros pega eles, subtrai e exibe o resultado
    /// </summary>

    static void subtracao()
    {
        Console.Clear(); // apaga o console

         //Entrada dos números
        Console.WriteLine("Digite o primeiro número"); // pedindo o primeiro número
        int sub1 = int.Parse(Console.ReadLine()); // criando a variável do primeiro número

        Console.WriteLine("Digite o segundo número"); // pedindo o segundo número
        int sub2 = int.Parse(Console.ReadLine()); // criando a variável do segundo número

        //Resultado
        Console.WriteLine($"A subtração dos números é: {sub1 - sub2}"); // imprime o resultado da subtração dos dois números
        continuar(); // chama a classe continuar
    }


    /// <summary>
    /// Esse metodo pergunta dois numeros, pega eles, divide e exibe o resultado
    /// </summary>
    
    static void divisao() 
        {

            Console.Clear(); // apaga o console

             //Entrada dos números
            Console.WriteLine("Digite o primeiro número"); // pedindo o primeiro número
            int a = int.Parse(Console.ReadLine()); // criando a variável do primeiro número

            Console.WriteLine("\nDigite o segundo número"); // pedindo o segundo número
            int b = int.Parse(Console.ReadLine()); // criando a variável do segundo número

            //Resultado
            Console.WriteLine($"Resultado da Divisão: {a / b}"); // imprime o resultado da divisão dos dois números
            continuar(); // chama a classe continuar
        }
        
    /// <summary>
    /// Esse metodo pergunta dois numeros, pega eles, soma e exibe o resultado
    /// </summary>
    /// <returns></returns>
        
        static void soma()
        {

            Console.Clear(); // apaga o console

             //Entrada dos números
            Console.WriteLine("Digite o primeiro número"); // pedindo o primeiro número
            int soma1 = int.Parse(Console.ReadLine()); // criando a variável do primeiro número

            Console.WriteLine("\nDigite o segundo número"); // pedindo o segundo número
            int soma2 = int.Parse(Console.ReadLine()); // criando a variável do segundo número

             //Resultado
            Console.WriteLine($"A soma dos dois números digitados é igual a: {soma1 + soma2}"); // imprime o resultado da soma dos dois números
            continuar(); // chama a classe continuar
        }
        
}
