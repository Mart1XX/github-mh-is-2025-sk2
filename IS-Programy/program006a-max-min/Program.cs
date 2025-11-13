string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*** Generátor a vypsání maxima a minima ****");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************ Martin Hruška *****************");
    Console.WriteLine("************** 13.11.2025 ******************");
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
    int max = 0;
    int min = 0;
    int maxpos = 0;
    int minpos = 0;
    // Generování čisel a hledání maxima a minima a jejich pozic
    Random random = new Random();
    for (int i = 0; i < n; i++)
    {
        int randomNumber = random.Next(lowerBound, upperBound + 1);
        Console.Write($"{randomNumber}, ");
        if (i == 0)
        {
            max = randomNumber;
            min = randomNumber;
            maxpos = 1;
            minpos = 1;
        }
        else
        {
            if (randomNumber > max)
            {
                max = randomNumber;
                maxpos = i + 1;
            }
            if (randomNumber < min)
            {
                min = randomNumber;
                minpos = i + 1;
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("Maximum: {0}", max);
    Console.WriteLine("Pozice maxima: {0}", maxpos);
    Console.WriteLine("Minimum: {0}", min);
    Console.WriteLine("Pozice minima: {0}", minpos);
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    // Vykreslení obrazce (přesýpací hodiny) podle hodnoty maxima
    Console.WriteLine("Obrazec podle hodnoty maxima a minima:");
    if (max <= 2)
    {
        Console.WriteLine("Hodnota maxima je menší než 2 a není možné vykreslit obrazec.");
    }
    else if (max > 40)
    {
        Console.WriteLine("Hodnota maxima je příliš velká (větší než 40) a není možné vykreslit obrazec.");
    }
    else if (max % 2 != 0)
    {
        for (int i = max; i >= 1; i = i - 2)
        {
            for (int s = 0; s < (max - i) / 2; s++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(new string('*', i));
        }
        for (int i = 1; i <= max; i = i + 2)
        {
            for (int s = (max - i) / 2; s > 0; s--)
            {
                Console.Write(" ");
            }
            Console.WriteLine(new string('*', i));
        }
    }
    else
    {
        for (int i = max; i >= 2; i = i - 2)
        {
            for (int s = 0; s < (max - i) / 2; s++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(new string('*', i));
        }
        for (int i = 2; i <= max; i = i + 2)
        {
            for (int s = (max - i) / 2; s > 0; s--)
            {
                Console.Write(" ");
            }
            Console.WriteLine(new string('*', i));
        }
    }
    Console.WriteLine("============================================");
    Console.WriteLine("============================================");
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}