using System;
using System.Security.Principal;

namespace SistemaBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new ContaBancaria("Alexandre", 1000);
            Console.WriteLine($"conta {conta.Numero} foi criada para {conta.Titular} com R$ {conta.Balanco}");

            conta.FazerSaque(200, DateTime.Now, "testando saque");
            Console.WriteLine(conta.Balanco);

            conta.FazerSaque(50, DateTime.Now, "Xbox");
            Console.WriteLine(conta.Balanco);

            Console.WriteLine(conta.HistoricoDeTrasacoes());
        }
    }   
}
