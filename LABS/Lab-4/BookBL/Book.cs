using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBL
{
    public abstract class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Cost { get; set; }
        public int Cart { get; set; }

        public abstract void GetDetails(params string[]? str);

        public virtual void display()
        {
            Console.WriteLine($"yay");
        }

        public static Book getCategory(string? input)
        {
            
            do
            {
                int random1 = new Random().Next(100, 1000);
                int random2 = new Random().Next(100, 1000);
                switch (input.ToLower())
                {
                    case "harry potter":
                        return new Story() { Name = input,Cost = random1 };
                    case "algebra":
                        return new Study() { Name = input, Cost = random2 };
                    default:
                        throw new Exception("invalid Input");
                }

            } while (true);
            
        }
    }
}
