// See https://aka.ms/new-console-template for more information

// PROMPT USER
Console.WriteLine("What is your name?");
string yourName = Console.ReadLine();

Console.WriteLine("What is your street address?");
string yourAddress = Console.ReadLine();

Console.WriteLine("What city do you live in?");
string yourCity  = Console.ReadLine();

Console.WriteLine("What state do you live in?");
string yourstate = Console.ReadLine();

Console.WriteLine("What is your zip code?");
int yourZip = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("How many shirts do you want to order?");
int qtyShirts = Convert.ToInt32(Console.ReadLine());

// MATH IT OUT
double totPrice = qtyShirts * 14.99;
double salesTax = totPrice * .08;
double amtDue = totPrice +  salesTax;

// OUTPUT
Console.WriteLine("Name: {0}", yourName);
Console.WriteLine("Street Address: {0}", yourAddress);
Console.WriteLine("City: {0}", yourCity);
Console.WriteLine("State: {0}", yourstate);
Console.WriteLine("Zip Code: {0}", yourZip);
Console.WriteLine("Quantity: {0}", qtyShirts);
Console.WriteLine("Total Price: {0:C}", totPrice);
Console.WriteLine("Sales Tax: {0:C}", salesTax);
Console.WriteLine("Amount Due: {0:C}", amtDue);