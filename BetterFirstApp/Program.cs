using BetterFirstApp;
using System;
using OopsBL;
class Program
{
    public static void Main()
    {
        //funwithmethods();
        //newobjects();
        //switchcase();
        //square normalsquare = new square(10);                //for debugging
        //normalsquare.Area();                                 //for debugging
        // inheritance();



    }

    private static void inheritance()
    {
        //Rombhus r = new Rombhus();
        Rectangle r = new Rombhus() { Angle = 30 };
        r.length = 10;
        r.breadth = 10;
        //r.Angle = 30;
        r.Area();

        Rectangle r2 = new square(10);
        r2.Area();
    }

    private static void switchcase()
    {
        object shape = null;

        do
        {
            string input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "rectangle":
                    shape = new Rectangle(10, 5);
                    (shape as Rectangle).Area();
                    Console.WriteLine($"area of rec is: {((Rectangle)shape).Area()}");
                    break;
                case "square":
                    shape = new square(100);
                    Console.WriteLine($"area of squ is: {((square)shape).Area()}");
                    break;

                default:
                    throw new Exception("Invalid Shape");
            }

        } while (Console.ReadLine().ToLower() != "n");
    }

    private static void newobjects()
    {
        Rectangle r1 = new Rectangle();
        r1.length = 10;
        r1.breadth = 5;
        Console.WriteLine($"area = {r1.Area()}");
        Console.WriteLine($"perimeter = {r1.perimeter()}");

        Rectangle r2 = new Rectangle();
        //r2.length = 11;
        //r2.breadth = 22;
        Console.WriteLine($"area = {r2.Area()}");
        Console.WriteLine($"perimeter = {r2.perimeter()}");

        square s1 = new square(10);
        //s1.Side = 10;
        Console.WriteLine($"area = {s1.Area()}");
    }

    private static void funwithmethods()
    {
        Console.WriteLine($"sum is: {Utility.Add(100, 200)}");
        Console.WriteLine($"sub is: {Utility.Subtract(100, 200)}");
        Console.WriteLine($"mul is: {Utility.Multiply(100, 200)}");
        Console.WriteLine($"div is: {Utility.Divide(100, 200)}");
        Console.WriteLine($"inc is: {Utility.increment(100)}");
        var names = "parth,shreyas,kartikey".Split(',');
        Utility.getwordcount(names);
        Utility.create("select * from emp ", "where name = parth");
    }

}