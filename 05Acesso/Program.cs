using System;

namespace _05Acesso
{    public class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            p.nome = "carol"; //Só da acesso ao nome, pois o outro atributo é private;
            
        }

    }

}