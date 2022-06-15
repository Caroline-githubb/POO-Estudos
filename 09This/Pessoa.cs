using System;

namespace _09This
{
    class Pessoa
    {
        //Atributo
        private string nome = "Rodrigo";

        //Construtor
        public Pessoa(string nome)
        {
            Console.WriteLine(nome);
            Console.WriteLine(this.nome); //O comando this, remete ao atributo e não no parametro, se não colocar this, vai aparecer somente o
            //nome Carol que foi o que coloquei no Program como parametro
        }

        
    }
}