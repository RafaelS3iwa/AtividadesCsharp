using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro();

            livro.IdLivro = 1;
            livro.Titulo = "Oyasumi Punpun";
            livro.Autor = "Inio Asano";
            livro.Valor = 50;
            livro.NumeroPaginas = 432;

            Console.WriteLine("Detalhes do livro 1");
            livro.ImprimirDetalhes();

            Livro livro2 = new Livro();

            livro2.IdLivro = 2;
            livro2.Titulo = "O último desejo -The Witcher -";
            livro2.Autor = " Andrzej Sapkowski";
            livro2.Valor = 43;
            livro2.NumeroPaginas = 318;
            
            Console.WriteLine("Detalhes do livro 2");
            livro2.ImprimirDetalhes();

            Livro livro3 = new Livro(3, "A Guerra dos Tronos Livro 1", "George R.R.", 600, 92.90);
            Console.WriteLine("Detalhes do livro 3");
            livro3.ImprimirDetalhes();

            Livro livro4 = new Livro(idLivro: 4, titulo: "Design para Quem Não é Designer", autor: "Robin Williams", numeroPaginas: 144, valor: 30);
            Console.WriteLine("Detalhes do livro 4");
            livro4.ImprimirDetalhes();

            Livro livro5 = new Livro()
            {
                IdLivro = 5,
                Titulo = "O Hobbit",
                NumeroPaginas = 336,
                Valor = 70,
                Autor = "J.R.R. Tolkien"
            };
            Console.WriteLine("Detalhes do livro 5");
            livro5.ImprimirDetalhes();
        }
    }
}
