using System;

namespace _07Construtor
{
    class Pessoa
    {
        //Construtor - sempre publico
        public Pessoa()
        {
            Console.WriteLine("Contrutor executado");
        }
        
        public Pessoa(string nome)
        {
            Console.WriteLine("Ola " + nome);
        }
    }
}