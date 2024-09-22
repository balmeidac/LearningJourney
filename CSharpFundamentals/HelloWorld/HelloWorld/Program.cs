// See https://aka.ms/new-console-template for more information

// Clears the console screen
Console.Clear();

// Defines the value of pi as a constant (approximate)
var pi = 3.1416;

// Prompts the user to enter the radius of the circle
Console.Write("Enter the Circle Radius (m): ");

// Reads the user's input as a string
var r = Console.ReadLine();

// Converts the string input to a double data type for numeric operations
double radius = Convert.ToDouble(r);

// Calculates the area of the circle using the formula π * radius^2
var area = pi * radius * radius;

// Displays the result, showing both the entered radius and the calculated area
Console.WriteLine($"If the radius is: {r} m. Then the Circle Area is: {area:f2} m^2");

