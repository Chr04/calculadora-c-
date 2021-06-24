using System;
using System.Threading;

namespace MinhaCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("------Calculadora------");

            Thread.Sleep(2000);

            Console.Clear();

            Console.WriteLine("1 - Adição +");
            Console.WriteLine("2 - Subtração -");
            Console.WriteLine("3 - Multiplicação *");
            Console.WriteLine("4 - Divisão /");
            Console.WriteLine("0 - Sair da calculadora");

            short dadosDigitados = short.Parse(Console.ReadLine());

            switch (dadosDigitados)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: adicao(); break;
                case 2: subtracao(); break;
                case 3: multiplicacao(); break;
                case 4: divisao(); break;
            }
        }

        static void adicao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor para soma");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            int resultadoSoma = valor1 + valor2;

            Console.WriteLine("");
            Console.WriteLine("O resultado da soma dos dois valores é:");
            Thread.Sleep(1000);
            Console.WriteLine(resultadoSoma);
            Console.WriteLine("");
            Console.WriteLine("------Voltando ao Menu------");
            Thread.Sleep(2500);
            Menu();
        }

        static void subtracao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor para subtração");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            int resultado = valor1 - valor2;

            Console.WriteLine("");
            Console.WriteLine("O resultado da subtração dos dois valores é:");
            Thread.Sleep(1000);
            Console.WriteLine("resultado");
            Console.WriteLine("");
            Console.WriteLine("------Voltando ao Menu------");
            Thread.Sleep(2500);
            Menu();
        }

        static void multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor para multiplicação");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            int resultado = valor1 * valor2;

            Console.WriteLine("");
            Console.WriteLine("O resultado da multiplicação dos dois valores é:");
            Thread.Sleep(1000);
            Console.WriteLine(resultado);
            Console.WriteLine("");
            Console.WriteLine("------Voltando ao Menu------");
            Thread.Sleep(2500);
            Menu();
        }

        static void divisao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor para divisão");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            int resultado = valor1 / valor2;

            Console.WriteLine("");
            Console.WriteLine("O resultado da divisão dos dois valores é:");
            Thread.Sleep(1000);
            Console.WriteLine(resultado);
            Console.WriteLine("");
            Console.WriteLine("------Voltando ao Menu------");
            Thread.Sleep(2500);
            Menu();
        }
    }
}
