namespace Task2;

// A class is a blueprint. This one groups everything related to a circle.
class Circle
{
    // 'const' means this value is fixed forever and can never be changed.
    public const double PI = 3.14;

    // Calculates the area of a circle: PI * radius * radius
    public static double CalculateArea(double radius)
    {
        return PI * radius * radius;
    }

    // Calculates the perimeter (circumference): 2 * PI * radius
    public static double CalculatePerimeter(double radius)
    {
        return 2 * PI * radius;
    }
}

// Trying to change PI gives a compilation error (CS0131).
// PI is a constant (const), so its value is fixed and cannot be
// reassigned. The = operator needs a normal variable on the left side.
// C# blocks this to protect fixed values from accidental changes.
// Circle.PI = 3.14159;