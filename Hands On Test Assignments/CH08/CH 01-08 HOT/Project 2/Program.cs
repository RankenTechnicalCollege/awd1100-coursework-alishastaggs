// See https://aka.ms/new-console-template for more information
double price;
double subtotal = 0;
int itemCount = 0;
const double taxRate = 0.08;




while (true)
{ 
Console.WriteLine("Enter a price:");
string userInput = Console.ReadLine();

    if (double.TryParse(userInput, out price))
    {
        if (price == 0)
        {
            break;
        }
        else if (price < 0)
        {
            Console.WriteLine("Invalid price");
        }
        else
        {
            subtotal += price;
            itemCount++;
        }
    }
    else
    {
        Console.WriteLine("Invalid price");
    }
}

double tax = subtotal * taxRate;
double grandTotal = subtotal + tax;
double averagePrice = subtotal / itemCount;

Console.WriteLine($"Items Purchased: {itemCount}");
Console.WriteLine($"Average Item Price: {averagePrice:C}");
Console.WriteLine($"Subtotal: {subtotal:C}");
Console.WriteLine($"Tax: {tax:C}");
Console.WriteLine($"Total: {grandTotal:C}");