// The Defence of Consolas

// It's my birthday and I will commit and push if I want to!

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Title = " The Defence of Consolas";

Console.WriteLine("Enter the target row");
int targetRow = int.Parse((Console.ReadLine()));
Console.WriteLine("Enter the target column");
int targetColumn = int.Parse((Console.ReadLine()));

int topRow = targetRow;
int topColumn = targetColumn + 1;

int bottomRow = targetRow - 1;
int bottomColumn = targetColumn;

int leftRow = targetRow;
int leftColumn = targetColumn + 1;

int rightRow = targetRow+1;
int rightColumn = targetColumn;



Console.WriteLine("The Defending coordinates are:");
Console.WriteLine($"Top: {topRow}, {topColumn}");
Console.WriteLine($"Bottom: {bottomRow}, {bottomColumn}");
Console.WriteLine($"Left: {leftRow}, {leftColumn}");
Console.WriteLine($"Right: {rightRow}, {rightColumn}");

Console.WriteLine("Beep");
Console.Beep(264, 125);


