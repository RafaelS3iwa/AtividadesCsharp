using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtividadeClasses;

namespace AtividadeClasses.Produtos
{
    internal class Doce : Produto
    {
        private Vendas venda; 
        private Dictionary<string, double> doces;

        public Doce(Vendas vendas, string nome,  double valor) : base(nome, valor) 
        {
            venda = vendas;
        }
         
        public Doce(string nome, double valor) : base(nome, valor)
        {
        }

        public void AdicionarDoce(string nomeDoce, double preco)
        {
            doces[nomeDoce] = preco; 
        }

        public void ListarDoces()
        {
            Console.WriteLine("Os doces disponíveis são:\n ");
            foreach(var doce in doces) 
            {
                Console.WriteLine($"{doce.Key} - {doce.Value:c}");
            }
        }
        public void ComprarDoce()
        {

            Console.WriteLine("\nDigite qual doce você deseja comprar: ");
            string opcao = Console.ReadLine().ToLower();
            if (doces.ContainsKey(opcao))
            {
                Console.WriteLine("Digite a quantidade que você deseja comprar: ");
                int quantidadeComprada;

                if(int.TryParse(Console.ReadLine(), out quantidadeComprada))
                {
                    double preco = doces[opcao];
                    Console.WriteLine($"{quantidadeComprada}x{opcao} -- {preco:c} foram adicionados ao carrinho com sucesso!");
                    venda.AdicionarProduto(this);
                }     
            }
        }
    }
}
