// See https://aka.ms/new-console-template for more information

//PROMPT USER
Console.WriteLine("Enter number");
double numberOne = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter number");
double numberTwo = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter number");
double numberThree = Convert.ToDouble(Console.ReadLine());

// MATH IT OUT
double sumNumber = numberOne +  numberTwo + numberThree;
double aveNumber = sumNumber / 3;

//OUTPUT
Console.WriteLine("The average value is {0}", aveNumber);