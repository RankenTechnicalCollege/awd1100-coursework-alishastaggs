// See https://aka.ms/new-console-template for more information

    string danielle = "d";
    string edward = "e";
    string francis = "f";
    string result = "z";
    decimal dSum = 0;
    decimal eSum = 0;
    decimal fSum = 0;
    decimal sale = 0;

    Console.WriteLine("Who made the sale?");
    string i = Console.ReadLine();

    while (i != result)
    {
    while (i != danielle && i != edward && i != francis)
    {
        Console.WriteLine("invalid initial");
        Console.WriteLine("Who made the sale?");
        i = Console.ReadLine().ToLower();
        if (i == result)
            break;
    }

    if (i == result)
        break ;

        Console.WriteLine("How much was the sale?");
        sale = Convert.ToInt32(Console.ReadLine());

        if (i == danielle)
        {
            dSum = dSum + sale;
        }
        if (i == edward)
        {
            eSum = eSum + sale;
        }
        if (i == francis)
        {
            fSum = fSum + sale;
        }
        Console.WriteLine("Who made the sale?");
        i = Console.ReadLine().ToLower();
    }

        Console.WriteLine($"Danielle sales: {dSum:C}");
        Console.WriteLine($"Edward sales: {eSum:C}");
        Console.WriteLine($"Francis sales: {fSum:C}");