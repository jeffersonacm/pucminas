using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{
    abstract class EstrategiaAumento
    {
        public abstract double execute(double salario);
    }
}
