using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLab
{
    internal interface IEmpContract
    {
        public void workhours(float hours);
        public void NoProjectDisclosures(string disclosure);
        public bool wearID(string id);
      
    }
}
