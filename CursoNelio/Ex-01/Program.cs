using System.Globalization;
using Ex_01;

namespace CursoNelio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();          

            Console.WriteLine("Informe as medidas do Triangulo X: ");
            x.LadoA = double.Parse(Console.ReadLine() + "", CultureInfo.InvariantCulture);            
            x.LadoB = double.Parse(Console.ReadLine() + "", CultureInfo.InvariantCulture);
            x.LadoC = double.Parse(Console.ReadLine() + "", CultureInfo.InvariantCulture);     

            double areaX = x.Area();              
            
            Console.WriteLine("Area X= " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            
            
            
           


        }
    }
}
