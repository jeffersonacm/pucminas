using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R01_exercicio14_idade
{
    class Program
    {
        static void Main(string[] args)
        {
            string  dataNasc, dataAtual ;
            int idade, mes, dias, semanas;
            DateTime nascimento, atual;
            TimeSpan date;
            
            Console.Title = "Calculo idade";
            Console.WriteLine("Digite sua data de nascimento 'dd/MM/yyyy'");
            dataNasc = Console.ReadLine();

            Console.WriteLine("Digite a data atual 'dd/MM/yyyy'");
            dataAtual = Console.ReadLine();
            //dataAtual = DateTime.Now.ToString("dd/MM/yyyy");

            if (DateTime.TryParse(dataNasc, out nascimento) && DateTime.TryParse(dataAtual, out atual)) // validação das datas.
            {
                //conversão para dateTime.
                atual        = DateTime.ParseExact(dataAtual, "dd/MM/yyyy", new CultureInfo("pt-br"), DateTimeStyles.None);
                nascimento  = DateTime.ParseExact(dataNasc, "dd/MM/yyyy", new CultureInfo("pt-br"), DateTimeStyles.None);

                idade = atual.Year - nascimento.Year;
                //addYears calcula o ano resultante, levando em conta os anos bissextos.
                if (nascimento > atual.AddYears(-idade)) 
                {
                    idade--;
                }

                mes = 12 * (nascimento.Year - atual.Year) + nascimento.Month - atual.Month;
                mes = Math.Abs(mes);
                date = Convert.ToDateTime(atual) - Convert.ToDateTime(nascimento);
                dias = date.Days;
                semanas = dias / 7;

                Console.WriteLine("Você tem "+ idade+" Anos");
                Console.WriteLine("Você tem " + mes + " meses");
                Console.WriteLine("Você tem " + dias + " Dias");
                Console.WriteLine("Você tem " + semanas + " Semanas");
                Console.ReadKey();
            } else
            {
                Console.WriteLine("Data nascimento ou data atual inválida");
                Console.ReadKey();
            }
        }
    }
}
