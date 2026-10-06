namespace Task2circle;

// The Circle class: a blueprint that holds everything about a circle.
class Circle
{
    // const = fixed value, can never be changed after this line.
    public const double PI = 3.14;

    // Returns the area of a circle: PI * radius * radius
    public static double CalculateArea(double radius)
    {
        return PI * radius * radius;
    }

    // Returns the perimeter of a circle: 2 * PI * radius
    public static double CalculatePerimeter(double radius)
    {
        return 2 * PI * radius;
    }
}

// The Program class: where the program starts running.
class Program
{
    static void Main(string[] args)
    {
        // Read the constant from the Circle class.
        Console.WriteLine($"Value of PI: {Circle.PI}");

        // Trying to change PI gives compilation error CS0131.
        // PI is a const, so it cannot be reassigned.
        // Circle.PI = 3.14159;

        double radius = 5;

        // Call the methods and save the results.
        double area = Circle.CalculateArea(radius);
        double perimeter = Circle.CalculatePerimeter(radius);

        // :F2 means "show 2 digits after the decimal point".
        Console.WriteLine($"Radius: {radius}");
        Console.WriteLine($"Area: {area:F2}");
        Console.WriteLine($"Perimeter: {perimeter:F2}");
    }
}