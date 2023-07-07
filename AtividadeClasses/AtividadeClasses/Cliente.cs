using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeClasses
{
    internal class Cliente
    {   
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        private string Cpf { get; set; }    
        private double Saldo { get; set; }
        public int Quantidade { get; set; }

        public Cliente(int idCliente = 0, string nome = "", double saldo = 0, int quantidade = 0)
        {
            IdCliente = idCliente;
            Nome = nome;
            Saldo = saldo;
            Quantidade = quantidade;
        }
    }
}
