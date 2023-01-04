using System;
using System.Text;

namespace SistemaBancario
{
    class ContaBancaria
    {
        public string Numero { get; } //Getters e Setters dessa classe
        public string Titular { get; set; }
        public decimal Balanco  // Getter do balanço, somando todas as transações
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

        private static int NumeroDaConta = 1234567890; //Numero padrão pra numero da conta
        private List<Transacao> todasAsTransacoes = new List<Transacao>();  //Criação de lista de transações usando a classe Transacao criada anteriormente
        public ContaBancaria(string nome, decimal balancoInicial)  //Creator da conta bancaria
        {
            this.Titular = nome;
            FazerDeposito(balancoInicial, DateTime.Now, "balanco inicial");
            this.Numero = NumeroDaConta.ToString();
            NumeroDaConta++;
        }
        public void FazerDeposito(decimal quantidade, DateTime data, string nota)  //Função para fazer deposito
        {
            if ( quantidade <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(quantidade), "Valor de deposito precisar ser positivo");
            }
            var deposito = new Transacao(quantidade, data, nota);
            todasAsTransacoes.Add(deposito);
        }
        public void FazerSaque(decimal quantidade, DateTime data, string nota)  //Função para fazer saque
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
        public string HistoricoDeTrasacoes()  //Função para mostrar extrato de transações
        {
            var reporte = new StringBuilder();
            reporte.AppendLine("Data\tQuantidade\tNota");
            foreach (var item in todasAsTransacoes)
            {
                reporte.AppendLine($"{item.data.ToShortDateString()}\t{item.quantidade}\t{item.nota}");
            }
            return reporte.ToString();
        }
    }
}
