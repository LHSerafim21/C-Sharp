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
    }
}