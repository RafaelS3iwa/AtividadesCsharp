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

            Livro livro2 = new Livro();

            livro2.IdLivro = 2;
            livro2.Titulo = "O último desejo -The Witcher -";
            livro2.Autor = " Andrzej Sapkowski";
            livro2.Valor = 43;
            livro2.NumeroPaginas = 318;


            biblioteca.CadastrarLivro(livro2);
        }
    }
}
