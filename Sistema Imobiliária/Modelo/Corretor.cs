using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Imobiliária
{
    public class Corretor : Usuario
    {
        protected string Creci;
        protected float Salario;
        protected string Pis;
        protected DateTime DataAdmissao;

        public Corretor(int CodigoUsuario, string Nome, string Cpf, string Rg, DateTime DataNascimento, string Endereco, string Cep, string Telefone, string Email, string Creci, float Salario, string Pis, DateTime DataAdmissao) : base(CodigoUsuario, Nome, Cpf, Rg, DataNascimento, Endereco, Cep, Telefone, Email)
        {
            this.Creci = Creci;
            this.Salario = Salario;
            this.Pis = Pis;
            this.DataAdmissao = DataAdmissao;
        }

        public string getCreci()
        {
            return Creci;
        }

        public void setCreci(string Creci)
        {
            this.Creci = Creci;
        }

        public float getSalario()
        {
            return Salario;
        }

        public void setSalario(float Salario)
        {
            this.Salario = Salario;
        }

        public string getPis()
        {
            return Pis;
        }

        public void setPis(string Pis)
        {
            this.Pis = Pis;
        }

        public DateTime getDataAdmissao()
        {
            return DataAdmissao;
        }

        public void setDataAdmissao(DateTime DataAdmissao)
        {
            this.DataAdmissao = DataAdmissao;
        }

        public override string ToString()
        {
            return base.ToString() + "Creci: " +Creci+ "Salario: " +Salario+ "Pis: " +Pis+ "DataAdmissao: " +DataAdmissao;
        }
    }
}