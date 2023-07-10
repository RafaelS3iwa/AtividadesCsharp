using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblioteca
{
    internal class Livro
    {   
        public int Id { get; set; }
        public string Titulo;
        private int ano;
        private int numeroPagina;

        public int Ano
        {
            get { return ano; }
            set
            {
                if(value > 0)
                {
                    ano = value;
                }
                else
                {
                    Console.WriteLine("Ano de publicação Inválido.") ;
                }
            }
        }

        public int NumeroPaginas
        {
            get { return numeroPagina; }
            set
            {
                if (value > 0)
                {
                    numeroPagina = value;
                }
                else
                {
                    Console.WriteLine("Número de páginas inválido.");
                }
            }
        }

        public virtual void MostrarDetalhes()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Ano: {ano}");
            Console.WriteLine($"Número de Páginas: {numeroPagina}");
        }
    }
}
