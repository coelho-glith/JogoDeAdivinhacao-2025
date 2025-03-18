internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Jogo De Adivinhacao");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Escolha um nível de dificuldade: ");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("1 - Fácil (10 tentativas)");
            Console.WriteLine("2 - Normal (5 tentativas)");
            Console.WriteLine("3 - Difícil (3 tentativas)");
            Console.WriteLine("---------------------------------------------");

            int totalDeTentativas = 0;

            Console.Write("Digite sua escolha de dificuldade: ");
            string opcaoDificuldade = Console.ReadLine();

            if (opcaoDificuldade == "1")
                totalDeTentativas = 10;
            else if (opcaoDificuldade == "2")
                totalDeTentativas = 5;
            else
                totalDeTentativas = 3;

            Random geradorNumeros = new Random();
            int numeroSecreto = geradorNumeros.Next(1, 21);



            for (int tentativa = 1; tentativa <= totalDeTentativas; tentativa++)
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine($"Tentativa {tentativa} de {totalDeTentativas}");
                Console.WriteLine("---------------------------------------------");


                Console.Write("Digite um número: ");
                int numeroDigitado = Convert.ToInt32(Console.ReadLine());

                if (numeroDigitado == numeroSecreto)
                {
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Você acertou o número secreto!");
                    Console.WriteLine("---------------------------------------------");

                    break;
                }

                else if (numeroDigitado > numeroSecreto)
                {
                    Console.WriteLine("---------------------------------------------");

                    Console.WriteLine("O número informado é maior que o número secreto! Cuidado.");
                    Console.WriteLine("---------------------------------------------");
                }

                else if (numeroDigitado < numeroSecreto)
                {
                    Console.WriteLine("---------------------------------------------");

                    Console.WriteLine("O número informado é menor que o número secreto! Cuidado.");
                    Console.WriteLine("---------------------------------------------");
                }
            }
        }
    }
}