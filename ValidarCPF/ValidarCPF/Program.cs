using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/*Validar CPF
    Mostrar se o CPF é ou não válido 
    
    Métodos: 
    1. Inserir CPF
    2. Ver se a estrutura (só número e 11 caracteres está correto) 
    3. Conversão para int e conta 
    4. Formatação e retorno 

*/
namespace ValidadorCPF
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ValidacaoDeCPF(); //Tem a função de executar o código inteiro
        }
        static void ValidacaoDeCPF() //Diz se o código é ou não válido
        {
            string cpf = ObterCPF(); //Recebe o cpf do método da linha 53
            string cpfFormatado = FormatarCpf(cpf); //Recebe o cpf formatado no método da linha 131
            if (ValidarCpf(cpf))
            {
                ExibirTexto($"O CPF {cpfFormatado} é válido!");
            }
            else
            {
                ExibirTexto($"O CPF {cpfFormatado} é inválido");
                if (VerNovamente())  //Pergunta se o usuário deseja ver novamente 
                {
                    Console.Clear();
                    ValidacaoDeCPF();
                }
                else
                {
                    Console.WriteLine("\nAté a próxima!");
                    Environment.Exit(0);
                    Console.ReadLine();
                }
            }
        }

        static string ObterCPF()
        {
            string cpf;
            int loop = 0;

            while (true)
            {
                Console.Write("Digite o seu CPF (com apenas números): ");
                cpf = Console.ReadLine().Trim();

                if (AutenticarCpf(cpf)) //Caso o método da linha 91 retorne uma condição falsa, aumenta o loop em 1 e continua o programa
                {
                    break;
                }

                else //Caso o método retorne verdadeiro, encerra o loop e retorna o CPF já autenticado, sem que haja problemas com sua estrutura futuramente
                {
                    if (loop == 2) //Faz com que o usuário caia na condição ver novamente caso ele erre 3 vezes
                    {
                        if (VerNovamente())
                        {
                            loop = 0; //Caso queira, o loop é recomeçado
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Até a próxima!"); //Caso não queira, o programa encerra imediatamente
                            Environment.Exit(0);
                        }
                    }
                    loop++;
                    continue;
                }
            }
            return cpf;
        }

        static bool AutenticarCpf(string cpf)
        {
            if (!cpf.All(char.IsDigit)) //Verifica se o CPF não contém apenas dígitos númericos (o ponto de exclamação representa um não)
            {
                Console.WriteLine("CPF Inválido!");
                ExibirTexto($"O CPF: {cpf} não contém apenas números");
            }

            else if (cpf.Length != 11) //Verifica se o CPF contém o total de 11 caracteres
            {
                Console.WriteLine("CPF Inválido!");
                ExibirTexto($"O CPF: {cpf} teve o total de caracteres diferente de 11!");
            }
            return cpf.Length == 11 && cpf.All(char.IsDigit); //Caso nenhuma das condições a cima sejam verdadeiras, o cpf é retornado 
        }

        static bool ValidarCpf(string cpf)
        {
            int[] cpfInt = cpf.Select(digito => Convert.ToInt32(digito.ToString())).ToArray(); //O cpf autenticado vem aqui, onde é convertido para um array tipo int
            int soma1 = 0, soma2 = 0;
            int resto1 = 0, resto2 = 0;

            for (int i = 0; i < 9; i++)
            {
                soma1 += cpfInt[i] * (10 - i);
                resto1 = (soma1 * 10) % 11;
            }

            for (int i = 0; i < 10; i++)
            {
                soma2 += cpfInt[i] * (11 - i);
                resto2 = (soma2 * 10) % 11;
            }

            resto1 = (resto1 == 10 || resto1 == 11) ? 0 : resto1; //Aqui resume o if, é quase a mesma coisa, entretanto, ele testa a condição entre parenteses
            resto2 = (resto2 == 10 || resto2 == 11) ? 0 : resto2; //Aí diz que caso a expressão seja verdadeira, ele retorna 0, após os : ele retorna o valor caso seja uma expressão falsa

            return resto1 == cpfInt[9] && resto2 == cpfInt[10];
        }

        static string FormatarCpf(string cpf)
        {
            Console.Clear();
            return $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9, 2)}"; //Dá para formatar o CPF sem que esteja em formato de array, até porque, string já é uma coletânea de dados
        }

        static void ExibirTexto(string texto) //Comando exatamente porque eu quero fazer firula
        {
            int quantidadeDeLetras = texto.Length;
            string traco = string.Empty.PadLeft(quantidadeDeLetras, '='); //Basicamente ele conta automaticamente a quantidade de caracteres e preenche em cima e em baixo com "="
            Console.WriteLine("\n" + traco);
            Console.WriteLine(texto);
            Console.WriteLine(traco + "\n");
        }

        static bool VerNovamente()
        {
            Console.WriteLine("\nVocê deseja tentar novamente?");
            Console.Write("Clique em S para sim ou qualquer outra tecla para Não: ");
            ConsoleKeyInfo keyInfo = Console.ReadKey(); //Ele lê e armazena a tecla, ConsoleKeyInfo é uma estrutura do .NET

            Console.WriteLine();

            return (keyInfo.Key == ConsoleKey.S); //Retorna verdadeiro caso a tecla pressionada seja S
        }
    }
}
