using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaDENO
{
    public class Elemento
    {
        public int Num;
        public Elemento Prox;
        public Elemento Ant;

        public Elemento()                   // Construtor da Classe
        {
            Num = 0;
            Prox = null;
            Ant = null;
        }
    }
}
