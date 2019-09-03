using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R03_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int meses, i;
            double imposto,result=0;

            for (i=1; i <=10; i++)
            {
                Console.WriteLine("---------- "+i+"º Priprietário ----------");
                Console.WriteLine("Digite o valor do imposto");
                imposto = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite os meses de atraso");
                meses = int.Parse(Console.ReadLine());

                if (imposto <= 50)
                {                  
                    result = result + (imposto * (0.01 * meses));
                } else if (imposto >= 51 && imposto <= 180)
                {
                    result = result + (imposto * (0.02 * meses));
                } else if (imposto >= 181 && imposto <= 500)
                {
                    result = result + (imposto * (0.04 * meses));
                } else if (imposto >= 501 && imposto <= 1200)
                {
                    result = result +  (imposto * (0.07* meses));
                }
                else if (imposto > 1200)
                {
                     result = result + (imposto * (0.1*meses));
                }


            }
            Console.WriteLine("O total de é atraso é "+ result);
            Console.ReadKey();
        }
    }
}
