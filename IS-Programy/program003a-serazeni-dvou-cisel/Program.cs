string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Seřazení dvou čísel ************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************ Martin Hruška *****************");
    Console.WriteLine("************** 23.10.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    Console.Write("Zadejte celé číslo A: ");
    int a;
    while (!int.TryParse(Console.ReadLine(), out a))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo A znovu: ");
    }

    Console.Write("Zadejte celé číslo B: ");
    int b;
    while (!int.TryParse(Console.ReadLine(), out b))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo B znovu: ");
    }
    // Chci seřadit čísla a a b vzestupně
    Console.WriteLine();
    int temp;
    if (a < b)
    {
        temp = a;
        a = b;
        b = temp;
        Console.WriteLine("********************************");
        Console.WriteLine($"Čísla seřazená vzestupně: {a}, {b}");
        Console.WriteLine("********************************");
    }
    else
    {
        Console.WriteLine("********************************");
        Console.WriteLine($"Čísla seřazená vzestupně: {a}, {b}");
        Console.WriteLine("********************************");
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}