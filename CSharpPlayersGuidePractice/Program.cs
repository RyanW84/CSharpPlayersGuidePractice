// Challenge: The Prototype

Console.Title = "Discounted Inventory";
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Clear(); // Ensures clean display with new colors

Console.WriteLine("=== The Prototype ===\n\n");

bool continueGame = True;

Console.WriteLine("Pilot enter your number (0-100)");
int pilot = Int32.Parse(Console.ReadLine() ?? string.Empty);
Console.Clear();

Console.WriteLine("Hunter enter your guess (0-100)");
int guess = Int32.Parse(Console.ReadLine() ?? string.Empty);

while (continueGame)
{
    if (guess < pilot)
    {
        Console.WriteLine("Too low");
    }
    else if (guess > pilot)
    {
        Console.WriteLine("Too high");
    }
    else if (guess == pilot)
    {
        continueGame = false;
        Console.WriteLine("You Win!");
        break;
    }

    Console.WriteLine("Try again Hunter");    
    guess = Int32.Parse(Console.ReadLine() ?? string.Empty);
}

