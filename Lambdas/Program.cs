using System;
using System.Collections.Generic;

class program
{
    delegate int compute(int x, int y);
    delegate void print(string msg);
    delegate List<string> GetData(string msg);
    static void Main()
    {
       // lambda();

       // List<string> list = new List<string>();
       // list.ForEach((s) => Console.WriteLine(s));

        Func<int,int,int> add =(x, y) => x + y;
        Action<string> Print= (msg) => { Console.WriteLine(msg); };
        Predicate<string> isvalid = (msg) => msg.Contains("@");

        //invoke
        int result =add(10, 20);
        Print(result.ToString());
        bool i = isvalid("sfgnmsdfjk@");
        Print(i.ToString());
        


    }
    private static int addd(int a, int b) => a + b;
    private static int sub(int a, int b) => a - b;

    public string Id => "my id is" + Guid.NewGuid();

    private static void lambda()
    {
        //instanciation
        /* compute calc = new compute((x, y) => x + y);
         calc += (n1, n2) => n1 - n2;
         calc += (a1, a2) => a2 * a1;
         calc += (a1, a2) => a2 / a1;

         print obj = new print((x) => Console.WriteLine(x));
         obj += (x) => Console.WriteLine($"{x}+{x}");
        obj("nsbfkjsb");*/


        GetData lis = new GetData((list) => new List<string> { "fsf", "fefs" });
        lis += (list) => new List<string> { list };
        List<string> str = lis("ghcgh");
        for (int i = 0; i < 1; i++)
        {
            Console.WriteLine(str[i]);
        }
        foreach (var item in str)
        {
            Console.WriteLine(item);
        }
    }

    private static int add(int x, int y)
    {
        return x + y;
    }
}