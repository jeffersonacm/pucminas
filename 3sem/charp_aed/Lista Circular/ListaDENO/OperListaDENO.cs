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

    public class Lista
    {
        private Elemento Início;            // Primeiro elemento da lista
        private Elemento Fim;               // Último elemento da lista
        private Elemento Aux;               // Objeto auxiliar

        public int Tamanho;                 // Número de Elementos da Lista

        public Lista()                      // Construtor da Classe
        {
            Início = null;
            Fim = null;
            Tamanho = 0;
        }

        // Função para inserir um elemento no início da lista
        public void InserirInício(int Valor)
        {
            Elemento Novo = new Elemento();     // Alocação Dinâmica - Novo Elemento para a Lista

            Novo.Num = Valor;                   // Insere o valor do elemento na lista

            if (Início == null)                 // A lista está vazia? Primeiro elemento...
            {
                Início = Novo;                  // O elemento inserido é o primeiro e o último. Guarda o endereço dele.
                Fim = Novo;

                Novo.Prox = null;               // O ponteiro para o próximo elemento passa a ser nulo
                Novo.Ant = null;                // O ponteiro para o elemento anterior passa a ser nulo
            }
            else                                // A lista já possui elementos?
            {
                Novo.Prox = Início;             // O elemento Novo aponta para o elemento que já havia sido inserido anteriormente
                Início.Ant = Novo;              // O ponteiro anterior do elemento já existente aponta para o novo elemento
                Novo.Ant = null;                // Já que é o primeiro, o ponteiro anterior aponta para null
                Início = Novo;                  // e o Início passa a ter o endereço do elemento Novo que acabou de ser inserido
            }

            Tamanho++;                          // O elemento entrou na lista
        }

        // Função para inserir um elemento no final da lista
        public void InserirFinal(int Valor)
        {
            Elemento Novo = new Elemento();     // Alocação Dinâmica - Novo Elemento para a Lista

            Novo.Num = Valor;                   // Insere o valor do elemento na lista

            if (Início == null)                 // A lista está vazia? Primeiro elemento...
            {
                Início = Novo;                  // O elemento inserido é o primeiro e o último. Guarda o endereço dele.
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

        //Função para mostrar todos os elementos da lista do Início ao Fim
        public void MostraListaINIFIM()
        {
            Console.Clear();            // Limpa a tela

            if (Início == null)         // Se não tem elemento na lista...
            {
                Console.WriteLine("A lista não possui nenhum elemento!!! \n\n");
                Console.ReadKey();
            }
            else                        // Se a lista tem pelo menos um elemento
            {
                Console.WriteLine("Elementos da Lista: {0}\n", Tamanho);

                Aux = Início;           // Pega o primeiro elemento

                while (Aux != null)     // Enquanto a lista tiver elementos que apontam para outro elemento da lista
                {
                    Console.WriteLine("{0,5}", Aux.Num);        // Mostra o elemento,
                    Aux = Aux.Prox;                             // aponta para o próximo elemento
                }                                               // e volta

                Console.ReadKey();
            }
        }

        //Função para mostrar todos os elementos da lista do Fim ao Início
        public void MostraListaFIMINI()
        {
            Console.Clear();            // Limpa a tela

            if (Início == null)         // Se não tem elemento na lista...
            {
                Console.WriteLine("A lista não possui nenhum elemento!!! \n\n");
                Console.ReadKey();
            }
            else                        // Se a lista tem pelo menos um elemento
            {
                Console.WriteLine("Elementos da Lista: {0}\n", Tamanho);

                Aux = Fim;              // Pega o último elemento

                while (Aux != null)     // Enquanto a lista tiver elementos que apontam para algum elemento anterior da lista
                {
                    Console.WriteLine("{0,5}", Aux.Num);        // Mostra o elemento,
                    Aux = Aux.Ant;                              // aponta para o elemento anterior
                }                                               // e volta

                Console.ReadKey();
            }
        }

        //Função para retirar um elemento da lista
        public void RetiraElemento(int Valor)
        {
            Console.Clear();                        // Limpa a tela

            if (Início == null)                     // Se não tem elemento na lista...
            {
                Console.WriteLine("A lista não possui nenhum elemento!!! \n\n");        // Mostra
                Console.ReadKey();
            }
            else                                    // A lista não está vazia
            {
                Aux = Início;                       // Pega o endereço do primeiro elemento

                int Achou = 0;                      // Variável para contar quantas vezes o elemento é encontrado na lista

                while (Aux != null)                 // Enquanto a lista tiver elementos que apontam para outro elemento da lista
                {
                    if (Aux.Num == Valor)           // O número digitado foi encontrado na lista
                    {
                        Achou++;                    // Conta ocorrência

                        if (Aux == Início)                  // O número a ser removido é o primeiro da lista?
                        {
                            Início = Aux.Prox;              // O primeiro elemento foi removido e ele ganha o endereço do da frente

                            if (Início != null)             // Se o elemento existe
                            {
                                Início.Ant = null;          // O ponteiro anterior dele não aponta para nada, já que ele é o primeiro
                            }

                            Aux = Início;                   // Armazena o endereço dele para o próximo uso

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
                            // Um pouco mais confuso...

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

                if (Achou == 0)                             // Não encontrou o número na lista
                {
                    Console.WriteLine("O valor {0} não foi encontrado na lista!!! \n", Valor);
                }
                else if (Achou == 1)                        // Achou uma ocorrência
                {
                    Console.WriteLine("O valor {0} foi encontrado na lista e removido!!! \n", Valor);
                }
                else                                        // Achou mais de uma ocorrência
                {
                    Console.WriteLine("O valor {0} foi encontrado {1} vezes na lista e removido!!! \n", Valor, Achou);
                }

                Console.WriteLine("Número de Elementos da Lista: {0}\n\n", Tamanho);
                Console.ReadKey();
            }
        }

        //Função para esvaziar toda a lista
        public void EsvaziarLista()
        {
            if (Início == null)                     // Se não tem elemento na lista...
            {
                Console.WriteLine("A lista não possui nenhum elemento!!! \n\n");        // Mostra
                Console.ReadKey();
            }
            else                                    // A lista não está vazia
            {
                Início = null;                      // O Início da Lista não aponta para ninguém...
                Tamanho = 0;
            }
        }

        public void TrocarElementos(int m, int n)
        {
            Elemento primeiro, segundo, aux2, aux3;
            Boolean fim = false;
            primeiro = new Elemento();
            segundo = new Elemento();
            aux2 = new Elemento();
            aux3 = new Elemento();

            if (Início == null)                     // Se não tem elemento na lista...
            {
                Console.WriteLine("A lista não possui nenhum elemento!!! \n\n");        // Mostra
                Console.ReadKey();
            }
            else                                    // A lista não está vazia
            {
                Aux = Início;                       // Pega o endereço do primeiro elemento

                while (Aux != null)                 // Enquanto a lista tiver elementos que apontam para outro elemento da lista
                {
                    if (Aux.Num == m)           // O número digitado foi encontrado na lista
                    {
                        primeiro.Ant = Aux.Ant;
                        primeiro.Prox = Aux.Prox;
                        primeiro.Num = Aux.Num;
                    }

                    if (Aux.Num == n)           // O número digitado foi encontrado na lista
                    {
                        segundo.Ant = Aux.Ant;
                        segundo.Prox = Aux.Prox;
                        segundo.Num = Aux.Num;
                    }

                    Aux = Aux.Prox;
                }                                // e volta para nova pesquisa

                Aux = Início;

            }

            if (primeiro == aux2 || segundo == aux2)
            {
                Console.WriteLine("Não foi possível encontrar os elementos com os valores passados!");
                return;
            }

            //Guardando meus apontadores
            aux2 = primeiro.Prox;

            if (segundo.Prox != null)
            {
                aux3 = segundo.Prox;
            } else
            {
                //como não tenho o próximo, (se por acaso for trocado o ultimo da lista), salvo o anterior para passar depois para o M
                fim = true;
                aux3 = segundo.Ant;
            }

            //Adicionadas algumas verificações para evitar problemas caso meu elemento seja o primero da lista
            if (primeiro.Ant != null)
            {
                primeiro.Ant.Prox = segundo;
            }
            else
            {
                Início = segundo;
            }

            if (segundo.Ant != null)
            {
                segundo.Ant = primeiro.Ant;
            }

            segundo.Prox = primeiro.Prox;

            if (primeiro.Prox != null)
            {
                primeiro.Prox.Ant = segundo;
            }

            if (primeiro != Início)
            {
                primeiro.Ant = aux2;
            }

            if (! fim)
            {
                primeiro.Prox = aux3;
            } else
            {
                primeiro.Prox = null;
            }
                
            //verificação para evitar erro caso um dos elementos da troca seja o PRIMERO elemento
            if (aux3.Ant != null)
            {
                aux3.Ant = primeiro;
            }

            //verificação para evitar erro caso um dos elementos da troca seja o ULTIMO elemento
            if (aux2.Prox != null)
            {
                aux2.Prox = primeiro;
            }
        }
    }
}
