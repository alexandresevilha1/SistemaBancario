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

                var nome = "a";
                var opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                       
                        do
                        {

                            Console.WriteLine(@"
                        _____________________________________________
                        |        Pressione 0 para terminar a sessão |
                        |                                           |
                        |     Por favor digite nome do titular      |
                        |                                           |                                               
                        ---------------------------------------------
                        ");

                            nome = Console.ReadLine();

                        } while (nome == "a");

                        var conta = new ContaBancaria(nome, 1);

                        Console.WriteLine(@$"
                        _____________________________________________
                        |        Pressione 0 para terminar a sessão |
                        |                                           |
                        | Parabens Sua conta foi criada com sucesso |
                        |                                           |   
                        |    Titular: {conta.Titular}               | 
                        |    Numero: {conta.Numero}                 |
                        |    Balanço: {conta.Balanco}               |
                        ---------------------------------------------
                        ");
                        Console.ReadKey();

                        Console.WriteLine(@"
                        _____________________________________________
                        |        Pressione 0 para terminar a sessão |
                        |                                           |
                        | Por favor escolha uma das opções abaixo   |
                        |                                           |
                        |     1 - Fazer Deposito                    |  
                        |     2 - Fazer Saque                       | 
                        |                                           |
                        ---------------------------------------------
                        ");
                        break;

                    default:
                        Console.WriteLine("Por favor digite uma opção valida");
                        break;
                }

            } while (Console.ReadKey().Key != 0);

        }
    }   
}
