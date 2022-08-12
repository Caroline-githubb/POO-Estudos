namespace Ex_09.Entities
{
    //classe selada nao deixa que outras classes herdem dessa classe
    sealed class SavingAccount : Account
    {
        public double InterestRate { get; set; }
        public SavingAccount()
        {
        }
        public SavingAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        //nao desconta os 5.0
        public override void Withdraw(double amount)
        {
            Balance -= amount;
        }

        // // USANDO BASE PARA REAPROVEITAR O METODO ANTERIOR E AO EM VEZ DE SER DESCONTADO 5.00, SER DESCONTADO SOMENTE 2.00
        // public override void Withdraw(double amount)
        // {
        //     base.Withdraw(amount);
        //     Balance -= 2.0;

        // METODO SELADO - CASO ESA CLASSE SEJA HERDADA POR ALGUMA OUTRA SUBCLASSE, NÃO SERÁ POSSIVEL SOBRESCREVER ESSE METODO
        // public sealed override void Withdraw(double amount)
        // {
        //     Balance -= amount;
        // }
    }

}
