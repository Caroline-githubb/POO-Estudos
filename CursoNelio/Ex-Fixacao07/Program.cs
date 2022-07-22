using System.Globalization;

namespace Ex_Fixacao07
{
    public class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine() + "");
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine() + "";
            Console.Write("Haverá depósito inicial (s/n)?");
            string opcao= Console.ReadLine() + "";
            if (opcao == "s" || opcao == "S")
            {
                Console.Write("Entre o valor de depósito inicial:");
                double depositoInicial = double.Parse(Console.ReadLine() + "", CultureInfo.InvariantCulture);
                conta = new Conta(numero, titular,depositoInicial);
            }
            else
            {
                conta = new Conta(numero, titular);
            }

            Console.WriteLine();
            Console.Write("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            conta.OpcaoDeposito();
            Console.WriteLine(conta);

            Console.WriteLine();
            conta.OpcaoSaque();
            Console.WriteLine(conta);

        }
    }
}