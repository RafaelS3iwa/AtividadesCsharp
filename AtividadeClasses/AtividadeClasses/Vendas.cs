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

        private Cliente Itens;
        private Produto Preco;
        public double ValorTotal
        {
            get { return Itens.Quantidade * Preco.Valor; }
        }

        public Vendas(Cliente itens, Produto preco)
        {
            Itens = itens;
            Preco = preco;
        }
    }

}

