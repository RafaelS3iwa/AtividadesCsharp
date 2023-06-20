using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprovado_Reprovado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Média de 4 Notas

            double nota1, nota2, nota3, nota4, media;

            Console.WriteLine("=================================");
            Console.WriteLine("====Cálculo da Média do Aluno====");
            Console.WriteLine("=================================\n");

            //Atribuição de Notas 

            Console.Write("   Insira a Primeira Nota:  ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("   Insira a Segunda Nota:   ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("   Insira a Terceira Nota:  ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("   Insira a Quarta Nota:    ");
            nota4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n=================================\n");

            //Cálculo da média

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            //Condição de Aprovação ou reprovação

            if (media >= 7)
            {
                Console.WriteLine($"      O Aluno foi aprovado! \n    Sua média foi igual a: {media}");
                Console.WriteLine("\n=================================");

            }
            else
            {
                Console.WriteLine($"      O Aluno foi reprovado! \n   Sua média foi igual a: {media}");
                Console.WriteLine("\n=================================");

            }
        }
    }
}
