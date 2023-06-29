using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosDiversos
{
    internal class EstruturaCondicional
    {
        static void Main()
        {

            Console.WriteLine("======= Estrutura Condicional =======");


            int nota = 8;

            //Condicional Simples
            if (nota >= 7)
            {
                Console.WriteLine("== Estrutura Condicional Simples ==");
                Console.WriteLine("     O aluno está aprovado.");
            }

            //Condicional Dupla
            EscreveLinha();

            if (nota >= 7)
            {
                Console.WriteLine("== Estrutura Condicional Dupla ==");
                Console.WriteLine("     O aluno está aprovado.");
            }
            else
            {
                Console.WriteLine("== Estrutura Condicional Dupla ==");
                Console.WriteLine("     O aluno está reprovado.");
            }

            //Condicional Composta
            EscreveLinha();

            if (nota >= 9)
            {
                Console.WriteLine("== Estrutura Condicional Composta ==");
                Console.WriteLine("         Aluno nota A.");
            }
            else if (nota >= 7)
            {
                Console.WriteLine("== Estrutura Condicional Composta ==");
                Console.WriteLine("         Aluno nota B.");
            }
            else if (nota >= 5)
            {
                Console.WriteLine("== Estrutura Condicional Composta ==");
                Console.WriteLine("         Aluno nota C.");
            }
            else if (nota >= 3)
            {
                Console.WriteLine("== Estrutura Condicional Composta ==");
                Console.WriteLine("         Aluno nota D.");
            }
            else
            {
                Console.WriteLine("== Estrutura Condicional Composta ==");
                Console.WriteLine("         Aluno nota E.");
            }

            //Switch
            EscreveLinha();

            string cor = "Vermelho";

            switch (cor.ToLower())
            {
                case "verde":
                    Console.WriteLine("A cor é verde");
                    break;
                case "vermelho":
                    Console.WriteLine("A cor é vermelha");
                    break;
                case "azul":
                    Console.WriteLine("A cor é azul");
                    break;
                default:
                    Console.WriteLine("A cor não foi reconhecida");
                    break;
            }
        }

        static void EscreveLinha()
        {
            Console.WriteLine("=====================================");
        }
    }
}
