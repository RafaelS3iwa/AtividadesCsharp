using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeClasses
{
    internal class Produto
    {
        private static int adicionarId = 0;
        private Dictionary<string, double> produtos = new Dictionary<string, double>();

        public int idProduto { get; }
        private string nome { get; }
        private double valor { get; set; }

        public Produto()
        {
            adicionarId++;
            idProduto = adicionarId;
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
        }

        public Dictionary<string, double> Produtos => produtos;

        public void AdicionarProduto(Dictionary<string, double> produtos, string nome, double valor)
        {
            while (true)
            {
                Console.Write("Digite o nome do produto que deseja adicionar ('sair' para encerrar): ");
                nome = Console.ReadLine();

                if(nome.ToLower() == "sair")
                {
                    break;
                }

                Console.WriteLine("Digite agora o valor do produto: ");
                if (double.TryParse(Console.ReadLine(), out valor))
                {
                    produtos[nome] = valor;
                }
                else
                {
                    Console.WriteLine("Valor Inválido");
                }
            }
        }
    }
}
