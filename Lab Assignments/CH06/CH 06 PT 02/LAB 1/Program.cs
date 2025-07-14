//THOUGHT ASSINGMENT SAID CONSOLE PLZ IGNORE THIS FIRST LAB 1

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter a number");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter a number");
        int num3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter a number");
        int num4 = Convert.ToInt32(Console.ReadLine());

        Reverse4(ref num1, ref num2, ref num3, ref num4);

        Console.WriteLine($"{num1}, {num2}, {num3}, {num4}");
    }

    public static void Reverse4(ref int num1, ref int num2, ref int num3, ref int num4)
    {
        int temp1 = num1;
        int temp2 = num2;
        int temp3 = num3;
        int temp4 = num4;

        num1 = temp4;
        num2 = temp3;
        num3 = temp2;
        num4 = temp1;
    }
}