using System.Globalization;

namespace Ex_Fixacao05
{
    public class Aluno
    {
        public string Nome;
        public double[] Notas = new double[3];

        public void LerAluno()
        {
            Console.Write("Nome do aluno: ");
            Nome = Console.ReadLine() + "";
            Console.WriteLine("Digite as três notas do aluno: ");
            for (int i = 0; i < Notas.Length; i++)
            {
                Notas[i] = double.Parse(Console.ReadLine() + "", CultureInfo.InvariantCulture);
            }
        }

        public double NotaFinal(double[] Notas)
        {
            return Notas.Sum();
        }

        public bool Aprovado()
        {
            if (NotaFinal(Notas) >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado()) { return 0.0; }

            else { return 60.0 - NotaFinal(Notas); }
        }

        public void ExibirResultado()
        {
            Console.Write("NOTA FINAL=  " + NotaFinal(Notas).ToString("F2", CultureInfo.InvariantCulture) + "\n");
            if (Aprovado()) { Console.WriteLine("APROVADO"); }
            else
            {
                Console.Write("REPROVADO \n");
                Console.WriteLine("FALTARAM " + NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + "PONTOS");
            }
        }


    }
}