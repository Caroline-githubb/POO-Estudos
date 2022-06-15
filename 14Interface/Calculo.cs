using System;

namespace _14Interface
{
    class Calculo : IPadrao
    {   
        //aqui pode definir se serão publicos, privados ou protegidos
        public void Somar(int n1, int n2)
        {
            Console.WriteLine("A soma é " + (n1+n2));
        }

        public void Subtrair(int n1, int n2)
        {
            Console.WriteLine("A subtração é " + (n1-n2));
        }
    }
}