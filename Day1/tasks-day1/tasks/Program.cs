using tasks.Context;
using tasks.Entities;

using HospitalContext myHospital = new HospitalContext();

//myHospital.Database.EnsureDeleted();
myHospital.Database.EnsureCreated();
Nurse n1 = new Nurse() { NurName = "mona", Address = "cairo", Age = 33, Salary = 8000, ShiftHours = 8 };
Nurse n2 = new Nurse() { NurName = "hoda", Address = "alex", Age = 22, Salary = 3000, ShiftHours = 8 };
//myHospital.Nurses.Add(n1);
//myHospital.Nurses.Add(n2);

Ward w1 = new Ward() { WardName = "FristWard", WardCapacityRooms = 10, MaxPatients = 20, CurrentPatients = 15 };
Ward w2 = new Ward() { WardName = "SecondWard", WardCapacityRooms = 5, MaxPatients = 15, CurrentPatients = 10 };
//myHospital.Wards.Add(w1);
//myHospital.Wards.Add(w2);


Nurse m = myHospital.Nurses.FirstOrDefault(s => s.NurName.Contains("mona"));
if (m != null)
{
    //m.Address = "tanta";
    myHospital.Nurses.Remove(m);
}
var nurses = myHospital.Nurses.Where(s => s.NurName == "mona").ToList();
if (nurses !=null)
{
    myHospital.Nurses.RemoveRange(nurses);
}
int numOfRowAffected = myHospital.SaveChanges();
Console.WriteLine($"number of rows affected {numOfRowAffected}");
