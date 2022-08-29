using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLab
{
    internal class Employee : IEmpContract
    {
        /*  public string Name { get; set; }
          public string ID { get; set; }
          public string Designation { get; set; }
          public string Department { get; set; }
          public float duration { get; set; }
          public string Client { get; set; }
          public string ProjectName { get; set; }

          public void AssignedProject(string ProjectName)
          {
              Console.WriteLine($"{ProjectName}is Assigned");
          }
          public void ProjectStatus(string ProjectName)
          {
              Console.WriteLine($"{ProjectName}is Active");
          }*/
        public string Name { get; set; }
        public string Designation { get; set; }
        public string ID { get; set; }

        public virtual void NoProjectDisclosures(string disclosure)
        {
            throw new NotImplementedException();
        }

        public virtual bool wearID(string id)
        {
            throw new NotImplementedException();
        }

        public virtual void workhours(float hours)
        {
            throw new NotImplementedException();
        }
    }
}
