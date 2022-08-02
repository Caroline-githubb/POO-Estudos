
using Ex_07.Entities.Enum;

namespace Ex_07.Entities
{
    class Worker //Trabalhador
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; } //nivel do trabalhador
        public double BaseSalary { get; set; }
        public Departament  Departament { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        public Worker()
        {
            
        }
        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }
        public void AddContract(HourContract contratc)
        {
            Contracts.Add(contratc);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach(HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum+= contract.TotalValue();

                }                
            }
            return sum;
        }

        
    }
}