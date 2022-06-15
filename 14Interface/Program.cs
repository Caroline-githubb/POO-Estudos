using System;

namespace _14Interface
{
    public class Program
    {
        static void Main(string[] args)
        {
            IPadrao c = new Calculo();
            c.Somar(10, 15);
            c.Subtrair(50,18);
        }
    }
}