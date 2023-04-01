using System;

namespace Cadastro
{
    class Tela_De_Inicio
    {   
        public void Main(string[] args)
        {   
            string nome, idade;
            int curso;

            Console.Clear();
            Console.WriteLine("Insira seu nome:");
            nome = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Olá " + nome + "! agora digite sua idade: ");
            idade = Console.ReadLine();

            Console.Clear();
            Console.WriteLine(nome + ", insira por favor o numero do curso que você esta matrículado: \n\n1-Ciencia da Computação\n2-Geografia\n3-Estatistica\n4-Arquitetura\n");
            curso = Console.Read();
            
            switch(curso){
                case '1': break;
                case '2': break;
                case '3': break;
                case '4': break;
            }

        }

    }
}

