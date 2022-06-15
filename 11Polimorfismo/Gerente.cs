using System;

namespace _11Polimorfismo
{
    public class Gerente : Imposto
    {
        //Metodo
        public override void ValeAlimentacao(double salario)
        {
            Console.WriteLine($"Desconto Gerente do vale alimentação R$ {salario * 0.15}");
        }
    }
}