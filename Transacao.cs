using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    public class Transacao  //Classe para transação
    {
        public decimal quantidade { get; }
        public DateTime data { get; }
        public string nota { get; }

        public Transacao (decimal quantidade, DateTime data, string nota)
        {
            this.quantidade = quantidade;
            this.data = data;
            this.nota = nota;
        }
    }
}
