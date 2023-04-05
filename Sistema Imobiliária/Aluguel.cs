using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace Sistema_Imobiliária
{
    public class Aluguel
    {
        private int CodigoAluguel;
        private Cliente Cliente;
        private Corretor Corretor;
        private Imovel Imovel;
        private DateTime DataAluguel;
        private DateTime DataDevolucao;
        private DateTime DataPagementoMensal;
        private float ValorPagementoMensal;
        private Pagamento FormaPagamento;
        private ArrayList<Seguro> SegurosContratados;

        
    }
}