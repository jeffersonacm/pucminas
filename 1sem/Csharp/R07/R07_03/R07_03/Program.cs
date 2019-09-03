
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace R07_03
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream("R07_03.txt", FileMode.Create);
            StreamWriter escreve = new StreamWriter(file);

            string text, linha = "text";
            int linhas = 0;

            while (1==1)
            {
                Console.Write("Digite uma linha (Para sair digite sair) : ");
                text = Console.ReadLine();

                if (text.ToLower() == "sair")
                {
                    break;
                }
                escreve.WriteLine(text);
            }

            escreve.Close();

            FileStream file1 = new FileStream("R07_03.txt", FileMode.Open);
            StreamReader ler = new StreamReader(file1);


            Console.WriteLine("\nAs linhas digitadas foram: ");
            while (linha != null)
            {
                linha = ler.ReadLine();

                if(linha != null)
                {
                    Console.WriteLine(linha);
                    linhas++;
                }
            }

            Console.WriteLine("\nForam digitadas " + linhas + " linhas");
            file1.Close();
            Console.ReadKey();
        }
    }
}
