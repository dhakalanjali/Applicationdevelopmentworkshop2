namespace Task4;

class Program
{
    static void Main(string[] args)
    {
        // Create an integer array with 5 favorite numbers.
        int[] numbers = { 7, 3, 9, 1, 5 };

        // Sort the array in ascending order (smallest to largest).
        Array.Sort(numbers);

        // Reverse the sorted array (now largest to smallest).
        Array.Reverse(numbers);

        // Print each element using a for loop.
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Element at index {i}: {numbers[i]}");
        }

        // Find the position of a specific number.
        int position = Array.IndexOf(numbers, 5);
        Console.WriteLine($"The number 5 is at index {position}");
    }
}