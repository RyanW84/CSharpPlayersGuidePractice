// The Dominion of Kings

// It's my birthday and I will commit and push if I want to!

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Title = " The Dominion of Kings";

char tryAgain = 'y';

while (tryAgain is 'y' or 'Y')
{
    Console.WriteLine("The Dominion of Kings\n");
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

Thread.Sleep(2000);
Console.Beep(264, 125);
Thread.Sleep(250);
Console.Beep(264, 125);
Thread.Sleep(125);
Console.Beep(297, 500);
Thread.Sleep(125);
Console.Beep(264, 500);
Thread.Sleep(125);
Console.Beep(352, 500);
Thread.Sleep(125);
Console.Beep(330, 1000);
Thread.Sleep(250);
Console.Beep(264, 125);
Thread.Sleep(250);
Console.Beep(264, 125);
Thread.Sleep(125);
Console.Beep(297, 500);
Thread.Sleep(125);
Console.Beep(264, 500);
Thread.Sleep(125);
Console.Beep(396, 500);
Thread.Sleep(125);
Console.Beep(352, 1000);
Thread.Sleep(250);
Console.Beep(264, 125);
Thread.Sleep(250);
Console.Beep(264, 125);
Thread.Sleep(125);
Console.Beep(2642, 500);
Thread.Sleep(125);
Console.Beep(440, 500);
Thread.Sleep(125);
Console.Beep(352, 250);
Thread.Sleep(125);
Console.Beep(352, 125);
Thread.Sleep(125);
Console.Beep(330, 500);
Thread.Sleep(125);
Console.Beep(297, 1000);
Thread.Sleep(250);
Console.Beep(466, 125);
Thread.Sleep(250);
Console.Beep(466, 125);
Thread.Sleep(125);
Console.Beep(440, 500);
Thread.Sleep(125); 
Console.Beep(352, 500);
Thread.Sleep(125);
Console.Beep(396, 500);
Thread.Sleep(125);
Console.Beep(352, 1000);

Console.WriteLine("\n\nGoodbye");