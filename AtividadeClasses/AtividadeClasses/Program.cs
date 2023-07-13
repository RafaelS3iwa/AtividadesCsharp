using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtividadeClasses.Produtos;

namespace AtividadeClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Saldo = 1000;

            Console.WriteLine("Digite a quantidade de produtos que você quer: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            cliente.Quantidade = quantidade;     

            Produto produto = new Produto();
            produto.Nome = "Batata";
            produto.Valor = 15;

            Produto produto1 = new Produto();
            produto1.Nome = "Pamonha";
            produto1.Valor = 5;

            Vendas venda = new Vendas(cliente, produto);

            venda.AdicionarProduto(produto);
            venda.AdicionarProduto(produto1);


            double valorTotal = venda.CalcularValorTotal();
            produto1.MostrarProdutos();
            produto.MostrarProdutos();

            Console.WriteLine($"O cliente comprou {cliente.Quantidade} quantiades de {produto.Nome} e {cliente.Quantidade} de {produto1.Nome}");
            Console.WriteLine($"o valor total foi de: {valorTotal:c}");
            venda.VerificarSaldo();

        }
    }
}
