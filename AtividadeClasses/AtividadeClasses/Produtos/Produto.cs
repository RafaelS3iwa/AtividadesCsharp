using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeClasses.Produtos
{
    internal class Produto
    {
        private static int adicionarId = 0;

        public int idProduto { get; }
        private string nome { get; set; }
        private double valor { get; set; }

        public Produto()
        {
            adicionarId++;
            idProduto = adicionarId;
        }
        public Produto(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public double Valor
        {
            get { return valor; }
            set 
            {
                if (value >= 0) valor = value;
                else Console.WriteLine("Valor inválido");
            }
        }

        public string Nome
        {
            get { return nome; }
            set
            {
                if (value != null) nome = value;
                else Console.WriteLine("Nome inválido");
            }
        }

        public virtual void MostrarProdutos()
        {
            Console.WriteLine($"{nome} ----------- {valor:c}");
        }
    }
}
