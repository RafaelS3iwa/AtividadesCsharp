using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos
{
    internal class Livro
    {
        public int IdLivro;
        public string Titulo;
        public string Autor;
        public int NumeroPaginas;
        public double Valor;

        public Livro(int idLivro = 0, string titulo = "", string autor = "", int numeroPaginas = 0, double valor = 0) //Método Construtor da Classe 
        {
            IdLivro = idLivro;
            Titulo = titulo;
            Autor = autor;
            NumeroPaginas = numeroPaginas;
            Valor = valor;
        }

        public void ImprimirDetalhes() 
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Identificação: {IdLivro}");
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Número de Páginas: {NumeroPaginas}");
            Console.WriteLine($"Valor: {Valor:c}");
            Console.WriteLine("---------------------------");
        }
    }
}
