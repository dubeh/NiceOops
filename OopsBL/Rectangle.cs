using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsBL
{

    public class Rectangle:Shape
    {
        public override void Draw(params string[]? str)
        {
            Console.WriteLine($"{Name} is Drawn with length={length} and breadth={breadth}");
        }
        public Rectangle()
        {

        }
        public Rectangle(float Length,float Breadth)
        {
            length = Length;
            breadth = Breadth;
        }
        public float length { get; set; }
        public float breadth { get; set; }

        public virtual float Area()
        {
            return length * breadth;
        }
        public float perimeter()
        {
            return 2*(length + breadth);
        }
    }
}
