using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę (int):");
        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Błąd: pusty input");
            return;
        }

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Błąd: pusty input");
            return;
        }

        if (!int.TryParse(input, out int number))
        {
            Console.WriteLine("Błąd: niepoprawna liczba");
            return;
        }

        int[] numbers = { number, 10, 20 };

        double avg = CalculateAverage(numbers);
        Console.WriteLine($"Średnia: {avg}");

        int max = CalculateMax(numbers);
        Console.WriteLine($"Max: {max}");

        int min = CalculateMin(numbers);
        Console.WriteLine($"Min: {min}");
    }

    static double CalculateAverage(int[] values)
    {
        if (values.Length == 0) return 0;
        return values.Average();
    }

    static int CalculateMax(int[] values)
    {
        if (values.Length == 0) return 0;
        return values.Max();
    }

    static int CalculateMin(int[] values)
    {
        if (values.Length == 0) return 0;
        return values.Min();
    }
}