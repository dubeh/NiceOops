using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpBL
{
    public class Employee
    {
        public enum leavetypes
        {
            sickleave,
            covidleave,
            unpaidleave
        }
        public string EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpDesignation { get; set; }
       public double EmpSalary { get; set; }

        public void works(params string[] tasks)
        {
            string work = string.Empty;
            foreach (var item in tasks)
            {
                work += $"{item}";
            }

            Console.WriteLine(work);
        }

        public void callLeave()
        {
            appleave(leavetypes.covidleave);
        }

        public void appleave(leavetypes leave)
        {
            leavetypes a = leave;
            string b= a.ToString();
            switch (b)
            {   case "covidleave":Console.WriteLine($"10 days left");
                    break;
                default:
                    throw new Exception("error");
                    break;
            }
        }
    }
}
