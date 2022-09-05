using System.Globalization;
using Ex_Fixacao10.Entities;

List<TaxPayer> list = new List<TaxPayer>();

Console.WriteLine("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine() + "");

for(int i = 1; i <= n;i++)
{
    Console.WriteLine($"Tax payer #{i} data:");
    Console.Write("Individual or company (i/c)? ");
    char ch = char.Parse(Console.ReadLine()+"");
    Console.Write("Name: ");
    string name = Console.ReadLine() + "";
    Console.Write("Anual In Come: ");
    double anualInCome = double.Parse(Console.ReadLine() + "", CultureInfo.InvariantCulture);
    if(ch == 'i')
    {
        Console.Write("Health expenditures: ");
        double healthExpenditures = double.Parse(Console.ReadLine()+"", CultureInfo.InvariantCulture);
        list.Add(new Individual(healthExpenditures, name, anualInCome));
    }
    else
    {
        Console.Write("Number of employees: ");
        int numberOfEmployees = int.Parse(Console.ReadLine()+"");
        list.Add(new Company(numberOfEmployees,name,anualInCome));
    }  
}

Console.WriteLine();
Console.WriteLine("TAXES PAID:");
double tax=0;

foreach(TaxPayer taxPayer in list)
{
    Console.WriteLine($"{taxPayer.Name}: $ {taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
    tax = tax+ taxPayer.Tax();
}

Console.WriteLine($"TOTAL TAXES: $ {tax.ToString("F2", CultureInfo.InvariantCulture)}");

