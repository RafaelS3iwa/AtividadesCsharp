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
        private string Nome {  get; set; }
        private double Preco { get; set; }

        public Produto(int idProduto = 0, string nome = "", double preco = 0)
        {
            IdProduto = idProduto;
            Nome = nome;    
            Preco = preco;
        }
    }
}
