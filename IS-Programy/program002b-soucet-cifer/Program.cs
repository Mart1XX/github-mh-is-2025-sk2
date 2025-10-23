using System;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("********** Součet a součin cifer ***********");
    Console.WriteLine("********************************************");
    Console.WriteLine("************ Martin Hruška *****************");
    Console.WriteLine("************** 2.10.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Čteme vstup jako text, aby program zvládl i velmi velká čísla a zachoval případné nuly
    Console.Write("Zadejte číslo (může být kladné nebo záporné): ");
    string? input = Console.ReadLine();
    if (input is null) input = string.Empty;

    while (true)
    {
        input = input.Trim();
        if (string.IsNullOrEmpty(input))
        {
            Console.Write("Nezadali jste číslo. Zadejte číslo znovu: ");
            input = Console.ReadLine() ?? string.Empty;
            continue;
        }

        // Odstraňte znaménko, mezery a validujte zbylé znaky
        string s = input;
        if (s.StartsWith("+") || s.StartsWith("-"))
            s = s.Substring(1);
        s = s.Replace(" ", "");

        bool allDigits = true;
        foreach (char c in s)
        {
            if (!char.IsDigit(c))
            {
                allDigits = false;
                break;
            }
        }

        if (!allDigits || s.Length == 0)
        {
            Console.Write("Zadali jste neplatný vstup (povoleny pouze číslice). Zadejte číslo znovu: ");
            input = Console.ReadLine() ?? string.Empty;
            continue;
        }

        // Spočítáme součet cifer
        int sum = 0;
        foreach (char c in s)
            sum += c - '0';

        int digitCount = s.Length;

        Console.WriteLine();
        Console.WriteLine($"Součet cifer čísla {input} je: {sum}");
        Console.WriteLine($"Počet cifer: {digitCount}");

        // Spočítáme součin cifer (používáme long pro nižší riziko přetečení)
        long product = 1;
        foreach (char c in s)
            product *= (c - '0');

        Console.WriteLine($"Součin cifer čísla {input} je: {product}");

        break;
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine() ?? string.Empty;

}