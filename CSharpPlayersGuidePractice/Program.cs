// Challenge: Discounted Inventory

Console.Title = "Discounted Inventory";
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Clear(); // Ensures clean display with new colors

Console.WriteLine("=== Discounted Inventory ===\n\n");

Console.WriteLine("What is your name!!!");
string? name = Console.ReadLine();

Console.WriteLine(@"The following items are available:

1 - Rope
2 - Torches
3 - Climbing Equipment
4 - Clean Water
5 - Machete
6 - Canoe
7 - Food Supplies

Which number do you want to see the price of? ");

int input = int.Parse(Console.ReadLine() ?? string.Empty);
float value;

// Switch usage
switch (input)
{
    case 1:
        value = 10;
        if (name?.ToLower() == "ryan") value /= 2;        
        Console.WriteLine($"Rope: {value} Gold");
        break;
    case 2:
        value = 15;
        if (name?.ToLower() == "ryan") value /= 2;        
        Console.WriteLine($"Torches: {value} Gold");
        break;
    case 3:
        value = 25;
        if (name?.ToLower() == "ryan") value /= 2;        
        Console.WriteLine($"Climbing Equipment: {value} Gold");
        break;
    case 4:
        value =1;
        if (name?.ToLower() == "ryan") value /= 2;        
        Console.WriteLine($"Clean Water: {value} Gold");
        break;
    case 5:
        value = 20;
        if (name?.ToLower() == "ryan") value /= 2;
        Console.WriteLine($"Machete: {value} Gold");
        break;
    case 6:
        value = 200;
        if (name?.ToLower() == "ryan") value /= 2;
        Console.WriteLine($"Canoe: {value} Gold");
        break;
    case 7:
        value = 1;
        if (name?.ToLower() == "ryan") value /= 2;
        Console.WriteLine($"Food Supplies: {value} Gold");
        break;
}