using System.Collections;
using Encapsulation;


string[] strArr = new string[3];


ArrayList arrList = new ArrayList();
arrList.Add("meena");
arrList.Add(1000);
arrList.Add(true);
arrList.Remove(1000);
arrList[0] = "neeta";

for (int i = 0; i < 2; i++)
{
    Console.WriteLine(arrList[i]);
}

List<string> list = new List<string>();
list.Add("meena");
list.Add("1000");
list.AddRange(new List<string> { "DSf", "sdfdf", "fsefs" });

foreach (var item in list)
{
    Console.WriteLine(item);
}
//base = new derived

ICollection<Employee> kpmgEmp = new List<Employee>();

kpmgEmp.Add(new Employee() { Designation = "analyst", Id = 122, Name = "Parth", Salary = 5000000 });
kpmgEmp.Add(new Employee() { Designation = "analyst", Id = 123, Name = "parikshit", Salary = 5000000 });
kpmgEmp.Add(new Employee() { Designation = "manager", Id = 124, Name = "Shruti", Salary = 5000000 });
kpmgEmp.Add(new Employee() { Designation = "associate consultant", Id = 125, Name = "Pritam", Salary = 5000000 });

foreach (var emp in kpmgEmp)
{
    Console.WriteLine($"{emp.Id},{ emp.Name},{ emp.Designation},{emp.Salary}");

}