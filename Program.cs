using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
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

            do
            {

                Console.WriteLine(@"
                  --------------------------------------
                  |                                    |
                  |  !!Bem vindo ao meu SUPER BANCO!!  |
                  |                                    |
                  --------------------------------------

                ");

                Console.ReadLine();

                Console.Clear();
                Console.WriteLine(@"
                  --------------------------------------------
                  |                                          |
                  |  Por favor digite uma das opções abaixo  |
                  |                                          |
                  |  1 - Criar uma nova conta                |
                  |                                          |
                  |          digite 0 para encerrar o sistema|
                  --------------------------------------------
                ");

                opcao = Console.ReadLine();

                switch(Convert.ToInt32(opcao)) 
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine(@"
                          ----------------------------------------
                          |                                      |
                          |  Por favor digite o nome do Titular  |
                          |                                      |
                          |      digite 0 para encerrar o sistema|
                          ----------------------------------------
                        ");

                        nome = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine(@"
                          --------------------------------------------------
                          |                                                |
                          |  Por favor digite o valor de deposito inicial  |
                          |                                                |
                          |                digite 0 para encerrar o sistema|
                          --------------------------------------------------
                        ");

                        valor = Console.ReadLine();

                        try
                        {
                            var conta = new ContaBancaria(nome, Convert.ToInt32(valor));

                            Console.Clear();
                            Console.WriteLine(@$"
                              -------------------------------------------------------------------
                              |                                                                 |
                              |  Parabens {conta.Titular}!! você criou sua conta com sucesso!!  |
                              |                                                                 |
                              |  Numero da conta: {conta.Numero}                                |
                              |  Balanço da conta: {conta.Balanco}                              |
                              |                                                                 |
                              |                                 digite 0 para encerrar o sistema|
                              -------------------------------------------------------------------
                            ");
                        }
                        catch (Exception)
                        {
                            Console.Clear();
                            Console.WriteLine(@"
                              ---------------------------------------
                              |                                     |
                              |  Por favor digite um valor vállido  |
                              |                                     |
                              |     digite 0 para encerrar o sistema|
                              ---------------------------------------
                            ");
                        }

                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine(@"
                          ---------------------------------------
                          |                                     |
                          |  Por favor digite uma opção válida  |
                          |                                     |                                                
                          ---------------------------------------
                        ");
                        break;
                }


            } while (Convert.ToInt32(opcao) != 0);

        }
    }   
}
