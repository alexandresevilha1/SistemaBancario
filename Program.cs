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
                string valor;            
            
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

                         Console.WriteLine(@"
                        --------------------------------------
                        |                                    |
                        |  Por favor digite o valor inicial  |
                        |                                    |
                        --------------------------------------
                        ");

                        valor = Console.ReadLine();

                        var conta = new ContaBancaria(nome, Convert.ToDecimal(valor));

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

                    do
                    {

                        Console.Clear();

                        Console.WriteLine(@"
                        ------------------------------------------
                        |                                        |
                        |  Por favor selecione a opção desejada  |
                        |                                        |
                        |  1 - Fazer deposito                    |
                        |  2 - Fazer saque                       |
                        |  3 - Historico de transações           |
                        |                                        |
                        ------------------------------------------
                        ");

                        opcao = Console.ReadLine();

                        switch (opcao)
                        {
                            case "1":
                                Console.WriteLine(@"
                                ---------------------------------------
                                |                                     |
                                |  Por favor digite o valor desejado  |
                                |                                     |
                                ---------------------------------------
                                ");

                                valor = Console.ReadLine();

                                conta.FazerDeposito(Convert.ToDecimal(valor), DateTime.Now, "Entrada");

                                Console.WriteLine(@$"
                                --------------------------------------------------------
                                |                                                      |
                                |  Pronto {conta.Titular}, Deposito feito com sucesso  |
                                |                                                      |
                                |  Balanço: {conta.Balanco}                            |
                                |                                                      |
                                --------------------------------------------------------
                                ");

                                Console.ReadLine();

                                break;

                            case "2":

                                Console.WriteLine(@"
                                ---------------------------------------
                                |                                     |
                                |  Por favor digite o valor desejado  |
                                |                                     |
                                ---------------------------------------
                                ");

                                valor = Console.ReadLine();

                                conta.FazerSaque(Convert.ToDecimal(valor), DateTime.Now, "Saida");

                                Console.WriteLine(@$"
                                -----------------------------------------------------
                                |                                                   |
                                |  Pronto {conta.Titular}, Saque feito com sucesso  |
                                |                                                   |
                                |  Balanço: {conta.Balanco}                         |
                                |                                                   |
                                -----------------------------------------------------
                                ");

                                Console.ReadLine();

                                break;

                        }

                default:
                    Console.WriteLine(@"
                    ---------------------------------------
                    |                                     |
                    |  Por favor digite uma opção válida  |
                    |                                     |
                    ---------------------------------------
                    ");

                    Console.ReadLine();
                        break;

            }

        }
    }   
}
