using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R02_04
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3;
            string c1, c2, c3;

            Console.WriteLine("Digite a primeira nota");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota");
            n3 = double.Parse(Console.ReadLine());

            if (n1 > 8 && n1 <= 10)
            {
                c1 = "A";
            } else if (n1 > 7 && n1 <= 8)
            {
                c1 = "B";
            } else if (n1 > 6 && n1 <= 7)
            {
                c1 = "C";
            } else if (n1 > 5 && n1 <= 6){
                c1 = "D";
            } else if (n1 > 0 && n1 <= 5)
            {
                c1 = "E";
            } else
            {
                c1 = "não foi possivel calcular o conceito pois a nota é inválida";
            }
            
            if (n2 > 8 && n2 <= 10)
            {
                c2 = "A";
            }
            else if (n2 > 7 && n2 <= 8)
            {
                c2 = "B";
            }
            else if (n2 > 6 && n2 <= 7)
            {
                c2 = "C";
            }
            else if (n2 > 5 && n2 <= 6)
            {
                c2 = "D";
            }
            else if (n2 > 0 && n2 <= 5)
            {
                c2 = "E";
            }
            else
            {
                c2 = "não foi possivel calcular o conceito pois a nota é inválida";
            }

            if (n3 > 8 && n3 <= 10)
            {
                c3 = "A";
            }
            else if (n3 > 7 && n3 <= 8)
            {
                c3 = "B";
            }
            else if (n3 > 6 && n3 <= 7)
            {
                c3 = "C";
            }
            else if (n3 > 5 && n3 <= 6)
            {
                c3 = "D";
            }
            else if (n3 > 0 && n3 <= 5)
            {
                c3 = "E";
            }
            else
            {
                c3 = "não foi possivel calcular o conceito pois a nota é inválida";
            }
            
            Console.WriteLine("Os conceitos são: \n Primeira nota: "+c1+"\n Segunda nota: "+c2+"\n Terceira nota: "+c3+"");
            Console.ReadKey();

        }
    }
}
