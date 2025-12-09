// Challenge: The Triangle farmer

using System.Globalization;

Console.Write("Enter Triangle base: ");
string? baseTriangle = Console.ReadLine();
float baseTriangleFloat = float.Parse(baseTriangle!, CultureInfo.InvariantCulture);
Console.Write("Enter Triangle height: ");
string? heightTriangle = Console.ReadLine();
float heightTriangleFloat = float.Parse(heightTriangle!, CultureInfo.InvariantCulture);
float result = (baseTriangleFloat * heightTriangleFloat) / 2f;

Console.WriteLine("The result is : " + result);
