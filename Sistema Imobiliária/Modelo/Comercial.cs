using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Imobiliária
{
    public class Comercial : Imovel
    {
        protected float TaxaImpostoFederal;

        public Comercial(int codigoImovel, string endereco, DateTime dataConstrucao, float AreaTotal, float AreaConstruida, int qtdDormitorios, int qtdBanheiros, int qtdVagasGaragem, float ValorIPTU, float ValorVenda, float ValorAluguel, float TaxaImpostoFederal) : base(codigoImovel, endereco, dataConstrucao, AreaTotal, AreaConstruida, qtdDormitorios, qtdBanheiros, qtdVagasGaragem, ValorIPTU, ValorVenda, ValorAluguel)
        {
            this.TaxaImpostoFederal = TaxaImpostoFederal;
        }
    
        public float getTaxaImpostoFederal()
        {
            return TaxaImpostoFederal;
        }

        public void serTaxaImpostoFederal(float TaxaImpostoFederal)
        {
            this.TaxaImpostoFederal = TaxaImpostoFederal;
        }

        public float getValorAluguel(float ValorAluguel)
        {   
            return ValorAluguel = ValorAluguel + TaxaImpostoFederal;
        }

        override
        public string ToString(){
            return base.ToString() + "Valor Aluguel: " + getValorAluguel();
        }
 
    }
}