using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaDENO
{
    public class Lista
    {
        private Elemento Inicio;            // Primeiro elemento da lista
        private Elemento Fim;               // Último elemento da lista
        private Elemento Aux;               // Objeto auxiliar

        public int Tamanho;                 // Número de Elementos da Lista

        public Lista()                      // Construtor da Classe
        {
            Inicio = null;
            Fim = null;
            Tamanho = 0;
        }

        public void InserirFinal(int Valor)
        {
            Elemento Novo = new Elemento();     // Alocação Dinâmica - Novo Elemento para a Lista

            Novo.Num = Valor;                   // Insere o valor do elemento na lista

            if (Inicio == null)                 // A lista está vazia? Primeiro elemento...
            {
                Inicio = Novo;                  // O elemento inserido é o primeiro e o último. Guarda o endereço dele.
                Fim = Novo;

                Novo.Prox = null;               // O ponteiro para o próximo elemento passa a ser nulo
                Novo.Ant = null;                // O ponteior para o elemento anterior para a ser nulo
            }
            else                                // A lista já possui elementos?
            {
                Fim.Prox = Novo;                // O elemento que era o último da lista aponta para o elemento inserido
                Novo.Ant = Fim;                 // O ponteiro anterior do novo elemento aponta para o que já existia
                Novo.Prox = null;               // O ponteiro próximo do novo elemento aponta para nada, já que ele é o último
                Fim = Novo;                     // Atualiza o último: o elemento final passa a ser o novo elemento inserido
            }

            Tamanho++;                          // O elemento entrou na lista
        }

        public void MostraLista()
        {
            Console.Clear();            // Limpa a tela

            if (Inicio == null)         // Se não tem elemento na lista...
            {
                Console.WriteLine("A lista não possui nenhum elemento!!! \n\n");
                Console.ReadKey();
            }
            else                        // Se a lista tem pelo menos um elemento
            {
                Console.WriteLine("Elementos da Lista: {0}\n", Tamanho);

                Aux = Inicio;           // Pega o primeiro elemento

                while (Aux != null)     // Enquanto a lista tiver elementos que apontam para outro elemento da lista
                {
                    Console.WriteLine("{0,5}", Aux.Num);        // Mostra o elemento,
                    Aux = Aux.Prox;                             // aponta para o próximo elemento
                }                                               // e volta

                Console.ReadKey();
            }
        }

        //Função para retirar um elemento da lista
        public void RetiraElemento(int Valor)
        {
            Console.WriteLine(Valor);
            if (Inicio == null)                     // Se não tem elemento na lista...
            {
                Console.WriteLine("A lista não possui nenhum elemento!!! \n\n");        // Mostra
            }
            else                                    // A lista não está vazia
            {
                Aux = Inicio;                       // Pega o endereço do primeiro elemento

                int Achou = 0;                      // Variável para contar quantas vezes o elemento é encontrado na lista

                while (Aux != null)                 // Enquanto a lista tiver elementos que apontam para outro elemento da lista
                {
                    if (Aux.Num == Valor)           // O número digitado foi encontrado na lista
                    {
                        Achou++;                    // Conta ocorrência

                        if (Aux == Inicio)                  // O número a ser removido é o primeiro da lista?
                        {
                            Inicio = Aux.Prox;              // O primeiro elemento foi removido e ele ganha o endereço do da frente

                            if (Inicio != null)             // Se o elemento existe
                            {
                                Inicio.Ant = null;          // O ponteiro anterior dele não aponta para nada, já que ele é o primeiro
                            }

                            Aux = Inicio;                   // Armazena o endereço dele para o próximo uso

                            Tamanho--;                      // Diminui o tamanho da lista
                        }
                        else if (Aux == Fim)                // O número a ser removido é o último da lista?
                        {
                            Fim = Fim.Ant;                  // Ele ganha o endereço do último
                            Fim.Prox = null;                // e o ponteiro próximo aponta para nada, já que ele é o último
                            Aux = null;                     // O Aux agora também aponta para nada

                            Tamanho--;                      // Diminui o tamanho da lista
                        }
                        else                                // O número a ser removido está no meio da lista?
                        {
                            // O endereço próximo do elemento anterior ao elemento atual (que será removido)
                            // terá o endereço do elemento posterior ao elemento atual
                            Aux.Ant.Prox = Aux.Prox;

                            // O endereço anterior do elemento posterior ao elemento atual
                            // terá o endereço do elemento anterior ao elemento atual
                            Aux.Prox.Ant = Aux.Ant;

                            Aux = Aux.Prox;                 // Próximo elemento

                            Tamanho--;                      // Diminui o tamanho da lista
                        }
                    }
                    else                                    // reposiciona para o próximo elemento da lista
                    {
                        Aux = Aux.Prox;
                    }
                }                                           // e volta para nova pesquisa
            }
        }

        public void InsereAlunosTurma(int n)
        {
            int numeroDoAluno = 1;
            Elemento ele;

            for (int i = 0; i < n; i++)
            {
                InserirFinal(numeroDoAluno);
                numeroDoAluno++;
            }

            ele = Inicio;
        }

        public int BuscaLiderTurma(int totalAlunos, int primeroAluno, int intervalo)
        {
            Boolean acheiAluno = false;

            InsereAlunosTurma(totalAlunos);

            if (Inicio != null)
            {
                Aux = Inicio;           // Pega o primeiro elemento

                while (Tamanho > 1) 
                {
                    if (! acheiAluno)
                    {
                        if (Aux.Num == primeroAluno)
                        {
                            acheiAluno = true;
                        } else
                        {
                            Aux = Aux.Prox;
                        }
                    }

                    if (acheiAluno)
                    {
                        //pulando pelos intervalos
                        for (int i = 0; i < intervalo; i++)
                        {
                            if (Aux == null)
                            {
                                Aux = Inicio.Prox;
                            } else
                            {
                                Aux = Aux.Prox;
                            }
                        }

                        //retirando
                        if (Aux == null)
                        {
                            RetiraElemento(Inicio.Num);
                        }
                        else
                        {
                            RetiraElemento(Aux.Num);
                        }
                    }

                    if (Tamanho == 1)
                    {
                        break;
                    }
                }
            }

            return Inicio.Num;
        }
    }
}
