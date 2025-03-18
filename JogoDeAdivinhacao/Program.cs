
using JogoDeadiviacao;

namespace JogoDeAdivinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                MenuExibir();
                Console.Write("Digite sua escolha: ");
                JogoAdivinhacaoUltra.Selecionador(Console.ReadLine());

                Random geradorNumeros = new Random();
                int numeroSecret = geradorNumeros.Next(1, 50);
                JogoAdivinhacaoUltra.SistemaAdivinhacao(numeroSecret);

                Console.WriteLine("Deseja continuar? (s/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }

        static void MenuExibir()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Jogo de Adivinhação");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Escolha um nível de dificuldade:");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1 - Fácil (15 tentativas)");
            Console.WriteLine("2 - Normal (8 tentativas)");
            Console.WriteLine("3 - Difícil (5 tentativas)");
            Console.WriteLine("----------------------------------------");
        }
    }
}