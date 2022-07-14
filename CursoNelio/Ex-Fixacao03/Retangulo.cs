using System.Globalization;

namespace Ex_Fixacao03
{
    public class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2.0 * (Largura + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt((Altura * Altura + Largura * Largura));
        }

        public void EntradaDados()
        {
            Console.WriteLine("Entre com a largura e altura do retangulo: ");
            Largura = double.Parse(Console.ReadLine() + "", CultureInfo.InvariantCulture);
            Altura = double.Parse(Console.ReadLine() + "", CultureInfo.InvariantCulture);
        }

        public void ExibirDados()
        {
            Console.Write("AREA = " + Area().ToString("F2", CultureInfo.InvariantCulture) + "\n");
            Console.Write("PERIMETRO = " + Perimetro().ToString("F2", CultureInfo.InvariantCulture) + "\n");
            Console.Write("DIAGONAL = " + Diagonal().ToString("F2", CultureInfo.InvariantCulture) + "\n");
        }




    }
}