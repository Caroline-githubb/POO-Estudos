using System;

namespace _11Polimorfismo
{
    public class Imposto
    {
        //Metodos
        public virtual void ValeAlimentacao(double salario)
        {
            Console.WriteLine($"Desconto padrão do vale alimentação R$ {salario * 0.1}");
        }

        public void ValeTransporte(double salario)
        {
            Console.WriteLine($"Desconto padrão do vale transporte R$ {salario * 0.06}");
        }
    }
}