using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbe:");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int number))
        {
            Console.WriteLine("Błąd: niepoprawna liczba");
            return;
        }

        Console.WriteLine($"Podana liczba: {number}");

        int[] numbers = { number, 10, 20 };
        double avg = CalculateAverage(numbers);
        Console.WriteLine($"Średnia: {avg}");
    }

    static double CalculateAverage(int[] values)
    {
        if (values.Length == 0) return 0;
        return values.Average();
    }
}