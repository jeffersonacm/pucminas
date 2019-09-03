using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace R07_02
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream arq = new FileStream("teste2.txt", FileMode.Create); //Cria o arquivo teste2
            StreamWriter escreve = new StreamWriter(arq);  // grava o arquivo no objeto escreve

            string frase, tudo;
            int i = 0, contA = 0, contO = 0;

            Console.Write("Digite uma frase:");
            frase = Console.ReadLine();

            escreve.WriteLine(frase); //escreve a frase no arquivo
            escreve.Close(); //fecha o arquivo

            FileStream arq1 = new FileStream("teste2.txt", FileMode.Open); //abre o arquivo teste2
            StreamReader ler = new StreamReader(arq1); //faz a leitura do arquivo

            tudo = ler.ReadToEnd(); //le todos os caracteres

            Console.WriteLine("Tudo que foi escrito no arquivo: " + tudo);

            //contagem da quantidade de letras a e o na frase
            for (i = 0; i < tudo.Length; i++)
            {
                if (tudo[i] == 'a')
                {
                    contA++;
                }

                if (tudo[i] == 'o')
                {
                    contO++;
                }
            }

            Console.WriteLine("A quantidade de letra a é:" + contA);
            Console.WriteLine("A quantidade de letra o é:" + contO);
            Console.ReadKey();
        }
    }
}
