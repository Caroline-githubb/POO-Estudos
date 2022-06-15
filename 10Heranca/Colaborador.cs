using System;

namespace _10Heranca
{
    class Colaborador : Pessoa
    {
        //Atributos
        private double salario;

        //Construtor
        public Colaborador(string nome, int idade, double salario)
        {
            this.nome = nome;
            this.idade = idade;
            this.salario = salario;

            MensagemPessoa();
            MensagemColaborador();
        }


        //Metodo
        private void MensagemColaborador()
        {
            Console.WriteLine($"Salario: {salario}");
        }
    }
}