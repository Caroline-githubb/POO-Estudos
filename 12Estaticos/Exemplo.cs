using System;

namespace _12Estaticos
{
    public class Exemplo
    {   
        //A ideia de trabalhar com atributo ou metodo estatico, é ter acesso sem precisar trabalhar com objeto
        //Atributo estático
        public static string nome = "carol"; 

        //Método estático
        public static void Soma(int n1, int n2) //da acesso a soma sem precisar instanciar o objeto
        {
            Console.WriteLine(n1 + n2);
        }
    }
}