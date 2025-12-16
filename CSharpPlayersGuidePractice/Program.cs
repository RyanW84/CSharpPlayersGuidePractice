// Watchtower - Refactored Version

Console.Title = "Watchtower";
Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.Black;
Console.Clear(); // Ensures clean display with new colors

Console.WriteLine("=== WATCHTOWER ===");
Console.WriteLine("Enter the coordinates to detect enemy position.\n");

int x = ReadInteger("Enter the X coordinate: ");
int y = ReadInteger("Enter the Y coordinate: ");

string direction = GetDirection(x, y);
Console.WriteLine($"\nThe enemy is: {direction}!");

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();

// Helper method to safely read integer input0
static int ReadInteger(string prompt)
{
    int value;
    while (true)
    {
        Console.Write(prompt);
        if (int.TryParse(Console.ReadLine(), out value))
        {
            return value;
        }
        Console.WriteLine("Invalid input. Please enter a valid integer.");
    }
}

// Determine direction based on coordinates
static string GetDirection(int x, int y)
{
    if (x == 0 && y == 0)
        return "Here"; // Special case: origin

    // Handle cardinal directions first (on axes)
    if (x == 0) return y > 0 ? "N" : "S";
    if (y == 0) return x > 0 ? "E" : "W";

    // Quadrants
    if (x > 0 && y > 0) return "NE";
    if (x > 0 && y < 0) return "SE";
    if (x < 0 && y < 0) return "SW";
    if (x < 0 && y > 0) return "NW";

    return "unknown"; // Fallback (should never reach here)
}