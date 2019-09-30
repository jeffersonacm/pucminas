using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercico01
{
    class Numero
    {
        private int _op1;
        public int op1
        {
            get { return _op1;  }
            set { _op1 = value > 0 ? value : 0; }
        }

        private int _op2;
        public int op2
        {
            get { return _op2; }
            set { _op2 = value > 0 ? value : 0; }
        }

        public int soma()
        {
            return this.op1 + this.op2;
        }

        public int subtracao()
        {
            return this.op1 - this.op2;
        }

        public int multiplicacao()
        {
            return this.op1 * this.op2;
        }

        public int divisao()
        {
            return this.op1 / this.op2;
        }
    }
}
