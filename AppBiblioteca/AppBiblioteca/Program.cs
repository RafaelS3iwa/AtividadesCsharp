using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro();

            livro.Id = 1;
            livro.Titulo = "Oyasumi Punpun Vol.1";
            livro.Ano = 2007;
            livro.NumeroPaginas = 432;

            livro.MostrarDetalhes();

            Console.WriteLine("=================================");

            LivroDigital livroDigital = new LivroDigital(); 
            livroDigital.Id = 2;
            livroDigital.Titulo = "Guerra dos Tronos";
            livroDigital.Ano = 1996;
            livroDigital.NumeroPaginas = 809;
            livroDigital.TipoArquivo = "PDF";
            livroDigital.TamanhoMB = 6;

            livroDigital.MostrarDetalhes();
        }
    }
}
