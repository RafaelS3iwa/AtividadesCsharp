using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeClasses
{
    internal class Vendas
    {

        private Cliente cliente;
        private Produto produto;
        private double valorTotal => cliente.Quantidade * produto.Valor;

        public double ValorTotal
        {
            get { return valorTotal; }
        }


        public Vendas(Cliente quantidade, Produto valor)
        {
            cliente = quantidade;
            produto = valor;
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
            double saldo = cliente.Saldo - ValorTotal;
            if (saldo >= ValorTotal - cliente.Saldo)
            {
                Console.WriteLine($"A compra foi realizada com sucesso, seu saldo final está em {saldo}");
            }
            else
            {
                Console.WriteLine("A compra não pode ser realizada, pois seu saldo está a baixo do valor da compra.");
            }
        }

    }
}

