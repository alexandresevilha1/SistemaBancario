using System;

namespace SistemaBancario
{
    class ContaBancaria
    {
        public string Numero { get; }
        public string Titular { get; set; }
        public decimal Balanco
        {   get
            {
                decimal balanco = 0;
                foreach (var item in todasAsTransacoes) 
                {
                    balanco += item.quantidade;
                }
                return balanco;
            }
        }

        private static int NumeroDaConta = 1234567890;
        private List<Transacao> todasAsTransacoes = new List<Transacao>();
        public ContaBancaria(string nome, decimal balancoInicial) 
        {
            this.Titular = nome;
            FazerDeposito(balancoInicial, DateTime.Now, "balanco inicial");
            this.Numero = NumeroDaConta.ToString();
            NumeroDaConta++;
        }
        public void FazerDeposito(decimal quantidade, DateTime data, string nota)
        {
            if ( quantidade <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(quantidade), "Valor de deposito precisar ser positivo");
            }
            var deposito = new Transacao(quantidade, data, nota);
            todasAsTransacoes.Add(deposito);
        }
        public void FazerSaque(decimal quantidade, DateTime data, string nota)
        { 
            if (quantidade <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(quantidade), "Valor de saque precisar ser positivo");
            }
            if ( Balanco - quantidade < 0)
            {
                throw new InvalidOperationException("Fundos insuficientes");
            }
            var saque = new Transacao( -quantidade, data, nota );
            todasAsTransacoes.Add(saque);
            
        }
    }
}
