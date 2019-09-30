using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma
{
    class Quadrado:Forma
    {
        public double lado { get; set; }

        public override double calcArea()
        {
            return lado * lado;
        }

        public override double calcPerimetro()
        {
            return lado * 4;
        }

        public override void mensagem()
        {
            base.mensagem();

            Console.WriteLine("Quadrado");
        }

    }
}
