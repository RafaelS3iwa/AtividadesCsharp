using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtividadeClasses.Produtos;

namespace AtividadeClasses.Menus
{
    internal class MenuDoces : Menu
    {
        private Produto produto;

        public MenuDoces(Produto produtos)
        {
            produto = produtos;
        }

        public void Executar()
        {
            ExibirTitulo("Menu de Doces");
            
        }
    }
}
