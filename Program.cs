using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingame = "sim";
            string q1 = "Pergunta 1: Qual é a capital de Minas Gerais?";
            string q2 = "Pergunta 2: Qual é a capital do Acre?";
            string q3 = "Pergunta 3: Qual é a capital de Sergipe?";
            string q4 = "Pergunta 4: Qual é a capital da Paraíba?";
            string q5 = "Pergunta 5: Qual é a capital do Espírito Santo?";
            string r1 = "3";
            string r2 = "1";
            string r3 = "2";
            string r4 = "1";
            string r5 = "2";
            string resposta;

            Console.WriteLine("Quiz: Capitais do Brasil");
            Console.WriteLine("- by Lavie Murchio Beltrão, Maria Fernanda Paiva e Silva");
            Console.WriteLine("Para começar, pressione a tecla 'Enter'.");

            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Console.WriteLine();
                Console.WriteLine("Tecla inválida. Pressione novamente.");
                Console.WriteLine();
            }

            while (ingame == "sim")
            {
                int acertos = 0;
                int erros = 0;

                Console.WriteLine(q1);
                Console.WriteLine();
                Console.WriteLine("1) Maceió");
                Console.WriteLine("2) Cuiabá");
                Console.WriteLine("3) Belo Horizonte");
                Console.WriteLine("4) Manaus");
                Console.WriteLine("5) Boa Vista");
                Console.WriteLine();
                resposta = Console.ReadLine();
                if (resposta == r1)
                {
                    Console.WriteLine("Reposta Correta.");
                    acertos++;
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Reposta Incorreta.");
                    erros++;
                    Console.WriteLine();
                }
                Console.WriteLine("--------------------------------------------------------------");

                Console.WriteLine(q2);
                Console.WriteLine();
                Console.WriteLine("1) Rio Branco");
                Console.WriteLine("2) São Luís");
                Console.WriteLine("3) Palmas");
                Console.WriteLine("4) Goiânia");
                Console.WriteLine("5) Porto Alegre");
                Console.WriteLine();
                resposta = Console.ReadLine();
                if (resposta == r2)
                {
                    Console.WriteLine("Reposta Correta.");
                    acertos++;
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Reposta Incorreta.");
                    erros++;
                    Console.WriteLine();
                }
                Console.WriteLine("--------------------------------------------------------------");

                Console.WriteLine(q3);
                Console.WriteLine();
                Console.WriteLine("1) Natal");
                Console.WriteLine("2) Aracaju");
                Console.WriteLine("3) Maceió");
                Console.WriteLine("4) Porto Velho");
                Console.WriteLine("5) Recife");
                Console.WriteLine();
                resposta = Console.ReadLine();
                if (resposta == r3)
                {
                    Console.WriteLine("Reposta Correta.");
                    acertos++;
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Reposta Incorreta.");
                    erros++;
                    Console.WriteLine();
                }
                Console.WriteLine("--------------------------------------------------------------");

                Console.WriteLine(q4);
                Console.WriteLine();
                Console.WriteLine("1) Teresina");
                Console.WriteLine("2) Pernambuco");
                Console.WriteLine("3) Belém");
                Console.WriteLine("4) João Pessoa");
                Console.WriteLine("5) Recife");
                Console.WriteLine();
                resposta = Console.ReadLine();
                if (resposta == r4)
                {
                    Console.WriteLine("Reposta Correta.");
                    acertos++;
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Reposta Incorreta.");
                    erros++;
                    Console.WriteLine();
                }
                Console.WriteLine("--------------------------------------------------------------");

                Console.WriteLine(q5);
                Console.WriteLine();
                Console.WriteLine("1) Roraima");
                Console.WriteLine("2) Vitória");
                Console.WriteLine("3) Fortaleza");
                Console.WriteLine("4) Campo Grande");
                Console.WriteLine("5) Boa Vista");
                Console.WriteLine();
                resposta = Console.ReadLine();
                if (resposta == r5)
                {
                    Console.WriteLine("Reposta Correta.");
                    acertos++;
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Reposta Incorreta.");
                    erros++;
                    Console.WriteLine();
                }
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Fim de Jogo!");
                Console.WriteLine();
                Console.WriteLine("Acertos: " + acertos);
                Console.WriteLine("Erros: " + erros);
                Console.WriteLine();
                Console.WriteLine("Deseja jogar novamente?");
                Console.WriteLine("Digite 'sim' para jogar novamente");
                Console.WriteLine("Digite qualquer outro texto e pressione 'Enter' para fechar a janela.");
                ingame = Console.ReadLine();
                if (ingame != "sim")
                {
                    Environment.Exit(0);
                }   

            }
        }
    }
}
