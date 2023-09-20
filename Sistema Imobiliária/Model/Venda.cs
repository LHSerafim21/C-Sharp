using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Imobiliária.Model
{

    public class Venda
    {
    private int CodigoVenda;
    private Cliente cliente;
    private Corretor corretor;
    private Imovel imovel;
    private DateTime dataVenda;
    private float valorTotalVenda;
    private Pagamento formaPagamento;
    }

    public Venda(int CodigoVenda, Cliente cliente, Corretor corretor, Imovel imovel, DateTime dataVenda, float valorTotalVenda, Pagamento formaPagamento){
        this.CodigoVenda = CodigoVenda;
        this.cliente = cliente;
        this.corretor = corretor;
        this.imovel = imovel;
        this.dataVenda = dataVenda;
        this.valorTotalVenda = valorTotalVenda;
        this.formaPagamento = formaPagamento;
    }

    public int getCodigoVenda(){
        return CodigoVenda;
    }
    public void setCodigoVenda(int CodigoVenda){
        this.CodigoVenda = CodigoVenda;
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
    public DateTime getDataVenda(){
        return dataVenda;
    }
    public void setDataVenda(DateTime dataVenda){
        this.dataVenda = dataVenda;
    }
    public float getValorTotalVenda(){
        return valorTotalVenda;
    }
    public void setValorTotalVenda(float valorTotalVenda){
        this.valorTotalVenda = valorTotalVenda;
    }
    public Pagamento getFormaPagamento(){
        return formaPagamento;
    }
    public void setFormaPagamento(Pagamento formaPagamento){
        this.formaPagamento = formaPagamento;
    }

    public String ToString(){
        return  "Codigo Venda: " +CodigoVenda+
                "Cliente: " +cliente+
                "Corretor: " +corretor+
                "Imovel: " +imovel+
                "Data da Venda: " +dataVenda+
                "Valor Total Venda: " +valorTotalVenda+
                "Forma de Pagamento: " +formaPagamento;
    }
}