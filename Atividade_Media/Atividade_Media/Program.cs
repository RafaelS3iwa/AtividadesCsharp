using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeDasMedias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, total, media;

            //Começo do Programa
            Console.WriteLine("==========================");
            Console.WriteLine("=     Calcular Média     =");
            Console.WriteLine("==========================");
            Console.WriteLine();

            //Atribuição das notas 
            Console.Write("Digite a Primeira Nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n--------------------------\n");

            Console.Write("Digite a Segunda Nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n--------------------------\n");

            Console.Write("Digite a Terceira Nota: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n--------------------------\n");

            Console.Write("Digite a Quarta Nota: ");
            nota4 = Convert.ToDouble(Console.ReadLine());

            //Conta
            total = nota1 + nota2 + nota3 + nota4;
            media = total / 4;

            //Mostrando a conta
            Console.WriteLine("As notas foram................{0,10}", nota1);
            Console.WriteLine("..............................{0,10}", nota2);
            Console.WriteLine("..............................{0,10}", nota3);
            Console.WriteLine("..............................{0,10}", nota4);
            Console.WriteLine();
            Console.WriteLine("O Total foi...................{0,10}", total);
            Console.WriteLine("O Resultado da média foi:.....{0,10}", media);



        }
    }
}
