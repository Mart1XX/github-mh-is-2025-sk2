using System.ComponentModel;

string znovu = "a";
while (znovu == "a")
{
    Console.Clear();
    Console.WriteLine("**********************************");
    Console.WriteLine("******* Výpis číslené řady *******");
    Console.WriteLine("********* Martin  Hruška *********");
    Console.WriteLine("*********** 2.10. 2025 ***********");
    Console.WriteLine("**********************************");
    Console.WriteLine("**********************************");
    Console.WriteLine();

    // Vstup hodnoty do programu, ale špatné řešení
    //Console.WriteLine("Zadejte první číslo řady: ");

    //Vstup do programu, správné řešení
    Console.WriteLine("Zadejte první číslo řady: ");
    int prvniCislo;
    while (!int.TryParse(Console.ReadLine(), out prvniCislo))
    {
        Console.WriteLine("Neplatný vstup. Zadejte prosím celé číslo pro první číslo řady: ");
    }
    Console.WriteLine("Zadejte poslední číslo řady: ");
    int posledniCislo;
    while (!int.TryParse(Console.ReadLine(), out posledniCislo) || posledniCislo <= prvniCislo)
    {
        Console.WriteLine("Neplatný vstup. Zadejte prosím celé číslo větší než první číslo řady: ");
    }
    Console.WriteLine("Zadejte krok řady: ");
    int krok;
    while (!int.TryParse(Console.ReadLine(), out krok))
    {
        Console.WriteLine("Neplatný vstup. Zadejte prosím celé číslo pro krok řady: ");
    }
    Console.WriteLine();
    // Výpis řady
    Console.WriteLine("********************************");
    Console.WriteLine("********************************");
    Console.WriteLine("Číselná řada je:");
    for (int i = prvniCislo; i <= posledniCislo; i += krok)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine("********************************");
    Console.WriteLine("********************************");
    Console.WriteLine();
    // Opakování programu
    Console.WriteLine("Pro opakování programu stiskněte klávesu 'a' a ENTER, pro ukončení libovolnou jinou klávesu a ENTER.");
    znovu = Console.ReadLine();
    Console.Clear();
}
Console.WriteLine("Děkuji za použití programu. Pro ukončení stiskněte libovolnou klávesu.");
Console.ReadKey();