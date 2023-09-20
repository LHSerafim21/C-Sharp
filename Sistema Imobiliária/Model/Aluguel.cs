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
        private float ValorTotalAluguel;
        private Pagamento FormaPagamento;
        private ArrayList<Seguro> SegurosContratados;
        private Boolean pago;

        public Aluguel(int CodigoAluguel, Cliente cliente, Corretor corretor, Imovel imovel, DateTime DataAluguel, DateTime DataDevolucao, DateTime DataPagamentoMensal, float ValorTotalAluguel, Pagamento FormaPagamento, ArrayList<Seguro> SegurosContratados, Boolean pago){
            this.CodigoAluguel = CodigoAluguel;
            this.cliente = cliente;
            this.corretor = corretor;
            this.imovel = imovel;
            this.DataAluguel = DataAluguel;
            this.DataDevolucao = DataDevolucao;
            this.DataPagementoMensal = DataPagementoMensal;
            this.ValorTotalAluguel = ValorTotalAluguel;
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
        public void setDataAluguel(DateTime DataAluguel){
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
        public void setDataPagamentoMensal(DateTime DataPagamentoMensal){
            this.DataPagementoMensal = DataPagementoMensal;
        }
        public DateTime getValorTotalAluguel(){
            return ValorTotalAluguel;
        }
        public void setValorTotalAluguel(float ValorTotalAluguel){
            this.ValorTotalAluguel = ValorTotalAluguel;
        }
        public Pagamento getFormaPagamento(){
            return FormaPagemento;
        }
        public void setFormaPagamento(Pagamento FormaPagemento){
            this.FormaPagemento = FormaPagemento;
        }
        public ArrayList<Seguro> getSegurosContratados(){
            return SegurosContratados;
        }
        public void setDataPagamentoMensal(ArrayList<Seguro> SegurosContratados){
            this.SegurosContratados = SegurosContratados;
        }
        public boolean getPago(){
            return pago;
        }
        public void setPago(boolean Pago){
            this.Pago = Pago;
        }

        public float CalcularValorTotal(){

            ValorTotalAluguel = Imovel.getValorAluguel + Seguro.getValor;

            return ValorTotalAluguel;
        }

        public Boolean PossuiSeguro(){
            
            if(SegurosContratados == NULL){
                return false;
            } 
            else{return true;}
        }

        public Boolean VerificarAtraso(){
            if(DataAluguel >= DataPagementoMensal){
                return true;
            }
            else{return false;}
        }

        public String ToString(){

            return  "Codigo do Aluguel: " + CodigoAluguel +
                    "Cliente: " + cliente +
                    "Corretor: " + corretor +
                    "Imovel: " + imovel +
                    "Data do Aluguel: " + DataAluguel +
                    "Data da Devolução: " + DataDevolucao +
                    "Data do Pagamento: " + DataPagementoMensal +
                    "Valor Total do Aluguel: " + CalcularValorTotal() +
                    "Seguros Contratados: " + SegurosContratados +
                    "Pago: " + pago;
        }






        
        
    }
}