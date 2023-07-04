using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos
{
    internal class AppBiblioteca
    {
        static void Main()
        {
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.Nome = "Senac Marília";

            Livro livro = new Livro();

            livro.IdLivro = 1;
            livro.Titulo = "Oyasumi Punpun";
            livro.Autor = "Inio Asano";
            livro.Valor = 50;
            livro.NumeroPaginas = 432;

            biblioteca.CadastrarLivro(livro);
            biblioteca.MostrarCatalogo();
        }
    }
}
