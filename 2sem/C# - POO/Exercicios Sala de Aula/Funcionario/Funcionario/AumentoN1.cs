using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{
    class AumentoN1:EstrategiaAumento
    {
        public override double execute(double salario)
        {
            return salario + (double)salario * 2 / 100;
        }
    }
}
