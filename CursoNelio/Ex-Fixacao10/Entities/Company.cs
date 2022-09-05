namespace Ex_Fixacao10.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }
        public Company(int numberOfEmployees,string name, double anualInCome) : base(name, anualInCome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees > 10)
            {
                return (AnualInCome * 0.14);
            }
            else
            {
                return (AnualInCome * 0.16);
            }
        }
    }
}