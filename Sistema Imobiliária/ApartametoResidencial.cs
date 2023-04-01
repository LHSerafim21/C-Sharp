using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Imobiliária
{
    public class ApartametoResidencial : Imovel
    {   
        protected int andar;
        protected float ValorCondominio;

        public ApartametoResidencial(int codigoImovel, string endereco, DateTime dataConstrucao, float AreaTotal, float AreaConstruida, int qtdDormitorios, int qtdBanheiros, int qtdVagasGaragem, float ValorIPTU, float ValorVenda, float ValorAluguel, int andar, float ValorCondominio) : base(codigoImovel, endereco, dataConstrucao, AreaTotal, AreaConstruida, qtdDormitorios, qtdBanheiros, qtdVagasGaragem, ValorIPTU, ValorVenda, ValorAluguel)
        {
            this.andar = andar;
            this.ValorCondominio = ValorCondominio;
        }

        public int getAndar()
        {
            return andar;
        }

        public void setAndar(int andar)
        {
            this.andar = andar;
        }

        public float getValorCondominio()
        {
            return ValorCondominio;
        }

        public void setValorCondominior(float ValorCondominio)
        {
            this.ValorCondominio = ValorCondominio;
        }

        public float getValorAluguel()
        {   
            return ValorAluguel = ValorAluguel + ValorCondominio;
        }

        override
        public string ToString(){
            return base.ToString() + "Valor Aluguel: " + ValorCondominio + "Andar: " + andar;
        }
        
    }
}