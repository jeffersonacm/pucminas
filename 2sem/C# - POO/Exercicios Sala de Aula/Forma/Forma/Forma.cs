using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma
{
    public abstract class Forma
    {
        public abstract double calcArea();

        public abstract double calcPerimetro();

        public virtual void mensagem()
        {
            Console.Write("Realizando cálculo: ");
        }
    }
}
