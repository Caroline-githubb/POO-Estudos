using System.Globalization;

namespace Ex_Fixacao04
{
    public class Funcionario
    {
        public string Nome = string.Empty;
        public double SalarioBruto;
        public double Imposto;

        public void LerDados()
        {
            Console.Write("Nome: ");
            Nome = Console.ReadLine() + "";
            Console.Write("Salario Bruto: ");
            SalarioBruto = double.Parse(Console.ReadLine() + "", (CultureInfo.InvariantCulture));
            Console.Write("Imposto: ");
            Imposto = double.Parse(Console.ReadLine() + "", (CultureInfo.InvariantCulture));
        }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void ExibirDados()
        {            
            Console.WriteLine("Funcionario : " + Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));                
        }    

        public double LerAumento()
        {
            Console.WriteLine("Digite a porcentagem para aumentar o salario: ");
            double porcentagem = double.Parse(Console.ReadLine() + "", CultureInfo.InvariantCulture);
            return porcentagem;
        }

        public double AumentarSalario()
        {
            double porcentagem = 1 / LerAumento();
            SalarioBruto = SalarioBruto+(SalarioBruto*porcentagem);
            return SalarioBruto;
        }

        public void AtualizarDados()
        {            
            Console.WriteLine("Funcionario : " + Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));                
        } 

    }
}