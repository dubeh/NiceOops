using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Employee
    {
        public int Id { get; set; }
        public string Designation { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        private string CareerGoals { get; set; }

        public Employee()
        {
            Salary = 2;
        }
        public Employee(string careerGoal, double salary)
        {
            CareerGoals = careerGoal;
            Salary = salary;
        }

        protected static Employee[] Getall()
        {
            Employee[] employees = new Employee[2];
            employees[0] = new Employee() { CareerGoals = "ni btaunga", Name = "parikshit", Id = 1, Designation = "Analyst", Salary = 5000000 };

            employees[1] = new Employee() { CareerGoals = "ni btaunga", Name = "parth dubey", Id = 1, Designation = "Analyst", Salary = 5000000 };

            return employees;
        }

        public virtual void PrintDetails()
        {
            Console.WriteLine($"{Name} is a {Designation}. His/Her EmpID is {Id}");
        }

        protected static double GetSalary(Employee emp)
        {
            return emp.Salary;
        }

        public void GetPassworsforSalary(string Password)
        {
            if (Password=="Password@1")
            {
                string result = string.Empty;
                foreach (var goal in CareerGoals)
                {
                    result += $"{goal}";

                }
                Console.WriteLine($"Salary: INR {Salary}, Career Goals: {result}");

            }
            else
            {
                Console.WriteLine("Invalid Password");
            }
        }
    }
}
