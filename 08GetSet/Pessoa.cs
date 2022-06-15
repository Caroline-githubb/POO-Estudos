using System;

namespace _08GetSet
{
    class Pessoa
    {
        //Atributo nome
        private string nome;

        //Get e Set - pegar ou enviar valor...não é obrigado usar os dois sempre
        public string Nome // Nome maiusculo
        {
            get{return nome;} //Obter o nome, coloca o return
            set{nome=value;}  //Esse valor é o que o usuario vai me informar em outra classe
        }
    }
}