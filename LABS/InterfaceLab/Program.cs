using InterfaceLab;

Console.WriteLine("------KPMG COMPANY------");

//List<SoftwareEngg> projects = new List<SoftwareEngg>();
//SoftwareEngg obj1 = new Manager();
//SoftwareEngg obj2 = new Employee();
IEmpContract obj = new SoftwareEngg() { ProjectName="MIS"};

do
{
    Console.WriteLine("Enter project name to create one");
    string input = Console.ReadLine();

} while (Console.ReadLine()!="n");

    