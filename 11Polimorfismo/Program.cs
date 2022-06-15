using System;

namespace _11Polimorfismo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Instanciar estagiário
            Imposto objetoE = new Estagiario();
            objetoE.ValeAlimentacao(1000);
            objetoE.ValeTransporte(1000);
            Console.WriteLine("--------------");
            //Instanciar gerente
            Imposto objetoG = new Gerente();
            objetoG.ValeAlimentacao(5000);
            objetoG.ValeTransporte(5000);
            Console.WriteLine("--------------");
            //Instanciar atendente 
            Imposto objetoA = new Atendente();
             objetoA.ValeAlimentacao(2000);
             objetoA.ValeTransporte(2000);
             Console.WriteLine("--------------");

        }
    }
}