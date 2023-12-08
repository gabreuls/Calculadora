using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora2.OperacoesMat
{
    public class OperacoesBasicas
    {
        public static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Média");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("--------------------------------");

            short opção = Convert.ToInt16(Console.ReadLine());

            switch (opção)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: Média(); break;
                case 0: Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        static void Soma()
        {
        Console.Clear();

        Console.WriteLine("Insira um número: ");
        float valor1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Insira um segundo número: ");
        float valor2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"O resultado da soma é {valor1 + valor2}");

        Console.ReadKey();
        Menu();
        }
        static void Subtracao()
        {
        Console.Clear();

        Console.WriteLine("Insira um número: ");
        float valor1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Insira um segundo número: ");
        float valor2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"O resultado da subtração é {valor1 - valor2}");

        Console.ReadKey();
        Menu();
        }

        static void Multiplicacao()
        {
        Console.Clear();

        Console.WriteLine("Insira um número: ");
        float valor1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Insira um segundo número: ");
        float valor2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"O resultado da multiplicação é {valor1 * valor2}");

        Console.ReadKey();
        Menu();
        }

        static void Divisao()
        {
        Console.Clear();

        Console.WriteLine("Insira um número: ");
        float valor1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Insira um segundo número: ");
        float valor2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"O resultado da divisão é {valor1 / valor2}");

        Console.ReadKey();
        Menu();
        }

        static void Média()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro número:");
            float valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            float valor2 = Convert.ToInt32(Console.ReadLine());

            float resultado = (valor1 + valor2) / 2;

            Console.WriteLine($"A média entre esses números é {resultado}.");

            Console.ReadKey();
            Menu();
        }
    }
}