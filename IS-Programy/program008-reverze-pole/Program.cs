string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("************** Reverze pole ****************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************ Martin Hruška *****************");
    Console.WriteLine("************** 27.11.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    Console.Write("Zadejte počet generovaných čísel (kladné celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
    {
        Console.Write("Nezadali jste celé číslo. Zadejte ho znovu: ");
    }
    Console.Write("Zadejte dolní mez generovaných čísel (celé číslo): ");
    int lowerBound;
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte ho znovu: ");
    }
    Console.Write("Zadejte horní mez generovaných čísel (celé číslo): ");
    int upperBound;
    while (!int.TryParse(Console.ReadLine(), out upperBound) || upperBound <= lowerBound)
    {
        Console.Write("Nezadali jste celé číslo nebo je horní mez menší než dolní. Zadejte ho znovu: ");
    }
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("Počet čísel: {0}, Dolní mez: {1}, Horní mez: {2}", n, lowerBound, upperBound);
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("Generovaná čísla:");
    Random random = new Random();
    int[] randomNumber = new int[n];
    for (int i = 0; i < n; i++)
    {
        randomNumber[i] = random.Next(lowerBound, upperBound + 1);
        Console.Write($"{randomNumber[i]}, ");
    }
    // Otočení pole předchozího generování
    Console.WriteLine();
    Console.WriteLine("Otočené pořadí vygenerovaných čísel:");
    int reverseNumber = Array.Reverse(reverseNumber);
    for (int i = 0; i < reverseNumber.Length; i++)
    {
        Console.Write($"{reverseNumber[i]}, ");
    }
    Console.WriteLine();
    
    Console.WriteLine();
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}