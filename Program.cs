using System;
using System.Security.Principal;

namespace SistemaBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine($@"
        _____________________________________________
        |                                           |
        |   !!Bem vindo ao meu Sistema Bancario!!   |
        |                                           |
        ---------------------------------------------
                     Pressione Enter para continuar
            ");
            } while (Console.ReadKey().Key!= ConsoleKey.Enter);
        

        }
    }   
}
