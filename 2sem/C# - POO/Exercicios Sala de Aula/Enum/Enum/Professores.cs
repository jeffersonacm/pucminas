using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    abstract class Professores
    {
        public enum mes { Janeiro, Fevereiro, Março, Abril, Maio, Junho, Julho, Agosto,
            Setembro, Outubro, Novembro, Dezembro };

        public string  nome { get; set; }
        public string disciplina { get; set; }
        public string dataNasc { get; set; }

        public abstract void mostraDados();

        public virtual void mostraDiaAniversario()
        {
            Console.WriteLine("\nO(a) professor(a) nasceu no dia {0}", dataNasc.Substring(0,2));
        }
    }
}
