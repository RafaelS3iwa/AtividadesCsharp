using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeClasses
{
    internal class Produto
    {
        private int IdProduto { get; set; }
        public string Nome {  get; set; }
        public double Valor { get; set; }

        public Produto(int idProduto = 0, string nome = "", double valor = 0)
        {
            IdProduto = idProduto;
            Nome = nome;    
            Valor = valor;
        }
    }
}
