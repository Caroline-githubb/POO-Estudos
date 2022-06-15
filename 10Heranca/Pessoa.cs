using System;

namespace _10Heranca
{
    class Pessoa
    {
        //Atributos
        protected string nome;
        protected int idade;

        //Metodo
        protected void MensagemPessoa()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");

        }
        
    }
}