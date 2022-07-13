using System;

namespace _01Conceitos
{
    public class Pessoa //Classe - molde do objeto
    {
        //Atribuitos (Caracteristicas que o objeto vai ter)
        public string nome = "";
        public int idade;

        //Metodos (ação)
        public void Mensagem() //void não havera retorno, só executara a ação e não guardara valores
        {
            Console.WriteLine($"Ola {nome} você tem {idade} anos");
        }
        
    }
}