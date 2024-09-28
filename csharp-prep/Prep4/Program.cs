using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int input;

        Console.WriteLine("Type numbers. Type 0 to stop.");

        do
        {
            input = int.Parse(Console.ReadLine());
            if (input != 0)
            {
                numbers.Add(input);
            }
        } while (input != 0);

        // Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine("Sum: " + sum);

        // Compute the average
        double average = (double)sum / numbers.Count;
        Console.WriteLine("Average: " + average);

        // Find the maximum
        int maximum = numbers[0];
        foreach (int number in numbers)
        {
            if (number > maximum)
            {
                maximum = number;
            }
        }
        Console.WriteLine("Maximum: " + maximum);
    }
}