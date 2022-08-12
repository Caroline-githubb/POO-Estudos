namespace Ex_09.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; } //só pode ser alterado pela propria classe ou subclasse
        public Account()
        {
            
        }
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;            
        }

        //Colocando a palavra VIRTUAL, permite que esse metodo seja sobrescrito pelas subclasses
        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }
        
        public void Deposit(double amount)
        {
            Balance+=amount;
        }

        
        


    }
}