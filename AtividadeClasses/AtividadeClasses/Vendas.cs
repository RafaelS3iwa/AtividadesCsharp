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
        Cliente cliente = new Cliente();
        Produto produto = new Produto();

        private double ValorTotal {  get; set; }
    }

}

