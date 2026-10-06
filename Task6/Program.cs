namespace Task6;

class Program
{
    static void Main(string[] args)
    {
        // ---------- List<string> ----------
        List<string> fruits = new List<string> { "Mango", "Apple", "Banana" };

        // Add a new fruit.
        fruits.Add("Orange");

        // Remove one fruit.
        fruits.Remove("Apple");

        // Print all fruits using foreach.
        Console.WriteLine("Fruits in the list:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // ---------- Dictionary<int, string> ----------
        Dictionary<int, string> fruitDict = new Dictionary<int, string>
        {
            { 1, "Mango" },
            { 2, "Apple" },
            { 3, "Banana" }
        };

        // Add a new entry.
        fruitDict.Add(4, "Orange");

        // Print all key-value pairs.
        Console.WriteLine("\nFruit dictionary:");
        foreach (KeyValuePair<int, string> pair in fruitDict)
        {
            Console.WriteLine($"ID {pair.Key}: {pair.Value}");
        }
    }
}