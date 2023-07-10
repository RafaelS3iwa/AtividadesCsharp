using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpfAndCnpj.Cpf
{
    internal class CPF
    {
        public string Cpf { get; set; }
        public int[] Peso1 { get; }
        public int[] Peso2 { get; }

        public int Soma1 { get; }
        public int Soma2 { get; }   
        public int Resto1 { get; }
        public int Resto2 { get; }  


        public CPF()
        {
            Peso1 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            Peso2 = new int[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        }

       
    }
}
