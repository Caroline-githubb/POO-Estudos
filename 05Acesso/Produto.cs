using System;

namespace _05Acesso
{
    class Produto
    {
        /*
            Modificador de acesso: É a maneira que temos para visualizar um atributo ou metodo;
            public -> Atributos e metodos visiveis para qualquer classe;
            private -> Atributos e metodos visiveis apenas na classe onde são criados;
            protected -> Atributos e metodos visiveis em classes onde são criados ou herdados;
            internal -> o acesso é limitado ao assembly atual.
        */

        public string? nome;
        private double valor;



    }
}