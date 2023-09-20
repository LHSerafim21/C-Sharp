using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Imobiliária
{
    public class Cliente : Usuario
    {
        protected DateTime DataCadastro;

        public Cliente(int CodigoUsuario, string Nome, string Cpf, string Rg, DateTime DataNascimento, string Endereco, string Cep, string Telefone, string Email, DateTime DataCadastro) : base(CodigoUsuario, Nome, Cpf, Rg, DataNascimento, Endereco, Cep, Telefone, Email)
        {
            this.DataCadastro = DataCadastro;
        }

        public DateTime getDataCadastro()
        {
            return DataCadastro;
        }

        public void setDataCadastro(DateTime DataCadastro)
        {
            this.DataCadastro = DataCadastro;
        }

        public override string ToString()
        {
            return base.ToString() + "Data do Cadastro: " +DataCadastro;
        }

    }
}