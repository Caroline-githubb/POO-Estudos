using System;

namespace _11Polimorfismo
{
    public class Atendente : Imposto
    {
         public override void ValeAlimentacao(double salario)
        {
            Console.WriteLine($"Desconto Atendente do vale alimentação R$ {salario * 0.12}");
        }
        
    }
}