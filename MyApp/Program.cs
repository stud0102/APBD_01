if (!int.TryParse(input, out int number))
{
    Console.WriteLine("Błąd: niepoprawna liczba");
    return;
}

Console.WriteLine($"Podana liczba: {number}");