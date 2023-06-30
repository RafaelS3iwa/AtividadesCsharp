using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaaaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] peso1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] peso2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma1 = 0, soma2 = 0;
            int resto1 = 0, resto2 = 0;

            Random random = new Random();
            int[] cnpjInt = new int[14];

            for(int i = 0; i < cnpjInt.Length; i++)
            {
                int randomNumber = random.Next(10);
                cnpjInt[i] = randomNumber;   
            }
    
            for (int i = 0; i < 12; i++)
            {
                soma1 += cnpjInt[i] * peso1[i];
                resto1 = soma1 % 11;
            }

            resto1 = (resto1 < 2) ? 0 : 11 - resto1;
            cnpjInt[12] = resto1;

            for (int i = 0; i < 13; i++)
            {
                soma2 += cnpjInt[i] * peso2[i];
                resto2 = soma2 % 11;
            }
            resto2 = (resto2 < 2) ? 0 : 11 - resto2;

            cnpjInt[13] = resto2;

            string cnpj = string.Concat(cnpjInt);

            if (cnpjInt[12] == resto1 && cnpjInt[13] == resto2)
            {
                Console.WriteLine($"seu cpf gerado é {cnpj}");
            }
            else
            {
                return;
            }
        }
    }
}
