using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operacao
{
    public class Soma:OperacaoMatematica
    {
        public override double calcular(double x, double y)
        {
            return x + y;
        }
    }
}
