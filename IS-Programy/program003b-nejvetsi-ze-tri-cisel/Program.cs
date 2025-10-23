string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("********** Největší ze tří čísel ***********");
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
    Console.Write("Zadejte celé číslo C: ");
    int c;
    while (!int.TryParse(Console.ReadLine(), out c))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo C znovu: ");
    }
    Console.WriteLine();
    //Chci vybrat největší číslo z a, b, c
    if (a > b && a > c)
    {
        Console.WriteLine("********************************");
        Console.WriteLine($"Největší číslo je A: {a}");
        Console.WriteLine("********************************");
    }
    else if (b >= a && b > c)
    {
        Console.WriteLine("********************************");
        Console.WriteLine($"Největší číslo je B: {b}");
        Console.WriteLine("********************************");
    }
    else
    {
        Console.WriteLine("********************************");
        Console.WriteLine($"Největší číslo je C: {c}");
        Console.WriteLine("********************************");
    }
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}