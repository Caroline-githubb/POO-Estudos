using System;

namespace _02Metodos
{
    public class Pessoa
    {
        //Metodo 01
        public void Apresentar()
        {
            Console.WriteLine("Ola");
        }
        //Metodo 02
        public void Apresentar(string nome)
        {
            Console.WriteLine($"Ola, meu nome é {nome}");
        }

        //Metodo 03
        public void Apresentar(string nome, int idade)
        {
            Console.WriteLine($"Ola, meu nome é {nome} e tenho {idade} anos");
        }   
    }
}