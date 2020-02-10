using System;
using System.Collections.Generic;

namespace aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opinion;
            String sexo;
            int cadastrados = 0, S = 0, N = 0, F = 0, M = 0, simF = 0, naoM = 0;
            List<Search> opinions = new List<Search>();

            do {
                Console.Clear();
                Console.WriteLine("Número de usuários já cadastrados: " + cadastrados);

                sexo = questSex();
                if (sexo == null) {
                    continue;
                } 

                opinion = questOpinion();
                if (opinion == 0) {
                    continue;
                }
                
                Search p = new Search(opinion, sexo);
                opinions.Add(p);
                cadastrados++;

                System.Console.WriteLine("Pressione qualquer tecla para continuar ou ESC p/ sair");

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            foreach (Search s in opinions) {
                if (s.opinion == 1) {
                    S++;

                    if (s.sexo == "F") {
                        simF++;
                        F++;
                    } else {
                        M++;
                    }
                } else {
                    N++;
                    
                    if (s.sexo == "M") {
                        naoM++;
                        M++;
                    } else {
                        F++;
                    }
                }
            }

            System.Console.WriteLine("Pessoas que votaram sim: " + S);
            System.Console.WriteLine("Pessoas que votaram não: " + N);

            if (simF > 0)
                System.Console.WriteLine("Porcentagem de pessoas do sexo feminino que votaram sim: " + (F / simF) * 100);
            else
                System.Console.WriteLine("Não houve mulheres que votaram sim");
           
            if (naoM > 0)
                System.Console.WriteLine("Porcentagem de pessoas do sexo masculino que votaram não: " + (M / naoM) * 100);
            else 
                System.Console.WriteLine("Não houve homens que votaram não");

            Console.ReadKey();
        }

        public static String questSex() {
            String sex;

            System.Console.WriteLine("\n");
            System.Console.WriteLine("Opções: ");
            System.Console.WriteLine("F - Feminino");
            System.Console.WriteLine("M - Masculino");
            Console.Write("Me fale o seu sexo: ");
            sex = Console.ReadLine().ToUpper();

            if(sex != "M" && sex != "F") {
                System.Console.WriteLine("Opção não encontrada, tente novamente");
                return null;
            }

            return sex;
        }

        public static int questOpinion() {
            int opinion;

            System.Console.WriteLine("\n");
            System.Console.WriteLine("Opções: ");
            System.Console.WriteLine("1 - Sim");
            System.Console.WriteLine("2 - Não");
            System.Console.Write("Diga sua opinião: ");
            opinion = int.Parse(Console.ReadLine());
        
            if (opinion != 1 && opinion != 2) {
                System.Console.WriteLine("Opção não encontrada, tente novamente");
                return 0;
            }
        
            return opinion;        
        }
    }

    public class Search { 

        public int opinion;
        public String sexo;

        public Search(int opinion, String sexo) {
            this.opinion = opinion;
            this.sexo = sexo;
        }
    }
}
