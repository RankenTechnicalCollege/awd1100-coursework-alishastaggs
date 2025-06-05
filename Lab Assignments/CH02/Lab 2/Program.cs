// See https://aka.ms/new-console-template for more information

//USER INPUT
Console.WriteLine("Enter Test Score 1:");

int tstSco1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Test Score 2:");

int tstSco2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Test Score 3:");

int tstSco3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Test Score 4:");

int tstSco4 = Convert.ToInt32(Console.ReadLine());

int tstScoSum = tstSco1 + tstSco2 + tstSco3 + tstSco4;

float tstScoAve = (float)tstScoSum / 4;

//and then display it back to them
Console.WriteLine("The average of these four test scores is {0}", tstScoAve);