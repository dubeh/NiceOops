using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBL
{
    internal class Story :Book
    {
        public override void GetDetails(params string[]? str)
        {
            Console.WriteLine($"{Name} under story category");
        }

        public override void display()
        {
            
            Console.WriteLine($"{Name} is added to cart ");
        }
    }
}
