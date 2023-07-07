using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente(idCliente: 1, nome: "Rafael", quantidade: 10);

            Produto produto = new Produto(idProduto: 1, nome: "Paçoca", valor: 5);
            Vendas venda = new Vendas(cliente, produto);

            double valorTotal = venda.ValorTotal;

            Console.WriteLine($"O cliente {cliente.Nome} comprou {cliente.Quantidade} quantidades do produto {produto.Nome} totalizando um valor de\n" +
                $"{valorTotal:c}");
        }
    }
}
