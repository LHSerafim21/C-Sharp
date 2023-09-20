using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Imobiliária
{
    public abstract class Pagamento
    {
        protected string TipoPagamento;

        public Pagamento(string TipoPagamento)
        {
            this.TipoPagamento = TipoPagamento;
        }

        public string getTipoPagamento()
        {
            return TipoPagamento;
        }

        public void setTipoPagamento(string TipoPagamento)
        {
            this.TipoPagamento = TipoPagamento;
        }

        override
        public abstract string ToString();
    }
}