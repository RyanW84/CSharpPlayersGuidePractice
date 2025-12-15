// Repairing the Clocktower
Console.BackgroundColor = ConsoleColor.Red;
Console.ForegroundColor = ConsoleColor.White;
Console.Title = "Repairing the Clocktower";

Console.WriteLine("Enter the hour");
int userInput = Int32.Parse(Console.ReadLine());

if (userInput % 2 == 0)
{
    Console.WriteLine("Tick");
}
else
{
    Console.WriteLine("Tock");
}