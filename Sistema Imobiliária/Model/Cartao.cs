using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Imobiliária
{
    public class Cartao : Pagamento
    {
        private string Nome;
        private string Bandeira;
        private string Numero;

        public Cartao(string TipoPagamento, string Nome, string Bandeira, string Numero) : base(TipoPagamento)
        {
            this.Bandeira = Bandeira;
            this.Nome = Nome;
            this.Numero = Numero;
        }

        public string getNome()
        {
            return Nome;
        }

        public void setNome(string Nome)
        {
            this.Nome = Nome;
        }

        public string getBandeira()
        {
            return Bandeira;
        }

        public void setBandeira(string Bandeira)
        {
            this.Bandeira = Bandeira;
        }

        public string getNumero()
        {
            return Numero;
        }

        public void setNumero(string Numero)
        {
            this.Numero = Numero;
        }

        public override string ToString()
        {
            return "Cartao:\n" +"Nome: " +Nome+
                   "Bandeira: " +Bandeira+
                   "Numero: " +Numero;
        }
    }
}