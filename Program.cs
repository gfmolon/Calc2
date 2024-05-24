using System;

namespace Calc2
{

    public class Program
    {
        private static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            HeaderCalc();
            Console.WriteLine("Escolha a opção desejada");
            Console.WriteLine("0 - Tabuada");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtracao");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("------------------");
            short result = short.Parse(Console.ReadLine());

            switch (result)
            {
                case 0: Tabuada(); break;
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

        }

        static void Tabuada()
        {
            Console.Clear();
            Console.WriteLine("Digite um número:");
            short n1 = short.Parse(Console.ReadLine());

            for (short i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n1} * {i} = {n1 * i}");
            }

            Console.ReadKey();
            Menu();
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro número:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo número:");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 + v2;

            Console.WriteLine($"O resultado da soma é {result}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro número");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo número");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 - v2;
            Console.WriteLine($"O resultado da subtração é {result}");

            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro número:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo número:");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 * v2;

            Console.WriteLine($"O resultado da multiplicacao é {result}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Número:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Número:");
            float v2 = float.Parse(Console.ReadLine());
            float result = v1 / v2;
            Console.WriteLine($"O resultado da divisão é {result}");
            Console.ReadKey();
            Menu();
        }

        static void HeaderCalc()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("CALCULADORA");
            Console.WriteLine("---------------------");
        }

    }
}