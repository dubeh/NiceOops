using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsBL
{
   public class square:Rectangle
    {
        public square()
        {
                    
        }
        public square(float side):base(side,side)
        {
           // Side = side;
        }
        //public float Side { get; set; }

        public override float Area()
        {
           Console.WriteLine("this are is calc in collab with rect");
            return base.Area();
        }

        public override void Draw(params string[]? str)
        {
            Console.WriteLine($"using mordern equpi{Name} is drawn");
        }

    }
}
