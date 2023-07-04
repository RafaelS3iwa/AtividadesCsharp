using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos
{
    internal class Biblioteca
    {
        public string Nome;
        public List<Livro> Catalogo; 

        public Biblioteca()
        {
            Catalogo = new List<Livro>(); 
        }

        public void CadastrarLivro(Livro livro)
        {
            Catalogo.Add(livro);    
        }

        public void MostrarCatalogo()
        {
            Console.WriteLine($"O Catálogo de livros da Biblioteca: {Nome}");
            Console.WriteLine("-------------------------------------------");
            foreach(var livro in Catalogo)
            {
                Console.WriteLine($"Identificação: {livro.IdLivro} | {livro.Titulo} | Preço: {livro.Valor:c}");
            }
            Console.WriteLine("===========================================");
            Console.WriteLine($"Total de Livros: {Catalogo.Count()}");
        }
    }
}
