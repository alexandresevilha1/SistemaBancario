using System;
using System.Reflection;
using System.Security.Principal;

namespace SistemaBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine(@"
        _____________________________________________
        |                                           |
        |   !!Bem vindo ao meu Sistema Bancario!!   |
        |                                           |
        ---------------------------------------------
                     Pressione Enter para continuar
            ");
            } while (Console.ReadKey().Key!= ConsoleKey.Enter);

            do 
            {
                Console.WriteLine(@"
                _____________________________________________
                |        Pressione 0 para terminar a sessão |
                |                                           |
                | Por favor escolha uma das opções abaixo   |
                |                                           |
                |     1 - Criar conta                       |  
                |                                           | 
                ---------------------------------------------
                ");

                var opcao = Console.ReadLine();
                
                switch(opcao)
                {
                    case "1":

                        Console.WriteLine(@"
                        _____________________________________________
                        |        Pressione 0 para terminar a sessão |
                        |                                           |
                        |     Por favor digite nome do titular      |
                        |                                           |                                               
                        ---------------------------------------------
                        ");

                        string nome = Console.ReadLine();

                        var conta = new ContaBancaria(nome, 0);
                        break;

                    default:
                        Console.WriteLine("Por favor digite uma opção valida");
                        break;
                }
            } while (Console.ReadKey().Key != 0);

        }
    }   
}
