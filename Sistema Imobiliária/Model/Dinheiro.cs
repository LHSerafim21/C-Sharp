using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Imobiliária
{
    public class Dinheiro : Pagamento
    {
        public Dinheiro(string TipoPagamento) : base(TipoPagamento)
        {
        }

        public override string ToString()
        {
            return "Dinheiro: \n" +"Tipo de Pagamento: " +TipoPagamento;
        }
    }
}