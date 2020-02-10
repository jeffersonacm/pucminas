using System;

namespace exercicio1
{
   class Program
    {
        public static String[] opcoes = new String[3] { "pedra", "papel", "tesoura"};
        public static int winners = 0;
        public static int defeats = 0;
        public static int draw = 0;

        static void Main(string[] args)
        {
            int userKey;
            String userOption;

            do
            {
                Console.Clear();
                Console.WriteLine("  Vitórias: " + winners + "\n" + "  Empates: " + draw + "\n" + "  Derrotas: " + defeats );


                Console.WriteLine("Escolha uma opção abaixo: ");
                Console.WriteLine("1 - Pedra");
                Console.WriteLine("2 - Papel");
                Console.WriteLine("3 - Tesoura");
                Console.WriteLine("4 - SAIR");

                userKey = int.Parse(Console.ReadLine());

                if (userKey == 4)
                    break;

                userOption = opcoes[userKey-1];

                Console.WriteLine("\n" + verifyResult(userOption));
                Console.ReadKey();
                
            } while (userKey != 4); 
        }

        public static string getRandomOption()
        {
            Random r = new Random();
            return opcoes[r.Next(0, 3)];
        }

        public static string verifyResult(String userOption)
        {
            String machineOption = getRandomOption();

             
            if(userOption == "pedra" && machineOption == "tesoura" || userOption == "tesoura" && machineOption == "papel" || userOption == "papel" && machineOption == "papel")
            {
                winners++;
                return "You win! A maquina escolheu " + machineOption;

            } else if(userOption == machineOption)
            {
                draw++;
                return "Empate !";

            } else
            {
                defeats++;
                return "Você perdeu! A maquina escolheu " + machineOption;
            }
        }
    }
}
