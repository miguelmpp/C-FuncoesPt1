using System;

namespace MyApp
{
    internal class Program
    {
        static double raio = 0;

        static double baseValor = 0;

        static double altura = 0;

        static double comprimento = 0;

        static double largura = 0;

        static void Print(string value)
        {
            Console.WriteLine(value);
        }

        /// <summary>
        /// Imprime um número no console.
        /// </summary>
        /// <param name="value">Valor numérico a ser exibido.</param>
        static void Print(double value)
        {
            Console.WriteLine(value);
        }

        /// <summary>
        /// Função que calcula a área do círculo.
        /// </summary>
        /// <param name="value">Raio do círculo.</param>
        /// <returns>Área do círculo.</returns>
        static double AreadoCicurlo(double value)
        {
            double r = 0;
            r = Math.Pow(value, 2) * Math.PI; // π * r²
            return r;
        }

        /// <summary>
        /// Função que calcula a área do retângulo.
        /// </summary>
        /// <param name="b">Base (ou comprimento) do retângulo.</param>
        /// <param name="h">Altura (ou largura) do retângulo.</param>
        /// <returns>Área do retângulo.</returns>
        static double AreadoRetangulo(double b, double h)
        {
            double r = 0;
            r = b * h;
            return r;
        }

        /// <summary>
        /// Função que calcula a área do triângulo.
        /// </summary>
        /// <param name="b">Base do triângulo.</param>
        /// <param name="h">Altura do triângulo.</param>
        /// <returns>Área do triângulo.</returns>
        static double AreadoTriangulo(double b, double h)
        {
            double r = 0;
            r = (b * h) / 2;
            return r;
        }

        /// <summary>
        /// Ponto de entrada do programa: lê dados do usuário e calcula a área escolhida.
        /// </summary>
        /// <param name="args">Argumentos da linha de comando (não utilizados).</param>
        static void Main(string[] args)
        {
            Print("ola seja bem vindo! ");
            Print("Digite o seu nome");
            var name = Console.ReadLine();

            Console.WriteLine(name + " escolha qual área deseja calcular: 1-círculo 2-triângulo 3-retângulo: ");
            int escolha = int.Parse(Console.ReadLine());

            if (escolha == 1)
            {
                Print("Digite o valor do raio: ");
                raio = double.Parse(Console.ReadLine());
                Print("A área do círculo é: ");
                Print(AreadoCicurlo(raio));
            }
            else if (escolha == 2)
            {
                Print("Digite o valor da base: ");
                baseValor = double.Parse(Console.ReadLine());
                Print("Digite o valor da altura: ");
                altura = double.Parse(Console.ReadLine());
                Print("A área do triângulo é: ");
                Print(AreadoTriangulo(baseValor, altura));
            }
            else if (escolha == 3)
            {
                Print("Digite o valor do comprimento: ");
                comprimento = double.Parse(Console.ReadLine());
                Print("Digite o valor da largura: ");
                largura = double.Parse(Console.ReadLine());
                Print("A área do retângulo é: ");
                Print(AreadoRetangulo(comprimento, largura));
            }
            else
            {
                Print("Opção inválida!");
            }
        }
    }
}
