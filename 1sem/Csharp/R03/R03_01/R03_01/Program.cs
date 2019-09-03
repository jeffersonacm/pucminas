using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R03_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,idade, countF = 0, countM=0, countExpF=0, homens35a45=0, idadeMinimaM =0, countExpM = 0;
            double idadeMedia=0, idadeMediaExp=0;
            string sexo,experiencia;

            for(i=1; i<=2; i++)
            {
                Console.WriteLine("------------------------" + i + " º funcionário------------------------");
                Console.WriteLine("Informe sua idade");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Possui experiencia ? S para sim e N para não");
                experiencia = Console.ReadLine().ToLower();
                Console.WriteLine("Informe o sexo, M para masculino e F para feminino");
                sexo = Console.ReadLine().ToLower();
                idadeMinimaM = idade;
                if (sexo == "f")
                {
                    if(idade < idadeMinimaM)
                    {
                        idadeMinimaM = idade;
                    }

                    countF++;
                    if (experiencia == "s")
                    {
                        countExpF++;
                        idadeMediaExp = idadeMediaExp + idade;
                    }

                } else if(sexo == "m")
                {
                    idadeMedia = idade + idadeMedia;
                    countM++;
                    if(idade > 35 && idade < 45)
                    {
                        homens35a45++;
                    }

                    if (experiencia == "s")
                    {
                        countExpM++;                        
                    }
                }
            }
            idadeMedia    = idadeMedia / countM;
            if(countExpF > 1)
                idadeMediaExp = idadeMediaExp / countExpF;
            homens35a45   = (homens35a45 / countM) * 100;

            Console.WriteLine("Quantidade de candidatos do sexo feminino: " + countF + "\n" +
                "Quantidade de candidatos do sexo masculino "+ countM + "\n"+
                "Idade média dos homens: "+idadeMedia+" Anos\n"+
                "Idade média das mulheres com experiência "+ idadeMediaExp + " Anos \n"+
                "Porcentagem dos homens entre 35 e 45 anos entre o total dos homens " + homens35a45 + " % \n"+
                "Menor idade entre as mulheres "+ idadeMinimaM+" Anos \n"+
                "Porcentagem total (homens e mulheres) com experiência no serviço " + countExpM + countExpF + "%");
            Console.ReadKey();


        }
    }
}
