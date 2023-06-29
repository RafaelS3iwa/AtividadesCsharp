using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AlgoritmosDiversos
{
    internal class ListaDeCompras
    {
        static void Main()
        {
            List<string> listasCompras = new List<string>();
            Console.WriteLine("::::::::  Programa de lista de Compras  ::::::::");

            while (true)
            {
                Console.Write("Digite um item para adicionar à lista (ou 'parar' para sair): ");

                string item = Console.ReadLine().Trim();

                if (item.ToLower() == "parar")
                {
                    Console.Clear();
                    break;
                }
                else if(item == "")
                {
                    Console.WriteLine("O item não pode ser adicionado.");
                }
                else
                {
                    listasCompras.Add(item);
                    Console.WriteLine($"O item {item} foi adicionado com sucesso\n");
                }             
            }
            Console.WriteLine("----- Sua lista de Compras -----");
            if(listasCompras.Count == 0)
            {
                Console.WriteLine("Sua lista está vazia");
            }
            else
            {
                var grupos = listasCompras.GroupBy(item => item); //Em vez de declarar explicitamente o tipo da variável, você pode usar var para permitir que o compilador determine o tipo automaticamente.
                foreach (var grupo in grupos)
                {
                    string item = grupo.Key;
                    int quantidade = grupo.Count();
                    Console.WriteLine($"{quantidade} {item}");
                }
            }
           
        }
    }
}
