// See https://aka.ms/new-console-template for more information
using DataBaseFirst.Context;
Console.WriteLine("Hello, World!");
using Company_SDContext MyContext = new Company_SDContext();
MyContext.Database.EnsureCreated();
var employees= MyContext.Employees;

foreach (var employee in employees)
    Console.WriteLine(employee);