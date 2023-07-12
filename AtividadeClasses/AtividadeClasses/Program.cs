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
            cliente.Saldo = 1000;
            cliente.Quantidade = 3;

            Produto produto = new Produto();
            produto.Nome = "Batata";
            produto.Valor = 30;

            Vendas venda = new Vendas(cliente, produto);
            double valorTotal = venda.ValorTotal;

            produto.MostrarProdutos();
            venda.VerificarSaldo();

        }
    }
}
