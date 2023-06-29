using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosDiversos
{
    internal class TrabalhandoArray
    {
        static void Main()
        {
            int[] numero = { 10, 25, 30, 5, 50 }; //Array estático 
            int[] numerosNotas = new int[5] { 10, 5, 8, 8, 5 }; //Posso declarar ou não 
            int[] notas = new int[4]; //Tipo aqui, eu falo que ele tem 4 posições
            

            notas[0] = 10; //Aqui a posição 0 recebe 10
            notas[1] = 4; //posição 1 recebe 4
            notas[2] = 8; //posição 2 recebe 8 
            notas[3] = 9; //posição 3 recebe 9
            
            foreach(int nota in numerosNotas )
            {
                Console.WriteLine(nota);
            }
        }
    }
}
