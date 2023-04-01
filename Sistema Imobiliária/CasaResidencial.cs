using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Imobiliária
{
    public class CasaResidencial : Imovel
    {
        public CasaResidencial(int codigoImovel, string endereco, DateTime dataConstrucao, float AreaTotal, float AreaConstruida, int qtdDormitorios, int qtdBanheiros, int qtdVagasGaragem, float ValorIPTU, float ValorVenda, float ValorAluguel) : base(codigoImovel, endereco, dataConstrucao, AreaTotal, AreaConstruida, qtdDormitorios, qtdBanheiros, qtdVagasGaragem, ValorIPTU, ValorVenda, ValorAluguel)
        {
        }

        override
        public string ToString()
        {
            return base.ToString();
        }
    }
}