string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("********** Pravoúhlý trojúhelník ***********");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************ Martin Hruška *****************");
    Console.WriteLine("************** 5.11.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Zadat dvě odvěsny pravoúhlého trojúhelníku: A = první odvěsna (počet řádků), B = druhá odvěsna (počet sloupců)
    Console.Write("Zadejte celé kladné číslo A (první odvěsna - počet řádků): ");
    int a;
    while (!int.TryParse(Console.ReadLine(), out a) || a <= 0)
    {
        Console.Write("Neplatné. Zadejte kladné celé číslo A znovu: ");
    }

    Console.Write("Zadejte celé kladné číslo B (druhá odvěsna - počet sloupců): ");
    int b;
    while (!int.TryParse(Console.ReadLine(), out b) || b <= 0)
    {
        Console.Write("Neplatné. Zadejte kladné celé číslo B znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine("Výsledný pravoúhlý trojúhelník (pravý úhel vlevo dole):");

    // Nakreslíme pravoúhlý trojúhelník z odvěsen a a b.
    // Pro lepší proporcionalitu mezi délkami odvěsen použijeme interpolaci:
    // pro každý řádek i (1..a) spočítáme počet hvězdiček = round(i * b / a)
    // zajistíme, že poslední řádek má přesně b hvězdiček (druhá odvěsna) a každý řádek má min. 1.

    for (int row = 1; row <= a; row++)
    {
        int cols = (int)Math.Round((double)row * b / a);
        if (cols < 1) cols = 1;
    if (row == a) cols = b; // poslední řádek má přesně délku druhé odvěsny

        for (int c = 0; c < cols; c++)
            Console.Write('*');

        Console.WriteLine();
    }








    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}