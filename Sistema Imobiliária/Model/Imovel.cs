using System;

public abstract class Imovel
{
    protected int codigoImovel;
    protected string endereco;
    protected DateTime dataConstrucao;
    protected float AreaTotal;
    protected float AreaConstruida;
    protected int qtdDormitorios;
    protected int qtdBanheiros;
    protected int qtdVagasGaragem;
    protected float ValorIPTU;
    protected float ValorVenda;
    protected float ValorAluguel;


    public Imovel(int codigoImovel, string endereco, DateTime dataConstrucao, float AreaTotal, float AreaConstruida, int qtdDormitorios, int qtdBanheiros, int qtdVagasGaragem, float ValorIPTU, float ValorVenda, float ValorAluguel)
    {
        this.codigoImovel = codigoImovel;
        this.endereco = endereco;
        this.dataConstrucao = dataConstrucao;
        this.AreaTotal = AreaTotal;
        this.AreaConstruida = AreaConstruida;
        this.qtdDormitorios = qtdDormitorios;
        this.qtdBanheiros = qtdBanheiros;
        this.qtdVagasGaragem = qtdVagasGaragem;
        this.ValorIPTU = ValorIPTU;
        this.ValorVenda = ValorVenda;
        this.ValorAluguel = ValorAluguel;
    }

    public int getCodigoImovel()
    {
        return codigoImovel;
    }

    public void setCodigoImovel(int codigoImovel)
    {
        this.codigoImovel = codigoImovel;
    }

    public string getEndereco()
    {
        return endereco;
    }

    public void setEndereco(string endereco)
    {
        this.endereco = endereco;
    }

    public int getQtdDormitorios() 
    {
        return qtdDormitorios;
    }

    public void setQtdDormitorios(int qtdDormitorios) 
    {
        this.qtdDormitorios = qtdDormitorios;
    }

    public int getQtdBanheiros() 
    {
        return qtdBanheiros;
    }

    public void setQtdBanheiros(int qtdBanheiros) 
    {
        this.qtdBanheiros = qtdBanheiros;
    }

    public int getQtdVagasGaragem() 
    {
        return qtdVagasGaragem;
    }

    public void setQtdVagasGaragem(int qtdVagasGaragem) 
    {
        this.qtdVagasGaragem = qtdVagasGaragem;
    }

    public float getAreaTotal() 
    {
        return AreaTotal;
    }

    public void setAreaTotal(float AreaTotal) 
    {
        this.AreaTotal = AreaTotal;
    }

    public float getValorIPTU() 
    {
        return ValorIPTU;
    }

    public void setValorIPTU(float ValorIPTU) 
    {
        this.ValorIPTU = ValorIPTU;
    }

    public float getValorVenda() 
    {
        return ValorVenda;
    }

    public void setValorVenda(float ValorVenda) 
    {
        this.ValorVenda = ValorVenda;
    }

    public float getValorAluguel() 
    {   
        return ValorAluguel;
    }

    public void setValorAluguel(float ValorAluguel) 
    {
        this.ValorAluguel = ValorAluguel;
    }

    public float getAreaConstruida() 
    {
        return AreaConstruida;
    }

    public void setAreaConstruida(float AreaConstruida) 
    {
        this.AreaConstruida = AreaConstruida;
    }

    public DateTime getDataConstrucao() 
    {
        return dataConstrucao;
    }

    public void setDataConstrucao(DateTime dataConstrucao) 
    {
        this.dataConstrucao = dataConstrucao;
    }

    override
    public string ToString()
    {
        return "Codigo do Imovel: " + codigoImovel + 
               "\nEndereco: " + endereco + 
               "\nData de Construcao: " + dataConstrucao +
               "\n | Area Total: "+ AreaTotal +
               "\n | Area Construida: "+ AreaConstruida +
               "\n | Quartos: "+ qtdDormitorios +
               "\n | Banheiros: "+ qtdBanheiros +
               "\n | Vagas na Garagem: "+ qtdVagasGaragem +
               "\n | Valor de Venda: R$ "+ ValorVenda +
               "\n | Valor do Aluguel: R$ "+ ValorAluguel +
               "\n | Valor do IPTU: R$ "+ ValorIPTU;
    }
    
}   
