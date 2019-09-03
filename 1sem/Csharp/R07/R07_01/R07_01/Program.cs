using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace R07_01
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream arq = new FileStream("teste.txt", FileMode.Create); //Criar arquivo texte na pasta padrão

            StreamWriter escreve = new StreamWriter(arq); // Grava o arquivo no objeto escreve
            string nome, linha, endereco; 

            for (int i = 0; i < 5; i++) // loop 5
            {
                Console.Write("Digite seu nome:");
                nome = Console.ReadLine(); 
                Console.Write("Digite seu endereço:");
                endereco = Console.ReadLine();
                escreve.WriteLine("Nome: " + nome + "," + "Endereço: " + endereco + ","); // atribuição dos itens digitados no arquivo
            }

            escreve.Close();  // fechando arquivo

            FileStream arq1 = new FileStream("teste.txt", FileMode.Open); // abre o arquivo teste
            StreamReader ler = new StreamReader(arq1);  // faz a leitura do arquivo

            string[] resultado;

            do
            {
                linha = ler.ReadLine(); // le a primeira linha

                if (linha != null)
                {
                    resultado = linha.Split(','); //transforma a linha em array, pegando os valores pela virgula
                    Console.WriteLine(resultado[0]);
                    Console.WriteLine(resultado[1]);
                }

            } while (linha != null); // enquanto tiver linhas

            Console.ReadKey();
        }
    }
}
