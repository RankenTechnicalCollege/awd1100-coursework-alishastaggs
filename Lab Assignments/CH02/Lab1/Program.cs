// See https://aka.ms/new-console-template for more information

//USER iNPUT
Console.WriteLine("How many miles would you like to convert to kilometers");

double miles = Convert.ToInt32(Console.ReadLine());

double kilometers = miles * 1.6;

//and then display it back to them
Console.WriteLine("{0} miles is equal to {1} kilometers", miles, kilometers);