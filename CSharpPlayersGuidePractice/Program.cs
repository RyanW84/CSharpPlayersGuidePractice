// Challenge: Buying Inventory

Console.Title = "Buying Inventory";
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Clear(); // Ensures clean display with new colors

Console.WriteLine("=== Buying Inventory ===\n\n");

Console.WriteLine(@"The following items are available:

1 - Rope
2 - Torches
3 - Climbing Equipment
4 - Clean Water
5 - Machete
6 - Canoe
7 - Food Supplies

Which number do you want to see the price of? ");

int input = int.Parse(Console.ReadLine());

switch (input)
{
    case 1:
        Console.WriteLine("Rope: 10 Gold");
        break;
    case 2:
        Console.WriteLine("Torches: 15 Gold");
        break;
    case 3:
        Console.WriteLine("Climbing Equipment: 25 Gold");
        break;
    case 4:
        Console.WriteLine("Clean Water: 1 Gold");
        break;
    case 5:
        Console.WriteLine("Machete: 20 Gold");
        break;
    case 6:
        Console.WriteLine("Canoe: 200 Gold");
        break;
    case 7:
        Console.WriteLine("Food Supplies: 1 Gold");
        break;
}