using System.Globalization;
using ResolucaoNelio07;

namespace Ex_Fixacao07.ResolucaoNelio07
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria();

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine() + "");
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine() + "";
            Console.Write("Haverá depósito inicial (s/n)?");
            string resp = Console.ReadLine() + "";
            if (resp == "s" || resp == "S")
            {
                Console.Write("Entre o valor de depósito inicial:");
                double depositoInicial = double.Parse(Console.ReadLine() + "", CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.Write("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito:");
            double quantia = double.Parse(Console.ReadLine() + "", CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine() + "", CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);




        }
    }
}
