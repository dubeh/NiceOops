using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsBL
{
    public class Rombhus:Rectangle
    {
        public float Angle { get; set; }

        //SHADOWING
         public override float Area()         //hiding parent class implementation of the method
        {
            return (float)(length*breadth*Math.Sin(Angle));
        }
        public override void Draw(params string[]? str)
        {
            Console.WriteLine($"using mordern equpi{Name} is drawn");
        }
    }
}
