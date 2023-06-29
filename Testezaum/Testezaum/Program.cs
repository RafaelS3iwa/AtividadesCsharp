using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int[] cpf = new int[10];
        int soma1 = 0, soma2 = 0;
        int resto1 = 0, resto2 = 0;

        while (cpf[9] != resto1 && cpf[10] != resto2)
        {

            for (int i = 0; i < cpf.Length; i++)
            {
                int randomNumber = random.Next(10); // Gera um número aleatório entre 0 e 9
                cpf[i] = randomNumber;
            }
            for (int i = 0; i < 9; i++)
            {
                soma1 += cpf[i] * (10 - i);
                resto1 = (soma1 * 10) % 11;
            }

            for (int i = 0; i < 10; i++)
            {
                soma2 += cpf[i] * (11 - i);
                resto2 = (soma2 * 10) % 11;
            }
            resto1 = (resto1 == 10 || resto1 == 11) ? 0 : resto1;
            resto2 = (resto2 == 10 || resto2 == 11) ? 0 : resto2;

            if (cpf[9] == resto1 && cpf[10] == resto2)
            {
                foreach(int numero in cpf)
                {
                    Console.WriteLine($"{numero}");
                    break;
                }
            }   
            else
            {
                continue;
            }
        }
    }
}

