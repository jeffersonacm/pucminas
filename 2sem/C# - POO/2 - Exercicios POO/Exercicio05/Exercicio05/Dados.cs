using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Dados
    {
        private ArrayList Cadastro;

        public Dados()
        {
            this.Cadastro = new ArrayList();
        }

        public void CadastrarVeiculo(Veiculo x)
        {
            x.Cadastrar();
            this.Cadastro.Add(x);
        }

        public void Listar(string placa = null)
        {
            Console.Clear();

            foreach (Veiculo x in this.Cadastro)
            {
                Console.WriteLine("Marca do veiculo {0} - modelo: {1}", x.marca, x.modelo);
                Console.WriteLine("Placa: {0} Ano : {1}", x.placa, x.anoFabricacao);
                Console.WriteLine("Categoria: {0}", x.categoria);
                Console.WriteLine("Km inicial: {0} km final: {1}:", x.kmInicial, x.kmFinal);

                if (x.categoria == 'p')
                {
                    Console.WriteLine("tipo de combustivel {0}", x.combustivel);
                    Console.WriteLine("ar condicionado: ", x.ar);
                    Console.WriteLine("Quantidade de portas: ", + x.portas);
                }
                else
                {
                    Console.WriteLine("capacidade de carga: " +x.capacidadeCarga);
                }
            }

            Console.ReadKey();
        }
    }
}
