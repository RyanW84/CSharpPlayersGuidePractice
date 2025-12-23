// Challenge: The Magic Cannon

Console.Title = "Discounted Inventory";
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Clear(); // Ensures clean display with new colors

Console.WriteLine("=== The Magic Cannon ===\n\n");

for (int i=0; i<100; i++)
{
    if (i % 3 == 0 &&  i % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{i}:Electric and Fire");
    }
    else if (i % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{i}: Fire");
    }
    else if (i % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Electric");
    }
    else
    {
        Console.WriteLine("Normal");
    }
}