// Watchtower
Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.Black;
Console.Title = "Watchtower";

Console.WriteLine("Enter the X coordinate:");
var x = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the Y coordinate:");
var y = int.Parse(Console.ReadLine());

if (x == 0 && y == 0)
{
    Console.WriteLine("The Enemy is here!");
}
else if( x>0 && y>0 )
{
    Console.WriteLine("NE");
}
else if (x >0 && y==0)
{
    Console.WriteLine("E");
}
else if (x>0 && y <0)
{
    Console.WriteLine("SE");
}
else if (x==0 && y < 0)
{
    Console.WriteLine("S");
}
else  if (x==0 && y > 0)
{
    Console.WriteLine("N");
}
else if (x<0 && y < 0)
{
    Console.WriteLine("SW");
}
else if (x < 0 && y == 0)
{
    Console.WriteLine("W");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("NW");
}