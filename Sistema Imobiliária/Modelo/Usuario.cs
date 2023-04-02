using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Imobiliária
{
    public class Usuario
    {
        protected int CodigoUsuario;
        protected string Nome;
        protected string Cpf;
        protected string Rg;
        protected DateTime DataNascimento;
        protected string Endereco;
        protected string Cep;
        protected string Telefone;
        protected string Email;

        public Usuario(int CodigoUsuario, string Nome, string Cpf, string Rg, DateTime DataNascimento, string Endereco, string Cep, string Telefone, string Email)
        {
            this.CodigoUsuario = CodigoUsuario;
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Rg = Rg;
            this.DataNascimento = DataNascimento;
            this.Endereco = Endereco;
            this.Cep = Cep;
            this.Telefone = Telefone;
            this.Email = Email;
        }

        public int getCodigoImovel()
        {
            return CodigoUsuario;
        }

        public void setCodigoUsuario(int CodigoUsuario)
        {
            this.CodigoUsuario = CodigoUsuario;
        }

        public string getNome()
        {
            return Nome;
        }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }

        public string getCpf()
        {
            return Cpf;
        }

        public void setCpf(string Cpf)
        {
            this.Cpf = Cpf;
        }

        public string getRg()
        {
            return Rg;
        }

        public void setRg(string Rg)
        {
            this.Rg = Rg;
        }

        public DateTime getDataNascimento() 
        {
            return DataNascimento;
        }

        public void setDataNascimento(DateTime DataNascimento)
        {
            this.DataNascimento = DataNascimento;
        }

        public string getEndereco()
        {
            return Endereco;
        }

        public void setEndereco(string Endereco)
        {
            this.Endereco = Endereco;
        }

        public string getCep()
        {
            return Cep;
        }

        public void setCep(string Cep)
        {
            this.Cep = Cep;
        }

        public string getTelefone()
        {
            return Telefone;
        }

        public void setTelefone(string Telefone)
        {
            this.Telefone = Telefone;
        }

        public string getEmail()
        {
            return Email;
        }

        public void setEmail(string Email)
        {
            this.Email = Email;
        }

        public override string ToString()
        {
            return "Codigo Usuario: " +CodigoUsuario+
                   "Nome: " +Nome+
                   "Cpf: " +Cpf+
                   "Rg: " +Rg+
                   "Data de Nascimento: " +DataNascimento+
                   "Endereco: " +Endereco+
                   "Cep: " +Cep+
                   "Telefone: " +Telefone+
                   "E-mail: " +Email;
        }


    }
}