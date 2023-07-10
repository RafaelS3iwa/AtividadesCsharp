using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblioteca
{
    internal class LivroDigital : Livro
    {
        public string TipoArquivo;
        private int tamanhoMB;

        public int TamanhoMB
        {
            get { return tamanhoMB; }
            set
            {
                if(value > 0)
                {
                    tamanhoMB = value;
                }
                else
                {
                    Console.WriteLine("Tamanho inválido.");
                }
            }
        }
        public override void MostrarDetalhes()
        {
            base.MostrarDetalhes();
            Console.WriteLine($"Tipo do Arquivo: {TipoArquivo}");
            Console.WriteLine($"Tamanho em MB: {TamanhoMB} MB.");
        }
    }
}
