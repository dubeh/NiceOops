using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Relatives
    {
        /// <summary>
        /// 
        /// </summary>
        public void gossip()
        {
            Employee Parikshit = new Employee();
            AccountsExecutive exec = new AccountsExecutive();
            Console.WriteLine("Protected - Cannot Access");
            Parikshit.PrintDetails();
            exec.PrintDetails();
        }
    }

    internal class Auditor
    {
        public void PrintAcc()
        {
            AccountsExecutive obj = new AccountsExecutive();
            obj.PrintDetails();
        }
    }
}
