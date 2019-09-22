using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Veiculo
    {
        public string placa;
        public string marca;
        public string modelo;
        public int anoFabricacao;
        public char categoria;
        public double kmInicial;
        public double kmFinal;
        public double capacidadeCarga;
        public char ar;
        public int portas;
        public string combustivel;

        public void Cadastrar()
        {
            Console.Write("Infome a placa.....................: ");
            this.placa = Console.ReadLine();

            Console.Write("Infome o modelo....................: ");
            this.modelo = Console.ReadLine();

            Console.Write("Infome o ano de fabricação.........: ");
            this.anoFabricacao = int.Parse(Console.ReadLine());

            Console.Write("Infome a Kilometragem inicial... ..: ");
            this.kmInicial = int.Parse(Console.ReadLine());

            Console.Write("Infome o Kilometragem Final........: ");
            this.kmFinal = int.Parse(Console.ReadLine());

            Console.Write("Infome a categoria (P para passeio e C para carga) : ");
            this.categoria = char.Parse(Console.ReadLine().ToLower());

            if(categoria == 'p')
            {
                Console.Write("Infome o tipo de combustivel...: ");
                this.combustivel = Console.ReadLine();

                Console.Write("Possui ar ? (s ou n)...........: ");
                this.ar = char.Parse(Console.ReadLine().ToLower());

                Console.Write("Quantidade de portas...........: ");
                this.portas = int.Parse(Console.ReadLine());
            }
            else
            {               
                Console.Write("Infome a capacidade de carga.......: ");
                this.capacidadeCarga = int.Parse(Console.ReadLine());
            }
        }
    }
}
