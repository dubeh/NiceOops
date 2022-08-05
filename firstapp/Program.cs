// See https://aka.ms/new-console-template for more information

 static Int32 Add(Int32 num1, Int32 num2)
{
    return num1 + num2;
}
 static Int32 Subtract(Int32 num1, Int32 num2)
{
    return num1 - num2;
}
 static Int32 Multiply(Int32 num1, Int32 num2)
{
    return num1*num2;
}
 static Int32 Divide(Int32 num1, Int32 num2)
{
    return num1/num2;
}
Console.WriteLine("Hello, World!");
Int32 num1=100;
Int32 num2=200;
Console.WriteLine(num1+num2);
//take values from user
string strnum1 =Console.ReadLine();
string strnum2 = Console.ReadLine();
num1 = Convert.ToInt32(strnum1);
num2 = Convert.ToInt32(strnum2);
Add(num1,num2);

//for subtracting
Console.WriteLine(Subtract(num1,num2));

Console.WriteLine($"enter values for multiplication");
strnum1 = Console.ReadLine();
strnum2 = Console.ReadLine();
num1 = Convert.ToInt32(strnum1);
num2 = Convert.ToInt32(strnum2);
Multiply(num1,num2);

Console.WriteLine($"enter values for division");
strnum1 = Console.ReadLine();
strnum2 = Console.ReadLine();
num1 = Convert.ToInt32(strnum1);
num2 = Convert.ToInt32(strnum2);
Divide(num1,num2);
//string interpolation - concatinate variable value to msg
Console.WriteLine($"sum of {num1},{num2} = {num1 + num2}");

static int increment(int num=0)
{
    num += 1;
    num++;
    return num;
}
increment();
increment(100);

static bool isEmpty(string? str, int? num)
{
    return string.IsNullOrEmpty(str) || num==null;
}

static string[] getnames()
{
    //string[] names = new string[3];
    //names[0] = "p";
    //names[1] = "a";
    //names[2] = "r";

    string[] names = new string[] { "p","a","r"};
    return names;
}

static int[] getage()
{
    int[] age = new int[] {1,2,3,4 };
    return age;
}

//calling array-------
Console.WriteLine(getnames());
Console.WriteLine($"printing all names");
foreach (var item in getnames())
{
    Console.WriteLine(item);
}
Console.WriteLine($"printing all age");
foreach (var item in getage())
{
    Console.WriteLine(item);

    //------------------
}
static void getwordcount(string[] strarray)
{
    Console.WriteLine($"strarray has {strarray.Length} items in it");
}

//getting word count(passing array as parameters)----------c
//1
string[] strarray = new string[] { "apple", "mangos", "banana" };
getwordcount(strarray);
//2
string secondmethod = "apple,mangos,bananas,pineapple";
string[] resultarray = secondmethod.Split(',');
getwordcount(resultarray);


static void create(params string[] strs)
{
    string sentence = string.Empty;
    foreach (var item in strs)
    {
        sentence += $"{item}";

    }
    Console.WriteLine(sentence);
}

//calling create finction------------------
create("apples", "mangos", "oranges");
create("parth", "dubey");
Console.WriteLine("enter value for name:");
string nameparam = Console.ReadLine();
create("select * from emp", nameparam);



Console.WriteLine(isEmpty(null, null));
Console.WriteLine($"is 'janani',100 empty?: {isEmpty("Janani",100)}");





