using System;

class Program
{
    static void Main()
    {
        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("********************************************");
            Console.WriteLine("************ Zobrazení obrazců *************");
            Console.WriteLine("********************************************");
            Console.WriteLine("************ Martin Hruška *****************");
            Console.WriteLine("************** 5.11.2025 *******************");
            Console.WriteLine("********************************************");
            Console.WriteLine();

            Console.WriteLine("Vyberte obrazec (zadejte číslo):");
            Console.WriteLine("1) Čtverec");
            Console.WriteLine("2) Pravý trojúhelník (pravý úhel vlevo dole)");
            Console.WriteLine("3) Kosočtverec / diamant");
            Console.Write("Volba (1-3): ");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
            {
                Console.Write("Neplatná volba. Zadejte 1, 2 nebo 3: ");
            }

            Console.Write("Zadejte velikost obrazce (kladné celé číslo): ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Neplatná velikost. Zadejte kladné celé číslo znovu: ");
            }

            Console.WriteLine();
            Console.WriteLine("Výsledek:");
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    DrawSquare(n);
                    break;
                case 2:
                    DrawRightTriangle(n);
                    break;
                case 3:
                    DrawDiamond(n);
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine() ?? string.Empty;
        }
    }

    static void DrawSquare(int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++) Console.Write('*');
            Console.WriteLine();
        }
    }

    static void DrawRightTriangle(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < i; j++) Console.Write('*');
            Console.WriteLine();
        }
    }

    static void DrawDiamond(int n)
    {
        if (n == 1)
        {
            Console.WriteLine("*");
            return;
        }

        if (n % 2 == 0) n++;
        int mid = n / 2;

        for (int i = 0; i <= mid; i++)
        {
            int stars = 2 * i + 1;
            int spaces = (n - stars) / 2;
            Console.Write(new string(' ', spaces));
            Console.Write(new string('*', stars));
            Console.WriteLine();
        }

        for (int i = mid - 1; i >= 0; i--)
        {
            int stars = 2 * i + 1;
            int spaces = (n - stars) / 2;
            Console.Write(new string(' ', spaces));
            Console.Write(new string('*', stars));
            Console.WriteLine();
        }
    }
}
