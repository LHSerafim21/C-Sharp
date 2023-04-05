namespace Sistema_Imobiliária
{
    public class Seguro
    {
        private int CodigoSeguro;
        private string NomeSeguradora;
        private string Tipo;
        private string Descricao;
        private float Valor;

        public Seguro(int CodigoSeguro, string NomeSeguradora, string Tipo, string Descricao, float Valor)
        {
            this.CodigoSeguro = CodigoSeguro;
            this.NomeSeguradora = NomeSeguradora;
            this.Tipo = Tipo;
            this.Descricao = Descricao;
            this.Valor = Valor;
        }

        public int getCodigoSeguro()
        {
            return CodigoSeguro;
        }

        public void setCodigoSeguro(int CodigoSeguro)
        {
            this.CodigoSeguro = CodigoSeguro;
        }

        public string getNomeSeguradora()
        {
            return NomeSeguradora;
        }

        public void setNomeSeguradora(string NomeSeguradora)
        {
            this.NomeSeguradora = NomeSeguradora;
        }

        public string getTipo()
        {
            return Tipo;
        }

        public void setTipo(string Tipo)
        {
            this.Tipo = Tipo;
        }

        public string getDescricao()
        {
            return Descricao;
        }

        public void setDescricao( string Descricao)
        {
            this.Descricao = Descricao;
        }

        public float getValor()
        {
            return Valor;
        }

        public void setValor(float Valor)
        {
            this.Valor = Valor;
        }

        public override string ToString(){
            return "Codigo do Seguro: " +CodigoSeguro+
                   "Nome da Seguradora: " +NomeSeguradora+
                   "Tipo: " +Tipo+
                   "Descricao: " +Descricao+
                   "Valor: " +Valor;
        }  
    }
}