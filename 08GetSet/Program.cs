using System;

namespace _08GetSet
{    public class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.Nome = "Carol";// ele vai entender que é um set, que está enviando uma informação.
            //o Get é o que faz exibir o nome na tela;
            //se remover o get, vai dar erro porque não vai ter o acessador get;
            // se quiser obter uma informação, usa o get, se quiser enviar, o set;
            Console.WriteLine(p.Nome);
            
        }

    }

}