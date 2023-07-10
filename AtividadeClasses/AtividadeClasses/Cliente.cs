using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeClasses
{
    internal class Cliente
    {
        private static int adicionarId = 0;

        public int IdCliente { get; }
        private string nome { get; }
        private string cpf { get; }
        private double saldo; 
        private int quantidade { get; set; }
        
        public Cliente()
        {
            adicionarId++;
            IdCliente = adicionarId;
        }


        public int Quantidade
        {
            get { return quantidade; }
            set
            {
                if (value > 0) quantidade = value;
                else return;
            }
        }

        public double Saldo
        {
            get { return saldo; }
            set
            {
                if (value >= 0) saldo = value;
                else Console.WriteLine("Saldo inválido");
            }
        }


    }
}
