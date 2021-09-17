using System;

namespace AdivinhadorDeNumeros
{
    class Program
    {
        static void Main(string[] args)
        {

            GetAppInfo();

            GreetUser();

            while (true)
            {

                Random random = new Random();

                int correctNumber = random.Next(1, 11);

                int guess = 0;

                Console.WriteLine("Digite um número de 1 a 10 ");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Um número mano....");

                    }


                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Número errado, tente novamente!");
                    }


                }

                PrintColorMessage(ConsoleColor.Yellow, "Boa! Número certo!");

                Console.WriteLine("Jogar novamente ? [S ou N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "S")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    Console.WriteLine("Obrigado por jogar.");
                    return;
                }
                else
                {
                    return;
                }

            }

        }

        static void GetAppInfo()
        {
            string appName = "Adivinhador de Números";
            string appVersion = "1.0.0";
            string appAuthor = "Vitor Ramalho";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Versão {1}, by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();

        }

        static void GreetUser()
        {
            Console.WriteLine("Qual é o seu nome ?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, vamos jogar um jogo....", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }


    }
}
