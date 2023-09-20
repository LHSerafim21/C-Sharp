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
        private Cliente cliente;
        private Corretor corretor;
        private Imovel imovel;
        private DateTime DataAluguel;
        private DateTime DataDevolucao;
        private DateTime DataPagementoMensal;
        private float ValorPagementoMensal;
        private Pagamento FormaPagamento;
        private ArrayList<Seguro> SegurosContratados;
        private Boolean pago;

        public Aluguel(int CodigoAluguel, Cliente cliente, Corretor corretor, Imovel imovel, DateTime DataAluguel, DateTime DataDevolucao, DateTime DataPagamentoMensal, float ValorPagementoMensal, Pagamento FormaPagamento, ArrayList<Seguro> SegurosContratados, Boolean pago){
            this.CodigoAluguel = CodigoAluguel;
            this.cliente = cliente;
            this.corretor = corretor;
            this.imovel = imovel;
            this.DataAluguel = DataAluguel;
            this.DataDevolucao = DataDevolucao;
            this.DataPagementoMensal = DataPagementoMensal;
            this.ValorPagementoMensal = ValorPagementoMensal;
            this.FormaPagamento = FormaPagamento;
            this.SegurosContratados = SegurosContratados;
            this.pago = pago;
        }

        public int getCodigoAluguel(){
            return CodigoAluguel;
        } 
        public void setCodigoAluguel(int CodigoAluguel){
            this.CodigoAluguel = CodigoAluguel;
        }
        public Cliente getCliente(){
            return cliente;
        }
        public void setCliente(Cliente cliente){
            this.cliente = cliente;
        }
        public Corretor getCorretor(){
            return corretor;
        }
        public void setCorretor(Corretor corretor){
            this.corretor = corretor;
        }
        public Imovel getImovel(){
            return imovel;
        }
        public void setImovel(Imovel imovel){
            this.imovel = imovel;
        }
        public DateTime getDataAluguel(){
            return DataAluguel;
        }
        public void setDataAluguel(){
            this.DataAluguel = DataAluguel;
        }
        public DateTime getDataDevolucao(){
            return DataDevolucao;
        }
        public void setDataDevolucao(DateTime DataDevolucao){
            this.DataDevolucao = DataDevolucao;
        }
        public DateTime getDataPagamentoMensal(){
            return DataPagementoMensal;
        }
        public void setDataPagamentoMensal(){
            this.DataPagementoMensal = DataPagementoMensal;
        }
        public DateTime getValorPagamentoMensal(){
            return ValorPagementoMensal;
        }
        public void setValorPagamentoMensal(){
            this.ValorPagementoMensal = ValorPagementoMensal;
        }
        public DateTime getFormaPagamento(){
            return FormaPagemento;
        }
        public void setDataPagamentoMensal(){
            this.FormaPagemento = FormaPagemento;
        }
        








        
        
    }
}