using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosDiversos
{
    internal class LacoDeRepeticao
    {
        static void Main()
        {
            ImprimirTitulo("Laço Repetição");


            int contador = 0;

            //While

            ImprimirTitulo("Laço While");
            while (contador <= 5)
            {
                Console.WriteLine($"            O valor do contador é {contador}");
                contador++;
            }

            //For
            ImprimirTitulo("Laço For");
            for(contador = 0; contador < 5; contador++)
            {
                Console.WriteLine($"            O valor do contador é {contador}");
            }

            //Do e While
            ImprimirTitulo("Laço Do While");
            do
            {
                Console.WriteLine($"            O valor do contador é {contador}");
                contador ++;
            } while(contador <= 5);

            //Foreach
            ImprimirTitulo("Laço Foreach");
            string[] frutas = { "Uva", "Maçã", "Banana", "Melão", "Pitaia" };
            
            foreach(string fruta in frutas)
            {
                Console.WriteLine($"            Eu gosto da fruta: {fruta}");
            }

        }
  
        public static void ImprimirTitulo(string texto)
        {
            int larguraTotal = 50; // Largura total do título
            string linha = new string('=', larguraTotal);
            int espacosEsquerda = (larguraTotal - texto.Length) / 2;
            int espacosDireita = larguraTotal - texto.Length - espacosEsquerda;

            Console.WriteLine(linha);
            Console.WriteLine($"{"="}{new string(' ', espacosEsquerda)}{texto}{new string(' ', espacosDireita)}{"="}");
            Console.WriteLine(linha);
        }
    }
}
