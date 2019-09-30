using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{
    class AumentoSalarial
    {
        private EstrategiaAumento minhaEstrategiaAumento;

        public void setaEstrategia(EstrategiaAumento e)
        {
            this.minhaEstrategiaAumento = e;
        }

        public double executeEstrategia(double salario)
        {
            double salarioAtualizado;

            salarioAtualizado = minhaEstrategiaAumento.execute(salario);

            return salarioAtualizado;
        }
    }
}
