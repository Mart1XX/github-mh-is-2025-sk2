using System.Diagnostics;
using System.Globalization;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("****** Generátor pseudonáhodnch čísel ******");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************ Martin Hruška *****************");
    Console.WriteLine("************** 23.10.2025 *******************");
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
    // deklarace pole (array)
    int[] randomNumber = new int[n];

    // příprava pro využití třídy Random
    Random randomNumb = new Random();
    //Random myRandNumb = new Random(15);

    Console.WriteLine();
    Console.WriteLine("Náhodná čísla: ");
    for (int i = 0; i < n; i++)
    {
        randomNumber[i] = randomNumb.Next(lowerBound, upperBound + 1);
        Console.Write("{0}, ", randomNumber[i]);
    }
    Stopwatch Mystopwatch = new Stopwatch();
    int compare = 0;
    int change = 0;

    Mystopwatch.Start();
    // Bubble sort - řazení bublinou čísel od největšího po nejmenší
    // tento cyklus tu je aby zajistil porovnání dvou sousedních čísel
    // musí dále zajistit, aby se zmenšoval počet porovnávaných čísel
    // pokud se prohodí nějaké číslo, tak se musí celý cyklus opakovat
    for (int pass = 1; pass < n; pass++)
    {
        // tento cyklus porovnává dvě sousední čísla
        for (int i = 0; i < n - pass; i++)
        {
            compare++;
            if (randomNumber[i] < randomNumber[i + 1])
            {
                // prohození hodnot
                int temp = randomNumber[i];
                randomNumber[i] = randomNumber[i + 1];
                randomNumber[i + 1] = temp;
                change++;
            }
        }
    }
    Mystopwatch.Stop();
    Console.WriteLine();
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("Seřazená čísla: ");
    for (int i = 0; i < n; i++)
    {
        Console.Write("{0}, ", randomNumber[i]);
    }
    Console.WriteLine();
    Console.WriteLine("Počet porovnání: {0}, Počet prohození: {1}", compare, change);
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    //Vytažení 2. největšího čísla ze seřazeného pole
    Console.WriteLine("2. největší číslo je: {0}", randomNumber[n - (n-1)]);
    Console.WriteLine("Čas běhu programu: {0} ms", Mystopwatch.ElapsedMilliseconds);
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}