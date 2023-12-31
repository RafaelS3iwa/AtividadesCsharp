﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace ValidadorCPF
{
    internal class Program
    {
        public class ExibirLogo //Exibe o Logo do Programa.
        {
            public static void Menu()
            {
                Console.WriteLine(@"

            ██████╗░██████╗░░█████╗░░██████╗░██████╗░░█████╗░███╗░░░███╗░█████╗░  ██████╗░███████╗  
            ██╔══██╗██╔══██╗██╔══██╗██╔════╝░██╔══██╗██╔══██╗████╗░████║██╔══██╗  ██╔══██╗██╔════╝  
            ██████╔╝██████╔╝██║░░██║██║░░██╗░██████╔╝███████║██╔████╔██║███████║  ██║░░██║█████╗░░  
            ██╔═══╝░██╔══██╗██║░░██║██║░░╚██╗██╔══██╗██╔══██║██║╚██╔╝██║██╔══██║  ██║░░██║██╔══╝░░  
            ██║░░░░░██║░░██║╚█████╔╝╚██████╔╝██║░░██║██║░░██║██║░╚═╝░██║██║░░██║  ██████╔╝███████╗  
            ╚═╝░░░░░╚═╝░░╚═╝░╚════╝░░╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░░░░╚═╝╚═╝░░╚═╝  ╚═════╝░╚══════╝  

                    ░█████╗░██████╗░███████╗  ███████╗  ░█████╗░███╗░░██╗██████╗░░░░░░██╗
                    ██╔══██╗██╔══██╗██╔════╝  ██╔════╝  ██╔══██╗████╗░██║██╔══██╗░░░░░██║
                    ██║░░╚═╝██████╔╝█████╗░░  █████╗░░  ██║░░╚═╝██╔██╗██║██████╔╝░░░░░██║
                    ██║░░██╗██╔═══╝░██╔══╝░░  ██╔══╝░░  ██║░░██╗██║╚████║██╔═══╝░██╗░░██║
                    ╚█████╔╝██║░░░░░██║░░░░░  ███████╗  ╚█████╔╝██║░╚███║██║░░░░░╚█████╔╝
                    ░╚════╝░╚═╝░░░░░╚═╝░░░░░  ╚══════╝  ░╚════╝░╚═╝░░╚══╝╚═╝░░░░░░╚════╝░
            ");
            }
            public static void ValidadorCPF()
            {
                Console.WriteLine(@"

            ██╗░░░██╗░█████╗░██╗░░░░░██╗██████╗░░█████╗░██████╗░░█████╗░██████╗░  ██████╗░███████╗
            ██║░░░██║██╔══██╗██║░░░░░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
            ╚██╗░██╔╝███████║██║░░░░░██║██║░░██║███████║██║░░██║██║░░██║██████╔╝  ██║░░██║█████╗░░
            ░╚████╔╝░██╔══██║██║░░░░░██║██║░░██║██╔══██║██║░░██║██║░░██║██╔══██╗  ██║░░██║██╔══╝░░
            ░░╚██╔╝░░██║░░██║███████╗██║██████╔╝██║░░██║██████╔╝╚█████╔╝██║░░██║  ██████╔╝███████╗
            ░░░╚═╝░░░╚═╝░░╚═╝╚══════╝╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝  ╚═════╝░╚══════╝

                                        ░█████╗░██████╗░███████╗
                                        ██╔══██╗██╔══██╗██╔════╝
                                        ██║░░╚═╝██████╔╝█████╗░░
                                        ██║░░██╗██╔═══╝░██╔══╝░░
                                        ╚█████╔╝██║░░░░░██║░░░░░
                                        ░╚════╝░╚═╝░░░░░╚═╝░░░░░
");
            }
            public static void GeradorCPF()
            {
                Console.WriteLine(@"

            ░██████╗░███████╗██████╗░░█████╗░██████╗░░█████╗░██████╗░  ██████╗░███████╗
            ██╔════╝░██╔════╝██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
            ██║░░██╗░█████╗░░██████╔╝███████║██║░░██║██║░░██║██████╔╝  ██║░░██║█████╗░░
            ██║░░╚██╗██╔══╝░░██╔══██╗██╔══██║██║░░██║██║░░██║██╔══██╗  ██║░░██║██╔══╝░░
            ╚██████╔╝███████╗██║░░██║██║░░██║██████╔╝╚█████╔╝██║░░██║  ██████╔╝███████╗
            ░╚═════╝░╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝  ╚═════╝░╚══════╝

                                    ░█████╗░██████╗░███████╗
                                    ██╔══██╗██╔══██╗██╔════╝
                                    ██║░░╚═╝██████╔╝█████╗░░
                                    ██║░░██╗██╔═══╝░██╔══╝░░
                                    ╚█████╔╝██║░░░░░██║░░░░░
                                    ░╚════╝░╚═╝░░░░░╚═╝░░░░░
");
            }
            public static void ValidadorCNPJ()
            {
                Console.WriteLine(@"

            ██╗░░░██╗░█████╗░██╗░░░░░██╗██████╗░░█████╗░██████╗░░█████╗░██████╗░  ██████╗░███████╗
            ██║░░░██║██╔══██╗██║░░░░░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
            ╚██╗░██╔╝███████║██║░░░░░██║██║░░██║███████║██║░░██║██║░░██║██████╔╝  ██║░░██║█████╗░░
            ░╚████╔╝░██╔══██║██║░░░░░██║██║░░██║██╔══██║██║░░██║██║░░██║██╔══██╗  ██║░░██║██╔══╝░░
            ░░╚██╔╝░░██║░░██║███████╗██║██████╔╝██║░░██║██████╔╝╚█████╔╝██║░░██║  ██████╔╝███████╗
            ░░░╚═╝░░░╚═╝░░╚═╝╚══════╝╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝  ╚═════╝░╚══════╝

                                    ░█████╗░███╗░░██╗██████╗░░░░░░██╗
                                    ██╔══██╗████╗░██║██╔══██╗░░░░░██║
                                    ██║░░╚═╝██╔██╗██║██████╔╝░░░░░██║
                                    ██║░░██╗██║╚████║██╔═══╝░██╗░░██║
                                    ╚█████╔╝██║░╚███║██║░░░░░╚█████╔╝
                                    ░╚════╝░╚═╝░░╚══╝╚═╝░░░░░░╚════╝░
");
            }
            public static void GeradorCNPJ()
            {
                Console.WriteLine(@"

            ██╗░░░██╗░█████╗░██╗░░░░░██╗██████╗░░█████╗░██████╗░░█████╗░██████╗░  ██████╗░███████╗
            ██║░░░██║██╔══██╗██║░░░░░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
            ╚██╗░██╔╝███████║██║░░░░░██║██║░░██║███████║██║░░██║██║░░██║██████╔╝  ██║░░██║█████╗░░
            ░╚████╔╝░██╔══██║██║░░░░░██║██║░░██║██╔══██║██║░░██║██║░░██║██╔══██╗  ██║░░██║██╔══╝░░
            ░░╚██╔╝░░██║░░██║███████╗██║██████╔╝██║░░██║██████╔╝╚█████╔╝██║░░██║  ██████╔╝███████╗
            ░░░╚═╝░░░╚═╝░░╚═╝╚══════╝╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝  ╚═════╝░╚══════╝

                                        ░█████╗░███╗░░██╗██████╗░░░░░░██╗
                                        ██╔══██╗████╗░██║██╔══██╗░░░░░██║
                                        ██║░░╚═╝██╔██╗██║██████╔╝░░░░░██║
                                        ██║░░██╗██║╚████║██╔═══╝░██╗░░██║
                                        ╚█████╔╝██║░╚███║██║░░░░░╚█████╔╝
                                        ░╚════╝░╚═╝░░╚══╝╚═╝░░░░░░╚════╝░
            ");
            }

        }

        static void Main(string[] args) //Início do Programa.
        {
            int opcaoEscolhida = 0, loop = 0;

            while (true) //Equanto a condição for verdadeira o laço irá se repetir
            {
                ExibirLogo.Menu();
                Console.WriteLine("Digite 1 para validar CPF.");
                Console.WriteLine("Digite 2 para gerar CPF.");
                Console.WriteLine("Digite 3 para validar CNPJ.");
                Console.WriteLine("Digite 4 para gerar CNPJ.");

                Console.Write("\nDigite sua opção: ");
                string opcao = Console.ReadLine();

                if (int.TryParse(opcao, out opcaoEscolhida)) //Tenta converter um tipo string para inteiro, se a operação for bem sucedida, retorna um valor booleano igual a True, caso contrário, igual a False e igual a zero.
                {
                    switch (opcaoEscolhida) //Verifica o caso correspondente ao valor testado
                    {
                        case 1: //Se digitar 1 o usuário vai para Validar CPF
                            loop++;
                            Console.Clear();
                            ValidadorCPF.ValidacaoDeCPF();
                            break;
                        case 2:
                            loop++;
                            Console.Clear();
                            ValidadorCPF.GeradorCPF();
                            break;
                        case 3: //Se digitar 2 o usuário vai para Validar CNPJ
                            loop++;
                            Console.Clear();
                            ValidadorCNPJ.ValidacaoDeCNPJ();
                            break;
                        case 4:
                            loop++;
                            Console.Clear();
                            ValidadorCNPJ.GeradorCNPJ();
                            break;
                        default: //Se digitar um número inteiro não correspondente, permanece no loop
                            if (loop == 2)
                            {
                                if (ComandosUniversais.VerNovamente("Deseja tentar novamente?")) //Continua o programa
                                {
                                    Console.Clear();
                                    loop = 0;
                                    continue;
                                }
                                else //Encerra o programa
                                {
                                    Console.WriteLine("Até a próxima!");
                                    Environment.Exit(0);
                                }
                            }
                            loop++;
                            Console.Clear();
                            Console.WriteLine($"A opção {opcao} é inválida.");
                            continue;
                    }
                }
                else //Caso digite um valor não numérico, permanece no loop
                {
                    if (loop == 2) //Faz com que o usuário caia na condição ver novamente caso ele erre 3 vezes
                    {
                        if (ComandosUniversais.VerNovamente("Desejar tentar novamente?"))
                        {
                            Console.Clear();
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
                    Console.Clear();
                    Console.WriteLine($"A opção {opcao} é inválida.");
                    continue;
                }
                if (loop >= 1) //Ao finalizar uma validação, o usuário será questionado se deseja ver novamente
                {
                    if (ComandosUniversais.VerNovamente("Deseja executar o programa novamente?"))  //Pergunta se o usuário deseja realizar outra validação
                    {
                        ExibirLogo.Menu();
                        Console.Clear();
                        loop = 0;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("\nAté a próxima!");
                        Environment.Exit(0);
                    }
                }
            }
        }

        public class ValidadorCPF
        {
            public static void ValidacaoDeCPF() //Diz se o CPF é ou não válido\\
            {
                ExibirLogo.ValidadorCPF();
                string cpf = ObterCPF();
                string cpfFormatado = FormatarCpf(cpf);
                if (ValidarCpf(cpf))
                {
                    ExibirLogo.ValidadorCPF();
                    ComandosUniversais.ExibirTexto($"O CPF {cpfFormatado} é válido! \nAté a Próxima!");

                }
                else
                {
                    ExibirLogo.ValidadorCPF();
                    ComandosUniversais.ExibirTexto($"O CPF {cpfFormatado} é inválido \nAté a Próxima!");
                }
            }

            static string ObterCPF() //Recebe o CPF\\
            {
                string cpf;
                int loop = 0;

                while (true)
                {
                    Console.Write("Digite o seu CPF (com apenas números): ");
                    cpf = Console.ReadLine().Trim();

                    if (AutenticarCpf(cpf)) //Caso a condição for verdadeira, ou seja, a estrutura do CPF esteja correto, encerra o laço de repetição.
                    {
                        break;
                    }

                    else //Caso a condição seja falsa, aumenta o loop e mantém o usuário no laço de repetição.
                    {
                        if (loop == 2) //Faz com que o usuário caia na condição ver novamente caso ele erre 3 vezes.
                        {
                            if (ComandosUniversais.VerNovamente("Desejar tentar novamente?"))
                            {
                                Console.Clear();
                                ExibirLogo.ValidadorCPF();
                                loop = 0; //Caso queira continuar, o loop é recomeçado.
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Até a próxima!"); //Caso não queira continuar, o programa encerra imediatamente.
                                Environment.Exit(0);
                            }
                        }
                        loop++;
                        continue;
                    }
                }
                return cpf;
            }

            static bool AutenticarCpf(string cpf) //Autentica a escrita do CPF.\\
            {
                if (!cpf.All(char.IsDigit) && cpf.Length != 11) //Verifica se o CPF não contém apenas dígitos númericos E tamanho inválido.
                {
                    Console.WriteLine("CPF Inválido!");
                    ComandosUniversais.ExibirTexto($"O CPF: {cpf} não contém apenas números e total de caracteres inválido.");
                }
                else if (!cpf.All(char.IsDigit)) //Verifica se o CPF não contém apenas dígitos númericos (o ponto de exclamação representa um não).
                {
                    Console.WriteLine("CPF Inválido!");
                    ComandosUniversais.ExibirTexto($"O CPF: {cpf} não contém apenas números.");
                }
                else if (cpf.Length != 11) //Verifica se o CPF contém o total de 11 caracteres.
                {
                    Console.WriteLine("CPF Inválido!");
                    ComandosUniversais.ExibirTexto($"O CPF: {cpf} teve o total de caracteres diferente de 11.");
                }
                return cpf.Length == 11 && cpf.All(char.IsDigit); //Caso as condições anteriores não sejam atendidas, retorna o CPF já com a escrita autenticada.
            }

            static bool ValidarCpf(string cpf) //Faz a verificação dos 2 dígitos verificadores do CPF\\
            {
                int[] cpfInt = cpf.Select(digito => Convert.ToInt32(digito.ToString())).ToArray(); //O cpf autenticado vem aqui, onde é convertido para um array tipo int.
                int resto1, resto2;
                CalculoDigitoVerificador(cpfInt, out resto1, out resto2);
                return resto1 == cpfInt[9] && resto2 == cpfInt[10];
            }

            public static void GeradorCPF() //Mostra o CPF gerado\\ 
            {
                while (true)
                {
                    string cpf = GerarCPF();
                    int opcaoEscolhida = 0, loop = 0;
                    string cpfFormatado = FormatarCpf(cpf);

                    ExibirLogo.GeradorCPF();
                    Console.WriteLine("Digite 1 para CPF com pontuação");
                    Console.WriteLine("Digite 2 para CPF sem pontuação.");
                    Console.WriteLine("Digite 3 para CPF com e sem pontuação.");

                    Console.Write("\nDigite sua opção: ");
                    string opcao = Console.ReadLine();
                    if (int.TryParse(opcao, out opcaoEscolhida))
                    {
                        switch (opcaoEscolhida)
                        {
                            case 1: //CPF com ponto
                                Console.Clear();
                                ExibirLogo.GeradorCPF();
                                ComandosUniversais.ExibirTexto($"CPF Gerado: {cpfFormatado}");
                                loop++;
                                break;
                            case 2: //CPF sem ponto
                                Console.Clear();
                                ExibirLogo.GeradorCPF();
                                ComandosUniversais.ExibirTexto($"CPF Gerado: {cpf}");
                                loop++;
                                break;
                            case 3: //CPF com e sem ponto
                                Console.Clear();
                                ExibirLogo.GeradorCPF();
                                ComandosUniversais.ExibirTexto($"CPF com pontuação: {cpfFormatado} \nCPF sem pontuação: {cpf}");
                                loop++;
                                break;
                            default:
                                if (loop == 2)
                                {
                                    if (ComandosUniversais.VerNovamente("Deseja tentar novamente?")) //Continua o programa
                                    {
                                        Console.Clear();
                                        ExibirLogo.GeradorCPF();
                                        loop = 0;
                                        continue;
                                    }
                                    else //Encerra o programa
                                    {
                                        Console.WriteLine("Até a próxima!");
                                        Environment.Exit(0);
                                    }
                                }
                                loop++;
                                Console.Clear();
                                ExibirLogo.GeradorCPF();
                                Console.WriteLine($"A opção {opcao} é inválida.");
                                continue;
                        }
                    }
                    else //Caso digite um valor não numérico, permanece no loop
                    {
                        if (loop == 2) //Faz com que o usuário caia na condição ver novamente caso ele erre 3 vezes
                        {
                            if (ComandosUniversais.VerNovamente("Desejar tentar novamente?"))
                            {
                                Console.Clear();
                                ExibirLogo.GeradorCPF();
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
                        Console.Clear();
                        ExibirLogo.GeradorCPF();
                        Console.WriteLine($"A opção {opcao} é inválida.");
                        continue;
                    }
                    if (loop >= 1) //Ao finalizar uma validação, o usuário será questionado se deseja ver novamente
                    {
                        if (ComandosUniversais.VerNovamente("Deseja gerar outro CPF?"))  //Pergunta se o usuário deseja realizar outra validação
                        {
                            Console.Clear();
                            ExibirLogo.GeradorCPF();
                            loop = 0;
                            continue;
                        }
                        else
                        {
                            Console.Clear();
                            ExibirLogo.GeradorCPF();
                            return;
                        }
                    }
                }
            }

            public static string GerarCPF() //Gera o CPF\\
            {
                while(true)
                {
                    Random random = new Random();
                    int[] cpfInt = new int[11];

                    for (int i = 0; i < cpfInt.Length; i++)
                    {
                        int randomNumber = random.Next(10); // Gera um número aleatório entre 0 e 9
                        cpfInt[i] = randomNumber;
                    }
                    string cpf;

                    int resto1, resto2;
                    CalculoDigitoVerificador(cpfInt, out resto1, out resto2);

                    if (cpfInt[9] == resto1 && cpfInt[10] == resto2)
                    {
                        cpf = string.Concat(cpfInt);
                        return cpf;       
                    }
                    else
                    {
                        continue;
                    }
                }                           
             
            }

            private static void CalculoDigitoVerificador(int[] cpfInt, out int resto1, out int resto2) //Faz o Cálculo dos 2 dígitos verificadores\\
            {
                int soma1 = 0, soma2 = 0;
                resto1 = 0;
                resto2 = 0;

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

                resto1 = (resto1 == 10 || resto1 == 11) ? 0 : resto1; //Aqui resume o if, é quase a mesma coisa, entretanto, ele testa a condição entre parenteses.
                resto2 = (resto2 == 10 || resto2 == 11) ? 0 : resto2; //Aí diz que caso a expressão seja verdadeira, ele retorna 0, após os : ele retorna o valor caso seja uma expressão falsa.

            }
            static string FormatarCpf(string cpf) //Formata o CPF.\\
            {
                Console.Clear();
                return $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9, 2)}"; //Dá para formatar o CPF sem que esteja em formato de array, até porque, string já é uma coletânea de dados.
            }
        }

        public class ValidadorCNPJ
        {
            public static void ValidacaoDeCNPJ() //Informa se o CNPJ é válido.
            {
                ExibirLogo.ValidadorCNPJ();
                string cnpj = ObterCNPJ();
                string cnpjFormatado = FormatarCNPJ(cnpj);
                if (ValidarCNPJ(cnpj))
                {
                    ExibirLogo.ValidadorCNPJ();
                    ComandosUniversais.ExibirTexto($"O CNPJ {cnpjFormatado} é válido! \nAté a Próxima");
                }
                else
                {
                    ExibirLogo.ValidadorCNPJ();
                    ComandosUniversais.ExibirTexto($"O CNPJ {cnpjFormatado} é inválido! \nAté a Próxima!");
                }

            }

            static string ObterCNPJ() //Recebe o CNPJ.
            {
                string cnpj;
                int loop = 0;

                while (true)
                {
                    Console.Write("Digite o seu CNPJ (Apenas com números): ");
                    cnpj = Console.ReadLine().Trim();

                    if (AutenticarCNPJ(cnpj))
                    {
                        break;
                    }

                    else //Caso o método retorne verdadeiro, encerra o loop e retorna o CPF já autenticado, sem que haja problemas com sua estrutura futuramente.
                    {
                        if (loop == 2) //Faz com que o usuário caia na condição ver novamente caso ele erre 3 vezes.
                        {
                            if (ComandosUniversais.VerNovamente("Desejar tentar novamente?"))
                            {
                                Console.Clear();
                                ExibirLogo.ValidadorCNPJ();
                                loop = 0; //Caso queira, o loop é recomeçado.
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Até a próxima!"); //Caso não queira, o programa encerra imediatamente.
                                Environment.Exit(0);
                            }
                        }
                        loop++;
                        continue;
                    }
                }
                return cnpj;
            }

            static bool AutenticarCNPJ(string cnpj) //Autentica a escrita do CNPJ.
            {
                if (!cnpj.All(char.IsDigit) && (cnpj.Length != 14))
                {
                    Console.WriteLine("CNPJ Inválido!");
                    ComandosUniversais.ExibirTexto($"O CNPJ: {cnpj} não contém apenas números e total de caracteres inválido.");
                }
                else if (!cnpj.All(char.IsDigit))
                {
                    Console.WriteLine("CNPJ Inválido!");
                    ComandosUniversais.ExibirTexto($"O CNPJ: {cnpj} não contém apenas números.");
                }
                else if (cnpj.Length != 14)
                {
                    Console.WriteLine("CNPJ Inválido!");
                    ComandosUniversais.ExibirTexto($"O CNPJ: {cnpj} teve o total de caracteres diferente de 14.");
                }
                return cnpj.Length == 14 && cnpj.All(char.IsDigit); //Retorna um valor verdadeiro caso o CNPJ siga essas condições.
            }

            static bool ValidarCNPJ(string cnpj) //Faz o Cálculo da validação de CNPJ.
            {
                int[] cnpjInt = cnpj.Select(digito => Convert.ToInt32(digito.ToString())).ToArray();
                int resto1, resto2;
                CalculoDigitoVerificador(cnpjInt, out resto1, out resto2);
                return resto1 == cnpjInt[12] && resto2 == cnpjInt[13]; //Caso tudo esteja correto, ele retorna um valor verdadeiro (CNPJ válido).
            }

            public static void GeradorCNPJ()
            {
                while (true)
                {
                    string cnpj = GerarCNPJ();
                    int opcaoEscolhida = 0, loop = 0;
                    string cnpjFormatado = FormatarCNPJ(cnpj);

                    ExibirLogo.GeradorCNPJ();
                    Console.WriteLine("Digite 1 para CNPJ com pontuação");
                    Console.WriteLine("Digite 2 para CNPJ sem pontuação.");
                    Console.WriteLine("Digite 3 para CNPJ com e sem pontuação.");
                    Console.Write("\nDigite sua opção: ");
                    string opcao = Console.ReadLine();
                    if (int.TryParse(opcao, out opcaoEscolhida))
                    {
                        switch (opcaoEscolhida)
                        {
                            case 1: //CNPJ com ponto
                                Console.Clear();
                                ExibirLogo.GeradorCNPJ();
                                ComandosUniversais.ExibirTexto($"CNPJ Gerado: {cnpjFormatado}");
                                loop++;
                                break;
                            case 2: //CPF sem ponto
                                Console.Clear();
                                ExibirLogo.GeradorCNPJ();
                                ComandosUniversais.ExibirTexto($"CNPJ Gerado: {cnpj}");
                                loop++;
                                break;
                            case 3: //CPF com e sem ponto
                                Console.Clear();
                                ExibirLogo.GeradorCNPJ();
                                ComandosUniversais.ExibirTexto($"CNPJ com pontuação: {cnpjFormatado} \nCNPJ sem pontuação: {cnpj}");
                                loop++;
                                break;
                            default:
                                if (loop == 2)
                                {
                                    if (ComandosUniversais.VerNovamente("Deseja tentar novamente?")) //Continua o programa
                                    {
                                        Console.Clear();
                                        ExibirLogo.GeradorCNPJ();
                                        loop = 0;
                                        continue;
                                    }
                                    else //Encerra o programa
                                    {
                                        Console.WriteLine("Até a próxima!");
                                        Environment.Exit(0);
                                    }
                                }
                                loop++;
                                Console.Clear();
                                ExibirLogo.GeradorCNPJ();
                                Console.WriteLine($"A opção {opcao} é inválida.");
                                continue;
                        }
                    }
                    else //Caso digite um valor não numérico, permanece no loop
                    {
                        if (loop == 2) //Faz com que o usuário caia na condição ver novamente caso ele erre 3 vezes
                        {
                            if (ComandosUniversais.VerNovamente("Desejar tentar novamente?"))
                            {
                                Console.Clear();
                                ExibirLogo.GeradorCNPJ();
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
                        Console.Clear();
                        ExibirLogo.GeradorCNPJ();
                        Console.WriteLine($"A opção {opcao} é inválida.");
                        continue;
                    }
                    if (loop >= 1) //Ao finalizar uma validação, o usuário será questionado se deseja ver novamente
                    {
                        if (ComandosUniversais.VerNovamente("Deseja gerar outro CNPJ?"))  //Pergunta se o usuário deseja realizar outra validação
                        {
                            Console.Clear();
                            ExibirLogo.GeradorCNPJ();
                            loop = 0;
                            continue;
                        }
                        else
                        {
                            Console.Clear();
                            ExibirLogo.GeradorCNPJ();
                            return;
                        }
                    }
                }
            }
            private static string GerarCNPJ()
            {
                while (true)
                {
                    Random random = new Random();
                    int[] cnpjInt = new int[14];
                    string cnpj;

                    for (int i = 0; i < cnpjInt.Length; i++)
                    {
                        int randomnumber = random.Next(10);
                        cnpjInt[i] = randomnumber;
                    }

                    int resto1, resto2;
                    CalculoDigitoVerificador(cnpjInt, out resto1, out resto2);
                    cnpjInt[12] = resto1;
                    cnpjInt[13] = resto2;

                    if (cnpjInt[12] == resto1 && cnpjInt[13] == resto2)
                    {
                        cnpj = string.Concat(cnpjInt);
                        return cnpj;
                    }
                    else
                    {
                        continue;
                    }
                }              
            }

            private static void CalculoDigitoVerificador(int[] cnpjInt, out int resto1, out int resto2)
            {
                int[] peso1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] peso2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int soma1 = 0, soma2 = 0;
                resto1 = 0;
                resto2 = 0;

                for (int i = 0; i < 12; i++)
                {
                    soma1 += cnpjInt[i] * peso1[i];
                    resto1 = soma1 % 11;
                }
                resto1 = (resto1 < 2) ? 0 : 11 - resto1; //Se o resto for < 2 então o resto é 0, caso contrário, 11 - resto.

                if (resto1 == cnpjInt[12]) //Caso o resto1 for igual a posição 12 do array cnpjInt, realiza o cálculo.
                {
                    for (int i = 0; i < 13; i++)
                    {
                        soma2 += cnpjInt[i] * peso2[i];
                        resto2 = soma2 % 11;
                    }
                    resto2 = (resto2 < 2) ? 0 : 11 - resto2;
                }
            }

            static string FormatarCNPJ(string cnpj) //Formata o CNPJ.
            {
                Console.Clear();
                return $"{cnpj.Substring(0, 2)}.{cnpj.Substring(2, 3)}.{cnpj.Substring(5, 3)}/{cnpj.Substring(8, 4)}-{cnpj.Substring(12, 2)}";
            }

        }

        public class ComandosUniversais
        {
            public static void ExibirTexto(string texto) //Comando exatamente porque eu quero fazer firula
            {
                int quantidadeDeLetras = texto.Length;
                string traco = string.Empty.PadLeft(quantidadeDeLetras, '='); //Basicamente ele conta automaticamente a quantidade de caracteres e preenche em cima e em baixo com "="
                Console.WriteLine("\n" + traco);
                Console.WriteLine(texto);
                Console.WriteLine(traco + "\n");
            }

            public static bool VerNovamente(string mensagem) //Responsável por captar uma tecla e fazer o usuário decidir se quer ou não continuar no programa
            {
                Console.WriteLine(mensagem);
                Console.Write("Clique em S para sim ou qualquer outra tecla para Não: ");
                ConsoleKeyInfo keyInfo = Console.ReadKey(); //Ele lê e armazena a tecla, ConsoleKeyInfo é uma estrutura do .NET

                Console.WriteLine();

                return (keyInfo.Key == ConsoleKey.S); //Retorna verdadeiro caso a tecla pressionada seja S
            }
        }
    }
}