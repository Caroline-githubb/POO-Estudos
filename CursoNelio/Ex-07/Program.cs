﻿using System.Globalization;
using Ex_07.Entities;
using Ex_07.Entities.Enum;

Console.Write("Enter departament's name: ");
string deptName = Console.ReadLine();
Console.WriteLine("Enter worker data: ");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.WriteLine("Level(Junior/MidLevel/Senior) : ");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
Console.Write("Base salary: ");
double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


Departament dept = new Departament(deptName);
Worker worker = new Worker(name, level, baseSalary, dept);

Console.Write("How many contracts to this worker? ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Enter #{i} contract data: ");
    Console.Write($"Date (DD/MM/YYYY): ");
    DateTime date = DateTime.Parse(Console.ReadLine());
    Console.Write($"Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write($"Duration: ");
    int hours = int.Parse(Console.ReadLine());
    HourContract contract = new HourContract(date, valuePerHour, hours);
    worker.AddContract(contract);
}

    Console.WriteLine();
    Console.Write("Enter month and year to calculate income (MM/YYYY): ");
    string monthAndYear = Console.ReadLine();
    int month = int.Parse(monthAndYear.Substring(0,2)); //recorta as posicoes iniciando da posicao 0 ate 2
    int year = int.Parse(monthAndYear.Substring(3));//vai recortar da posicao 3 para frente
    Console.WriteLine("Name: " + worker.Name);
    Console.WriteLine("Departament: " + worker.Departament.Name);
    Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year,month));



    

