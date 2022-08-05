using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBL
{
    internal class Study:Book
    {
        public override void GetDetails(params string[]? str)
        {
            Console.WriteLine($"{Name} under study category");
        }

        public override void display()
        {
            Console.WriteLine($"{Name} is added to cart");
        }
    }
}
