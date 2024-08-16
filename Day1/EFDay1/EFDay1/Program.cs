// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using EFDay1.Context;
using EFDay1.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
//IDisposable -> Dispose()
using ITIContext iTIContext = new ITIContext(); // will call the dispose funtion in a try& finally

    //iTIContext.Database.EnsureDeleted();// wrong for actual business
    iTIContext.Database.EnsureCreated();
//Student s = new Student() { Name = "Ola", Address = "Cairo", Age = 18, Allowance = 1000 };
//iTIContext.Students.Add(s);
//iTIContext.Students.Local; //this is the property that has the data from the table
//all student data are in the heap 
//add to the local variable inside the heap 
// then we have to commit the changes to the database
//Department dept = new Department() { Name = "SD" };
//Department dept2 = new Department() { Name = "Java" };
//iTIContext.Departments.Add(dept);
//iTIContext.Departments.Add(dept2);
Student student = iTIContext.Students.FirstOrDefault(s => s.Name.Contains("Ola"));
if(student != null )
{
    //student.Name = "Ola ALi";
    iTIContext.Students.Remove(student);
}
int numOfRowAffected = iTIContext.SaveChanges();
Console.WriteLine($"number of rows affected {numOfRowAffected}");
    //iTIContext.Dispose();
