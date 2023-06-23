using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ValidadorDeCPF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] CpfInt = new int[11];

            //Variáveis para o primeiro dígito verificador
            int[] peso1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma1 = 0;
            int resto1 = 0;

            //Variáveis para o segundo dígito verificador
            int[] peso2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma2 = 0;
            int resto2 = 0;


            while (true) //Começo do loop
            {
                Console.Write("Digite o CPF (Apenas Números): ");
                string CPF = Console.ReadLine().Trim();

                bool isNumeric = CPF.All(char.IsDigit);

                if (!isNumeric) //Avisa que há números dentro do CPF
                {
                    Console.WriteLine("CPF inválido!");
                    Console.WriteLine("O CPF deve conter apenas números.");
                    Console.WriteLine("\n============================\n");
                    continue;
                }
                else if (CPF.Length != 11)  //Avisa que o total de caracteres é inválido
                {
                    Console.WriteLine("CPF inválido!");
                    Console.WriteLine("O total de caracteres foi diferente de 11!");
                    Console.WriteLine("\n============================\n");
                    continue;
                }
                else //Verifica se o CPF tem 11 dígitos, se sim, acaba o loop e converte para int
                {
                    CpfInt = CPF.Select(digito => Convert.ToInt32(digito.ToString())).ToArray();
                    break;
                }
            }

            for (int i = 0; i < 9; i++) //Cálculo do Primeiro Dígito
            {
                soma1 += CpfInt[i] * peso1[i];
                resto1 = (soma1 * 10) % 11;

                if (resto1 == 10 || resto1 == 11)
                {
                    resto1 = 0;
                }
            }

            for (int i = 0; i < 10; i++) //Cálculo do Segundo Dígito 
            {
                soma2 += CpfInt[i] * peso2[i];
                resto2 = (soma2 * 10) % 11;

                if (resto2 == 10 || resto2 == 11)
                {
                    resto2 = 0;
                }
            }

            //Formatação do CPF
            string cpfEscrito = string.Join("", CpfInt);
            string cpfFormatado = $"{cpfEscrito.Substring(0, 3)}.{cpfEscrito.Substring(3, 3)}.{cpfEscrito.Substring(6, 3)}-{cpfEscrito.Substring(9, 2)}";

            //Informar se o CPF é Válido ou Não
            if (resto1 != CpfInt[9] || resto2 != CpfInt[10])
            {
                Console.WriteLine("\n============================");
                Console.WriteLine($"O CPF: {cpfFormatado} é inválido");
                Console.WriteLine("============================\n");
            }
            else
            {
                Console.WriteLine("\n============================");
                Console.WriteLine($"O CPF: {cpfFormatado} é válido");
                Console.WriteLine("============================\n");
            }
        }
    }
}
