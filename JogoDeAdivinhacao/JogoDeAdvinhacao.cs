using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeadiviacao
{
    public static class JogoAdivinhacaoUltra
    {
        static int totalDeTentativas = 0;
        public static void SistemaAdivinhacao(int numeroSecret)
        {
            for (int tentativa = 1; tentativa <= totalDeTentativas; tentativa++)
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine($"Tentativa {tentativa} de {totalDeTentativas}");
                Console.WriteLine("---------------------------------------------");


                Console.Write("Digite um número: ");
                int numeroDigitado = Convert.ToInt32(Console.ReadLine());

                if (numeroDigitado == numeroSecret)
                {
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Você acertou o número secreto!");
                    Console.WriteLine("---------------------------------------------");

                    break;
                }

                else if (numeroDigitado > numeroSecret)
                {
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("O número informado é maior que o número secreto!");
                    Console.WriteLine("---------------------------------------------");
                }

                else if (numeroDigitado < numeroSecret)
                {
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("O número informado é menor que o número secreto!");
                    Console.WriteLine("---------------------------------------------");
                }

                if (tentativa == totalDeTentativas)
                {
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine($"Que pena! Você Não conseguir acertar, O número secreto era " + numeroSecret);
                    Console.WriteLine("---------------------------------------------");
                }
                Console.WriteLine("Aperte ENTER para continuar...");
                Console.ReadKey();
            }
        }

        public static void Selecionador(string opcaoDificuldade)
        {
            if (opcaoDificuldade == "1")
                totalDeTentativas = 15;
            else if (opcaoDificuldade == "2")
                totalDeTentativas = 8;
            else
                totalDeTentativas = 5;
        }
    }
}