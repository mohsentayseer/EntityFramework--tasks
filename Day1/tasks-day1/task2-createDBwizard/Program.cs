using task2_createDBwizard.context;
using task2_createDBwizard.Entities;

using Company_SDContext MyCompany = new Company_SDContext();
MyCompany.Database.EnsureCreated();
var employees = MyCompany.Employees;
foreach (var employee in employees)
    Console.WriteLine(employee);
Console.WriteLine("===========================================================================================");
Employee e1 = MyCompany.Employees.FirstOrDefault(s => s.Fname.Contains("mohsen"));
e1.Address = "portsaid";
Console.WriteLine(e1.Address);
Console.WriteLine("===========================================================================================");
var emp = MyCompany.Employees.Where(e => e.Salary > 4000).ToList();
if (emp != null)
{
    //MyCompany.Employees.RemoveRange(emp);
    foreach (var employee in emp)
        Console.WriteLine(employee);
}
int numOfRowAffected = MyCompany.SaveChanges();
Console.WriteLine($"number of rows affected {numOfRowAffected}");

