using BookBL;

Book b1 = null;
int total = 0;
Console.WriteLine("------welcome to book shop------");

do
{
    
    Console.WriteLine("Enter book name to add to cart");
    string input = Console.ReadLine();
     b1 = Book.getCategory(input);
    total = total + b1.Cost;
    b1.display();
    Console.WriteLine($"TOTAL COST ={total}");

}while(Console.ReadLine()!="n");
 