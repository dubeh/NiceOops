using System;
using EmpBL;

class Program
{
    public static void Main()
    {
        //Hire();
        Polymorphism a = new Polymorphism3();
        a.call();
        Polymorphism2 b = new Polymorphism3();
        b.call();
        Polymorphism c = new Polymorphism2();
        c.call();


    }

    private static void Hire()
    {
       // do
        //{
            Employee e1 = new Employee();
            Console.WriteLine($"ENTER NAME");
            e1.EmpName = Console.ReadLine();
            Console.WriteLine($"ENTER ID");
            e1.EmpID = Console.ReadLine();
            Console.WriteLine($"ENTER role");
            e1.EmpDesignation = Console.ReadLine();
        e1.callLeave();

        Console.WriteLine(e1.EmpName,e1.EmpID, e1.EmpDesignation);

        //} while (true);
        
    }
}