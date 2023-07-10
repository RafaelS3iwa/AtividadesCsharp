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
            Cliente cliente = new Cliente();
            cliente.Saldo = 20;
            cliente.Quantidade = 3;


            Produto produto = new Produto();
            produto.Valor = 30;

            Vendas venda = new Vendas(cliente, produto);

            double valorTotal = venda.ValorTotal;


            venda.VerificarSaldo();
            Console.WriteLine($"O cliente {cliente.IdCliente} comprou {cliente.Quantidade} do produto {produto.idProduto} totalizando um valor de\n" +
                $"{valorTotal:c}");
        }
    }
}
