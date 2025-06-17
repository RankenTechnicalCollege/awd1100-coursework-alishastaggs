// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter test scores:");
double testScore = Convert.ToDouble(Console.ReadLine());
double sum = 0;
double numberOfScores = 0;
double average = 0;
double lowest = int.MaxValue;
double highest = int.MinValue;


while (testScore != 999)
{
    if (testScore > 100 || testScore < 0)
    {
        Console.WriteLine("Please enter a number 0-100");
    }
    else
    {
        if (testScore < lowest)
        { 
        lowest = testScore;
        }
        if (testScore > highest)
        {
            highest = testScore;
        }

            sum = sum + testScore;
            numberOfScores++;
            average = sum / numberOfScores;
    }

    Console.WriteLine("Enter test scores:");
        testScore = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Number of scores enntered: {numberOfScores}");
Console.WriteLine($"Sum of test scores: {sum}");
Console.WriteLine($"Average test score: {average}");
Console.WriteLine($"Lowest test score: {lowest}");
Console.WriteLine($"Highest test score: {highest}");