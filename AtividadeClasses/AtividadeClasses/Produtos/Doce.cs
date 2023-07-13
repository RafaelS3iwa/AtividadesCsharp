using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeClasses.Produtos
{
    internal class Doce : Produto
    {
        private List<Doce> listaDeDoces { get; set; }

        public List<Doce> ListaDeDoces => listaDeDoces;

    }
}
