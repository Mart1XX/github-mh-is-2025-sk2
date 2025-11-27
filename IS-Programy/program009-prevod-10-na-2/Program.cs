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

    Console.Write("Zadejte přirozené číslo v desítkové soustavě: ");
    uint number10;
    while (!uint.TryParse(Console.ReadLine(), out number10))
    {
        Console.Write("Nezadali jste celé přirozené číslo. Zadejte ho znovu: ");
    }
    uint[] myArray = new uint[32];
    uint backupnumber10 = number10;
    uint zbytek;


    int i;
    for (i = 0; number10 > 0; i++)
    {
        zbytek = number10 % 2;
        myArray[i] = zbytek;
        number10 = (number10 - zbytek)/ 2;
    }
// Výpis čísla v binární soustavě reverzně a číslo má vždy nejméně 8 bitů (oddělené po 4 bitech)
    Console.Write("Číslo {0} v binární soustavě je: ", backupnumber10);
    for (int j = 7; j >= 0; j--)
    {
        if (j < i)
        {
            Console.Write(myArray[j]);
        }
        else
        {
            Console.Write("0");
        }
        if (j % 4 == 0) Console.Write(" ");
    }
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}