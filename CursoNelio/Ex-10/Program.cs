using System;
using System.Collections.Generic;
using System.Globalization;
using Ex_10.Entities;

List<Employee> list = new List<Employee>();

Console.WriteLine("Enter the number of employees:");
int n = int.Parse(Console.ReadLine() + "");

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Employee #{i} data: ");
    Console.WriteLine($"Outsourced(y/n)? ");
    char opcao = char.Parse(Console.ReadLine() + ""); //Console.ReadLine() + "";
    Console.WriteLine("Name: ");
    string name = Console.ReadLine() + "";
    Console.WriteLine("Hours: ");
    int hours = int.Parse(Console.ReadLine() + "");
    Console.WriteLine("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine() + "", CultureInfo.InvariantCulture);   
    if(opcao == 'y')
    {
        Console.WriteLine("Additional charge: ");
        double additionalCharge = double.Parse(Console.ReadLine() + "", CultureInfo.InvariantCulture); 
        list.Add(new OutSourceEmployee(name,hours,valuePerHour,additionalCharge));
    }
    else
    {
        list.Add(new Employee(name,hours,valuePerHour));
    }
}

Console.WriteLine();
Console.WriteLine("PAYMENTS:");
foreach(Employee emp in list)
{
    Console.WriteLine($"{emp.Name} - $ {emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
}

