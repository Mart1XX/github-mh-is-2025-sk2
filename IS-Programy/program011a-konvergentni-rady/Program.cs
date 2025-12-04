
string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*******  Výpočet konvergentní řady *********");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************ Martin Hruška *****************");
    Console.WriteLine("*************** 4.12.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();
    Console.Write("Zadejte přesnost výpočtu v desetinném čísle (ve tvaru: 0.000001): ");
    double presnost;
    while (!double.TryParse(Console.ReadLine(), out presnost))
    {
        Console.Write("Nezadali jste desetinné číslo. Zadejte desetinné číslo přesnosti znovu: ");
    }
    double i = 1;
    double piCtvrt = 1; // první člen je 1
    double pi;
    double znamenko = 1; // začínáme s +
    while (1/i >= presnost)
    {
        i += 2;
        znamenko = -znamenko; // přepínáme znaménko
        piCtvrt += znamenko * (1 / i);
    }
    pi = piCtvrt * 4;
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("Hodnota π vypočtená s přesností {0}) je {1}", presnost, pi);
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}