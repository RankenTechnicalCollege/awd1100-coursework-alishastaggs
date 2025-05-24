// See https://aka.ms/new-console-template for more information

//USER INPUT
Console.WriteLine("How many days is the car going to be rented?");
int days = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many miles was put on the car?");
int miles = Convert.ToInt32(Console.ReadLine());

//MATH IT OUT
int totalDay = days * 100;
double totalMiles = miles * 0.50;
double finalTotal = totalDay + totalMiles;

//RESSULT
Console.WriteLine("Total amount due {0:c}",finalTotal);