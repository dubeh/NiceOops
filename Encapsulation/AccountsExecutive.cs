using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class AccountsExecutive:Employee
    {
        public override void PrintDetails()
        {
            var employee = Employee.Getall();
            double invest = 0;
            foreach (var emp in employee)
            {
                invest += GetSalary(emp);
                
            }
            Console.WriteLine($"investment ={invest}");
        }

    }
}
