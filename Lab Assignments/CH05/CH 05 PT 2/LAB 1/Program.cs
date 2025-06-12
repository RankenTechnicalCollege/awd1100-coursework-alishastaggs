// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter test scores:");
int testScore = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int numberOfScores = 0;
int average = 0;


while (testScore != 999)
{
    if (testScore > 100 || testScore < 0)
    {
        Console.WriteLine("Please enter a number 0-100");
    }
    else
    {
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