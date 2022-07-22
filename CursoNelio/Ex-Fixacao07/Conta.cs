using System.Globalization;

namespace Ex_Fixacao07
{
    class Conta
    {   
        public int Numero { get; private set; } 
        public string ?Titular { get; set; }
        public double Saldo { get; private set; }
 

        //Construtores
        public Conta()
        {

        }

        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;            
        }

        public Conta(int numero, string titular, double depositoInicial) : this(numero,titular)
        {            
            Deposito(depositoInicial);
        }


        public void OpcaoDeposito()
        {
            Console.Write("Entre um valor para depósito:");
            double quantia = double.Parse(Console.ReadLine() + "", CultureInfo.InvariantCulture);
            Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados:");
        }    

        public void OpcaoSaque()
        {
            Console.Write("Entre um valor para saque:");
            double quantia = double.Parse(Console.ReadLine() + "", CultureInfo.InvariantCulture);
            Saque(quantia);
            Console.WriteLine("Dados da conta atualizados:");
        }       
        
        public void Deposito(double quantia)
        {
            Saldo+= quantia;
        }
        public void Saque(double quantia)
        {
            Saldo-= quantia + 5.00;
        }
        
        public override string ToString()
        {
            return            
            "Conta: " + Numero + ", " +
            "Titular: " + Titular+ ", " +
            "Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}