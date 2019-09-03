using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R03_livro_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade,i,primeira=0, segunda=0, terceira=0,quarta=0,quinta=0;

            for (i=1; i<=8; i++)
            {
                Console.WriteLine("\n Informe a idade:");
                idade = double.Parse(Console.ReadLine());
                if(idade <= 15)
                {
                    primeira++;
                } else if(idade >= 16 && idade <= 30)
                {
                    segunda++;
                } else if(idade >= 31 && idade <= 45)
                {
                    terceira++;
                } else if(idade >= 46 && idade <= 60)
                {
                    quarta++;
                } else
                {
                    quinta++;
                }               
            }

            Console.WriteLine("Existem " + primeira + " pessoas na primeira faixa etária \n" +
                "Existem " + segunda  + " pessoas na segunda faixa etária \n" + 
                "Existem " + terceira + " pessoas na terceira faixa etária \n" +
                "Existem " + quarta   + " pessoas na quarta faixa etária \n" + 
                "Existem " + quinta   + " pessoas na quinta faixa etária \n\n"+
                "A primeira faixa etária representa " + (primeira / 8) * 100 + " % do total de pessoas\n" +
                "A ultima faixa etária representa "   + (quinta / 8) * 100   + " % do total de pessoas");
            Console.ReadKey();
        }
    }
}
