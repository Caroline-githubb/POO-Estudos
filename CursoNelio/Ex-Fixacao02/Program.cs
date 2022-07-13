using Ex_Fixacao02;
using System;
using System.Globalization;

namespace CursoNelio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários
           Pessoa p1 = new Pessoa();
           Pessoa p2 = new Pessoa();

           Console.WriteLine("Informe o nome do funcionário 1: ");
           p1.Nome = Console.ReadLine() + "";
           Console.WriteLine("Informe o salário: ");
           p1.Salario = double.Parse(Console.ReadLine() + "", CultureInfo.InvariantCulture);

           Console.WriteLine("Informe o nome do funcionário 2: ");
           p2.Nome = Console.ReadLine()+ ""; 
           Console.WriteLine("Informe o salário: ");
           p2.Salario = double.Parse(Console.ReadLine() + "", CultureInfo.InvariantCulture);

           double media = (p1.Salario + p2.Salario) / 2.0;

           Console.WriteLine($"A media do salario dos dois funcionarios e de {media.ToString("F2", CultureInfo.InvariantCulture)}");


          



        }
    }
}
