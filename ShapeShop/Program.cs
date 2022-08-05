//Customer inputs name of shape
using OopsBL;

Console.WriteLine("-----Welcome to the Shape Shop-----");
Console.WriteLine("Enter shape you wish to purchase: ");
string CustomerInput = Console.ReadLine();
Console.WriteLine($"enter additional specefications seperated by a ','");
//a function will call the vendor that is oopsbl i.e. shape object
Shape shape = Shape.GetShapeObject(CustomerInput);
//vendor calls .Draw
shape.Draw(Console.ReadLine());