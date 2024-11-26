using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu;
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Olá, por favor escolha uma opção:");
            Console.WriteLine("");
            Console.WriteLine(" 1 - Soma");
            Console.WriteLine(" 2 - Subtração");
            Console.WriteLine(" 3 - Divisão");
            Console.WriteLine(" 4 - Multiplicação");
            Console.WriteLine(" 5 - Sair");

            Console.WriteLine("");
            Console.WriteLine("Opção: ");

            short res = short.Parse(Console.ReadLine());

            bool executando = true;

            while (executando)
            {
                switch (res)
                {
                    case 1:
                        Soma();
                        break;

                    case 2:
                        Subtracao();
                        break;

                    case 3:
                        Divisao();
                        break;

                    case 4:
                        Mutiplicacao();
                        break;

                    case 5:
                        executando = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());

            float result = n1 + n2;

            Console.WriteLine("|---------------------------------|");

            Console.WriteLine("O resultado da soma é " + result);

            Console.WriteLine("|---------------------------------|");

            Console.ReadLine();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());

            float result = n1 - n2;

            Console.WriteLine("|---------------------------------|");

            Console.WriteLine("O resultado da subtração é " + result);

            Console.WriteLine("|---------------------------------|");

            Console.ReadLine();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());

            float result = n1 / n2;

            Console.WriteLine("|---------------------------------|");

            Console.WriteLine("O resultado da divisão é " + result);

            Console.WriteLine("|---------------------------------|");

            Console.ReadLine();
        }

        static void Mutiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float n2 = float.Parse(Console.ReadLine());

            float result = n1 * n2;

            Console.WriteLine("|---------------------------------|");

            Console.WriteLine("O resultado da multiplicação é " + result);

            Console.WriteLine("|---------------------------------|");

            Console.ReadLine();
        }
    }
}