using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpBL
{
    public class Polymorphism
    {
        public virtual void call()
        {
            Console.WriteLine("in A");
        }
        
    }
    public class Polymorphism2:Polymorphism
    {
        public new void call()
        {
            Console.WriteLine("in B");
        }

    }
    public class Polymorphism3:Polymorphism2
    {
        public void call()
        {
            Console.WriteLine("in C");
            base.call();
        }

    }

}
