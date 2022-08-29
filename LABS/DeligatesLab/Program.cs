using System;

namespace Delegates
{
    class Program
    {
        delegate void SupportEngg(string str);
        static void Main()
        {
            SupportEngg obj = new SupportEngg(TeamA);
            obj += TeamB;


          
            Console.Write("enter task");
            string input = Console.ReadLine();

            
            obj(input);

        }

        private static void TeamB(string str)
        {
            Console.WriteLine($"team b is working on {str}");
        }

        private static void TeamA(string str)
        {
            Console.WriteLine($"team a is working on {str}");
        }
    }
}

      

