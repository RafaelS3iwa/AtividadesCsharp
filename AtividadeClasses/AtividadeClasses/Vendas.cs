using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AtividadeClasses.Produtos;

namespace AtividadeClasses
{
    internal class Vendas
    {
        private List<Produto> listaDeCompras = new List<Produto>();


        private Cliente cliente;
        private Produto produto;

        private double valorTotal => CalcularValorTotal();


        public Vendas(Cliente quantidade, Produto valor)
        {
            cliente = quantidade;
            produto = valor;
        }

        public List<Produto> ListaDeCompras => listaDeCompras;

        public void AdicionarProduto(Produto produto)
        {
            listaDeCompras.Add(produto);
        }

        public double CalcularValorTotal()
        {
            double valorTotal = 0;
            foreach(Produto produto in listaDeCompras)
            {
                double valorProduto = cliente.Quantidade * produto.Valor;
                valorTotal += valorProduto;
            }
            return valorTotal;
        }

        public void VerificarSaldo()
        {
            if (SaldoSuficiente())
            {
                RealizarCompra();
            }
            else
            {
                Console.WriteLine("A compra não pode ser realizada, pois seu saldo está a baixo do valor do produto.");
            }           
        }

        private bool SaldoSuficiente()
        {
            return cliente.Saldo > produto.Valor;
        }

        private void RealizarCompra()
        {
            double saldo = cliente.Saldo - valorTotal;
            if (saldo >= valorTotal - cliente.Saldo)
            {
                Console.WriteLine($"A compra foi realizada com sucesso, seu saldo final está em {saldo:c}");
            }
            else
            {
                Console.WriteLine("A compra não pode ser realizada, pois seu saldo está a baixo do valor da compra.");
            }
        }

    }
}

