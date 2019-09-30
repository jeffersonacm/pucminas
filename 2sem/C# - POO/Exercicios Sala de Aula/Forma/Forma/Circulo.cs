using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma
{
    public class Circulo:Forma
    {
        public double raio { get; set; }

        public override double calcArea()
        {
            return Math.PI * Math.Pow(raio, 2);
        }

        public override double calcPerimetro()
        {
            return 2 * Math.PI * raio;
        }

        public override void mensagem()
        {
            base.mensagem();

            Console.WriteLine("Círculo");
        }
    }
}
