// The Dominion of Kings

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine("Enter the number of Provinces");
int provinces = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of Duchies");
int duchies = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of Estates");
int estates = Convert.ToInt32(Console.ReadLine());
int result = 0;
Console.WriteLine("");

provinces = provinces*=6;
Console.WriteLine($"The total Provinces score is {provinces}");
duchies = duchies*=3;
Console.WriteLine($"The total Duchies score is {duchies}");
estates = estates*=1;
Console.WriteLine($"The total Estates score is {estates}");

result = provinces+duchies+estates;

Console.WriteLine();
Console.WriteLine($"The total is {result}");