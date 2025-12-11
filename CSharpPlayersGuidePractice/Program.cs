// The Dominion of Kings

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Title = " The Dominion of Kings";

char tryAgain = 'y';

while (tryAgain is 'y' or 'Y')
{
    Console.WriteLine("The Dominion of Kings\n\n");
    Console.WriteLine("Enter the number of Provinces");
    var provinces = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the number of Duchies");
    var duchies = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the number of Estates");
    var estates = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");

    provinces = provinces *= 6;
    Console.WriteLine($"The total Provinces score is {provinces}");
    duchies = duchies *= 3;
    Console.WriteLine($"The total Duchies score is {duchies}");
    estates = estates *= 1;
    Console.WriteLine($"The total Estates score is {estates}");

    var result = provinces + duchies + estates;

    Console.WriteLine();
    Console.WriteLine($"The total is {result}");

    tryAgain = ' ';
    
    Console.WriteLine("Press Y to try again, or any other key to exit");
    tryAgain = Console.ReadKey().KeyChar;
    Console.Clear();
    
}

Console.WriteLine("\n\nGoodbye");