using System.Globalization;
using Ex_Fixacao06;

namespace CursoNelio
{
    public class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Qual é a cotação do dolar?");
            double cotacao = double.Parse(Console.ReadLine()+"", CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dolares você vai comprar?");
            double dolar = double.Parse(Console.ReadLine()+"", CultureInfo.InvariantCulture);

            double resultado = ConversorMoeda.DolarParaReal(cotacao,dolar);

            Console.WriteLine("Valor a ser pago em reais = "+ resultado.ToString("F2", CultureInfo.InvariantCulture));

              


        }
    }
}