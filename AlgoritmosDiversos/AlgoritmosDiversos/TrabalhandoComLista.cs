using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosDiversos
{
    internal class TrabalhandoComLista
    {
        static void Main()
        {
            List<int> lista = new List<int>();
        //Adicionando valor a lista
            lista.Add(1); 
            lista.Add(20);
            lista.Add(10);
            lista.Add(80);
            lista.Add(69);
            lista.Add(10);
            lista.Add(40);
            ImprimeLista(lista, "Adicionando valor a lista.");
       

            //Remove: esse comando remove a primeira ocorrência de um elemento dentro da lista
            lista.Remove(10);
            ImprimeLista(lista, "Remove a primeira ocorrência de um elemento dentro da lista.");

            //RemoveAt: Remove o elemento de um índice (posição)           
            lista.RemoveAt(0);
            ImprimeLista(lista, "Remove o elemento de um índice.");

            //Sort: Ordena os elementos em ordem crescente 
            lista.Sort();
            ImprimeLista(lista, "Ordena a lista em Crescente.");

            //Reverse: Ordena os elementos em ordem decrescente
            lista.Reverse();
            ImprimeLista(lista, "Ordena a lista em Decrescente.");

            //Count: Retorna a quantidade de elementos na lista
            Console.WriteLine("\n================== Conta os elementos dentro da lista. =========================");
            int numeroItem = lista.Count();
            Console.WriteLine($"Existem {numeroItem} itens dentro da lista");

            //Contains: Verifica se a lista contém um determinado elemento 
            Console.WriteLine("\n================== Procura elementos dentro da lista. =========================");
            if (lista.Contains(40))
            {
                Console.WriteLine("Foi encontrado o item na lista");
            }
            else
            {
                Console.WriteLine("Não foi encontrado nenhum item na lista");
            }

            //Insert: Insere um elemento em um determinado índice da lista
            lista.Insert(2, 45); //--> insere na posição 2 o valor 45 
            ImprimeLista(lista, "Insere um elemento em um determinado índice da lista");

            //Clear: limpa os itens da lista
            lista.Clear();
        }
        
        static void ImprimeLista(List<int> lista, string titulo = "") //Dentro dos parênteses se chama parâmetros, algo que quero transportar para cá, ou seja, na hora de utilizar esse método obrigatoriamente precisa do parâmetro
        {                                                        //Para deixar opcional o parâmetro eu posso fazer com = "" ou posso também adicionar coisa, isso se chama valor default
            Console.WriteLine($"\n================ {titulo} ===================");

            foreach (int num in lista)
            {
                Console.WriteLine(num);
            }
        }
    }
}
