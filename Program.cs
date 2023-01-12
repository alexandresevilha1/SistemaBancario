using System;
using System.Reflection;
using System.Security.Principal;

namespace SistemaBancario
{
    class Program
    {
        static void Main(string[] args)
        {

                string opcao;
                string nome;
            
                Console.WriteLine(@"
                  ----------------------------------------
                  |                                      |
                  |  !!Bem-Vindo(a) ao meu Super Banco!! |
                  |                                      |
                  ----------------------------------------
                ");

                Console.ReadLine();

                Console.Clear();

                Console.WriteLine(@"
                  --------------------------------------------
                  |                                          |
                  |  Por favor selecione a operação desejada |
                  |                                          |
                  |  1 - Criar uma nova conta                |
                  |                                          |
                  --------------------------------------------
                ");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                case "1":

                        Console.Clear();

                        Console.WriteLine(@"
                        -------------------------------------------
                        |                                         |
                        |  Por favor digite o nome do propietario |
                        |                                         |
                        -------------------------------------------
                        ");

                        nome = Console.ReadLine();

                        Console.Clear();

                        Console.WriteLine(@"
                        -------------------------------------------
                        |                                         |
                        |  Por favor digite um valor de deposito  |
                        |                                         |
                        -------------------------------------------
                        ");                     

                        var conta = new ContaBancaria(nome, 100);

                        Console.Clear();

                        Console.WriteLine(@$"
                        -----------------------------------------------------------------
                        |                                                               |
                        |  Parabens {conta.Titular}!! sua conta foi criada com sucesso  |
                        |                                                               |
                        |  Numero da conta: {conta.Numero}                              |
                        |  Saldo da conta: {conta.Balanco}                              |
                        -----------------------------------------------------------------
                        "); 

                        Console.ReadLine(); 

                    break;
                }

        }
    }   
}
