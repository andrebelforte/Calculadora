using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Escolha uma opção de Calculo");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            short escolha = short.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Digite o 1º Valor: ");
            double valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º Valor: ");
            double valor2 = double.Parse(Console.ReadLine());
            double soma = valor1 + valor2;
            Console.WriteLine("A soma do número " + valor1 + " + " + valor2 + " = " + soma);
            Menu();
            Console.ReadKey();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Digite o 1º Valor: ");
            double valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º Valor: ");
            double valor2 = double.Parse(Console.ReadLine());
            double subtracao = valor1 - valor2;
            Console.WriteLine("A subtração do valor " + valor1 + " - " + valor2 + " = " + subtracao);
            Menu();
            Console.ReadKey();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Digite o 1º Valor: ");
            double valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º Valor: ");
            double valor2 = double.Parse(Console.ReadLine());
            double multiplicacao = valor1 * valor2;
            Console.WriteLine("A multiplicação do valor " + valor1 + " * " + valor2 + " = " + multiplicacao);
            Menu();
            Console.ReadKey();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Digite o 1º Valor: ");
            double valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º Valor: ");
            double valor2 = double.Parse(Console.ReadLine());
            double divisao = valor1 / valor2;
            Console.WriteLine("A divisão do valor " + valor1 + " / " + valor2 + " = " + divisao);
            Menu();
            Console.ReadKey();
        }
    }
}
