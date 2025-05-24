// See https://aka.ms/new-console-template for more information

// USER INPUT
Console.WriteLine("Enter name");
string worker1 = (Console.ReadLine());

Console.WriteLine("Enter salary");
int salary1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter name");
string worker2 = (Console.ReadLine());

Console.WriteLine("Enter salary");
int salary2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter name");
string worker3 = (Console.ReadLine());

Console.WriteLine("Enter Salary");
int salary3  = Convert.ToInt32(Console.ReadLine());

// MATH IT OUT
double salary1y2 = salary1 * 0.04 + salary1;
double salary1y3 = salary1y2 * 0.04 + salary1y2;

double salary2y2 = salary2 * 0.04 + salary2;
double salary2y3 = salary2y2 * 0.04 + salary2y2;

double salary3y2 = salary3 * 0.04 + salary3;
double salary3y3 = salary3y2 * 0.04 + salary3y2;

// PUT INFO INTO TABLE
Console.WriteLine("Year {0} {1} {2}", worker1, worker2, worker3);
Console.WriteLine("2025 {0} {1} {2}", salary1, salary2, salary3);
Console.WriteLine("2026 {0} {1} {2}", salary1y2, salary2y2, salary3y2);
Console.WriteLine("2027 {0} {1} {2}", salary1y3, salary2y3, salary3y3);