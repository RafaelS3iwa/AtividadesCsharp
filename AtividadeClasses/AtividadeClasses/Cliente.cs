using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeClasses
{
    internal class Cliente
    {   
        private int IdCliente { get; set; }
        private string Nome { get; set; }
        private string Cpf { get; set; }
        private double Saldo { get; set; }
        private int Itens { get; set; }

        public Cliente(int idCliente = 0, string nome = "", double saldo = 0, int itens = 0)
        {
            IdCliente = idCliente;
            Nome = nome;
            Saldo = saldo;
            Itens = itens;
        }
    }
}
