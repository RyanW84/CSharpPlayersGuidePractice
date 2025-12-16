// Watchtower
Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.Black;
Console.Title = "Watchtower";

Console.WriteLine("Enter the X coordinate:");
var x = int.Parse(Console.ReadLine() ?? string.Empty);
Console.WriteLine("Enter the Y coordinate:");
var y = int.Parse(Console.ReadLine() ?? string.Empty);

switch (x)
{
    case 0 when y == 0:
        Console.WriteLine("The Enemy is here!");
        break;
    case > 0 when y>0:
        Console.WriteLine("NE");
        break;
    case > 0 when y==0:
        Console.WriteLine("E");
        break;
    case > 0 when y <0:
        Console.WriteLine("SE");
        break;
    case 0 when y < 0:
        Console.WriteLine("S");
        break;
    case 0 when y > 0:
        Console.WriteLine("N");
        break;
    case < 0 when y < 0:
        Console.WriteLine("SW");
        break;
    case < 0 when y == 0:
        Console.WriteLine("W");
        break;
    case < 0 when y > 0:
        Console.WriteLine("NW");
        break;
}