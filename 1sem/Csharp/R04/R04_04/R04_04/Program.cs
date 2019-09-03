using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R04_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string sexo, corOlhos, corCabelo, continuar = "s";
            double idade = 0, peso =0, altura=0, m = 0, f = 0;
            int cabeloOlho = 0, i=0;
            Boolean valid = false, olhoVerde = false;

            while(continuar == "s")
            {
                if(continuar != "s")
                {
                    continue;
                }

                Console.WriteLine("---------------------------------------------------------");
                while (valid == false)
                {
                    Console.WriteLine("Informe o sexo: \n M - Masculino \n F - Feminino");
                    sexo = Console.ReadLine().ToLower();

                    if (sexo == "m")
                    {
                        m++;
                        valid = true;
                    } else if(sexo == "f")
                    {
                        f++;
                        valid = true;
                    } else
                    {
                        Console.WriteLine("Opção inválida!");
                    }
                }
                valid = false;

                while (valid == false)
                {
                    Console.WriteLine("Informe a cor dos olhos: \n A - Azul \n V - Verde \n C - Castanho");
                    corOlhos = Console.ReadLine().ToLower();

                    if(corOlhos != "a" && corOlhos != "v" && corOlhos != "c")
                    {
                        Console.WriteLine("Opção inválida!");
                    } else
                    {
                        if (corOlhos == "v")
                            olhoVerde = true;
                        valid = true;
                    }
                }
                valid = false;

                while (valid == false)
                {
                    Console.WriteLine("Informe a cor do cabelo: \n L - Loiro \n C - Castanho \n P - Preto");
                    corCabelo = Console.ReadLine().ToLower();

                    if (corCabelo != "l" && corCabelo != "c" && corCabelo != "p")
                    {
                        Console.WriteLine("Opção inválida!");
                    }
                    else
                    {
                        if (corCabelo == "l" && olhoVerde == true)
                            cabeloOlho ++;
                        valid = true;
                        olhoVerde = false;
                    }
                }
                valid = false;

                Console.WriteLine("Infome a idade:");
                idade += double.Parse(Console.ReadLine());

                Console.WriteLine("Infome a altura (em centímetros):");
                altura += double.Parse(Console.ReadLine());

                Console.WriteLine("Infome o peso:");
                peso += double.Parse(Console.ReadLine());

                while (valid == false)
                {
                    Console.WriteLine("Deseja continuar? \n S - Sim \n N - Não");
                    continuar = Console.ReadLine().ToLower();

                    if (continuar != "n" && continuar != "s")
                    {
                        Console.WriteLine("Opção inválida!");
                    }
                    else
                    {
                        valid = true;
                    }
                }
                valid = false;
                i++;
            }

            Console.WriteLine("A porcentagem de homens é " + (m / (f + m)) * 100 + "% \n" +
                            "A porcentagem de mulheres é " + (f / (f + m)) * 100 + "% \n" +
                            "Possuem " + cabeloOlho + " pessoa(s) com olhos verdes e cabelo loiro" + "\n" +
                            "A média de peso é " + Math.Round(peso / i, 2) + " kg \n" +
                            "A média de idade é "+ Math.Round(idade / i, 2) + " anos \n" +
                            "A média de altura é " + Math.Round(altura /i, 2) / 100 + " Metros");
            Console.ReadKey();
        }
    }
}
