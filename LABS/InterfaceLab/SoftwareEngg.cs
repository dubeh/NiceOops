using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLab
{

    internal class SoftwareEngg :Employee
    {
       
        public string Client { get; set; }
        public string ProjectName { get; set; }

        public virtual void NoProjectDisclosures(string disclosure)
        {
            Console.WriteLine("no disclosure");

        }

        public virtual bool wearID(string id)
        {
            Console.WriteLine("id detected");
            return true;
        }

        public virtual void workhours(float hours)
        {
            Console.WriteLine("a lot of work hours");
        }
    }

}
