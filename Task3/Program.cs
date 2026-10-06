namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        // Part 1: Declare and initialize each data type.
        byte myByte = 200;                 // whole number, 0 to 255
        short myShort = 30000;             // whole number, small range
        int myInt = 2000000000;            // whole number, most common
        long myLong = 9000000000L;         // very large whole number (L suffix)
        float myFloat = 3.14f;             // decimal, less precise (f suffix)
        double myDouble = 3.14159265359;   // decimal, more precise
        decimal myDecimal = 99.99m;        // decimal for money (m suffix)
        char myChar = 'A';                 // one single character
        bool myBool = true;                // true or false

        // Part 2: Convert integer 42 to a string.
        int number = 42;
        string numberAsString = number.ToString();

        // Part 3: Convert string "3.14" to a double.
        string text = "3.14";
        double textAsDouble = double.Parse(text);

        // Part 4: Print everything with its type and value.
        Console.WriteLine($"byte    : {myByte.GetType().Name} = {myByte}");
        Console.WriteLine($"short   : {myShort.GetType().Name} = {myShort}");
        Console.WriteLine($"int     : {myInt.GetType().Name} = {myInt}");
        Console.WriteLine($"long    : {myLong.GetType().Name} = {myLong}");
        Console.WriteLine($"float   : {myFloat.GetType().Name} = {myFloat}");
        Console.WriteLine($"double  : {myDouble.GetType().Name} = {myDouble}");
        Console.WriteLine($"decimal : {myDecimal.GetType().Name} = {myDecimal}");
        Console.WriteLine($"char    : {myChar.GetType().Name} = {myChar}");
        Console.WriteLine($"bool    : {myBool.GetType().Name} = {myBool}");
        Console.WriteLine($"int 42 to string   : {numberAsString.GetType().Name} = {numberAsString}");
        Console.WriteLine($"string \"3.14\" to double : {textAsDouble.GetType().Name} = {textAsDouble}");
    }
}