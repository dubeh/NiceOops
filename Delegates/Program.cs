using System;

namespace Delegates
{
    class Program
    {
        delegate void Compute(int n1,int n2);
        delegate void Manager(string[] tasks);
        static void Main()
        {
            //simplDelegate();


            //initiation
            Manager MgHarshvardhan = new Manager(DevParth);
            MgHarshvardhan += TesterJanani;
            MgHarshvardhan += DepParikshit;

            //invocation
            Console.Write("Requesting Clients to add tasks ',' seperated");
            var input = Console.ReadLine();

            //delegate tasks to team
            MgHarshvardhan(input.Split(','));

        }

        private static void DepParikshit(string[] tasks)
        {
            string iscomp = "completed";
            foreach (var item in tasks)
            {
                Console.WriteLine($"deployment of {item}- {iscomp}");
                if (iscomp == "completed")
                {
                    iscomp = "inprogress";
                }

            }
        }

        private static void TesterJanani(string[] tasks)
        {
            string iscomp = "completed";
            foreach (var item in tasks)
            {
                Console.WriteLine($"testing of {item}- {iscomp}");
                if (iscomp =="completed")
                {
                    iscomp = "inprogress";
                }

            }
        }

        private static void DevParth(string[] tasks)
        {
            string iscomp = "completed";
            foreach (var item in tasks)
            {
                Console.WriteLine($"devlopment of {item}- {iscomp}");
                if (iscomp == "completed")
                {
                    iscomp = "inprogress";
                }

            }
        }

        private static void simplDelegate()
        {
            //Instanciation
            Compute calculator = new Compute(Add);
            calculator += Sub;
            calculator += Mul;
            calculator += Div;
            calculator(100, 200);
        }

        private static void Add(int n1, int n2)
        {
            Console.WriteLine($"Sum ={ n1 + n2}");
        }
        private static void Sub(int n1, int n2)
        {
            Console.WriteLine($"Sub ={n1 - n2}");
        }
        private static void Mul(int n1, int n2)
        {
            Console.WriteLine($"Mul ={n1 * n2}");
        }
        private static void Div(int n1, int n2)
        {
            Console.WriteLine($"Div ={n1 / n2}");
        }
    }
}