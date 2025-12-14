// The Defence of Consolas

// It's my birthday and I will commit and push if I want to!

using static System.Console;

BackgroundColor = ConsoleColor.Black;
ForegroundColor = ConsoleColor.Yellow;
Title = " The Defence of Consolas";

WriteLine("Enter the target row");
int targetRow = int.Parse((ReadLine() ?? string.Empty));
WriteLine("Enter the target column");
int targetColumn = int.Parse((ReadLine() ?? string.Empty));

int topRow = targetRow;
int topColumn = targetColumn - 1;

int bottomRow = targetRow - 1;
int bottomColumn = targetColumn;

int leftRow = targetRow;
int leftColumn = targetColumn + 1;

int rightRow = targetRow+1;
int rightColumn = targetColumn;



WriteLine("The Defending coordinates are:");
WriteLine($"Top: {topRow}, {topColumn}");
WriteLine($"Bottom: {bottomRow}, {bottomColumn}");
WriteLine($"Left: {leftRow}, {leftColumn}");
WriteLine($"Right: {rightRow}, {rightColumn}");

WriteLine("Beep");
try
{
    Beep(264, 125);
}
catch (PlatformNotSupportedException exception)
{
    Console.WriteLine($"Platform not supported: {exception.Message}");
}