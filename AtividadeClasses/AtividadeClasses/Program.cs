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
            cliente.Quantidade = 2;

            Produto produto = new Produto();
            produto.Nome = "Batata";
            produto.Valor = 15;

            Produto produto1 = new Produto();
            produto1.Nome = "Pamonha";
            produto1.Valor = 5;

            Vendas venda = new Vendas(cliente, produto);
            Doce doce = new Doce("", 0);

            Doce chocolate = new Doce("Chocolate", 10);

            produto1.MostrarProdutos();
            produto.MostrarProdutos();
            chocolate.MostrarProdutos();
            chocolate.ComprarDoce();

            double valorTotal = venda.CalcularValorTotal();
    
            Console.WriteLine($"\nO cliente comprou {cliente.Quantidade} quantiades de {produto.Nome} e {cliente.Quantidade} de {produto1.Nome}");
            Console.WriteLine($"o valor total foi de: {valorTotal:c}\n");
            venda.VerificarSaldo();          
        }
    }
}
