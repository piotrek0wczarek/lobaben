using System.Collections.Generic;

class zadaniepiatek
{
    static void Main(string[] args)
    {
        zadanie1();
        zadanie2();
        zadanie3();
        zadanie4();
        zadanie5();
    }
    public static void zadanie1()
    {
        Console.WriteLine("Zadanie 1");
        int[] tab = new int[10];
        Random rand = new Random();
        for (int i = 0; i < tab.Length; i++)
        {
            tab[i] = rand.Next(1000, 9999);
            Console.WriteLine(tab[i]);
        }
        Console.WriteLine("Liczby podzielne przez 6 to:");
        foreach (int elem in tab)
        {
            if (elem % 6 == 0)
            {
                Console.WriteLine(elem);
            }
        }
    }
    public static void zadanie2()
    {
        Console.WriteLine();
        Console.WriteLine("Zadanie 2");
        Random rand = new Random();
        List<int> lista = new List<int>();

        for (int i = 0; i < 50; i++)
        {
            int random = rand.Next(200, 400);
            lista.Add(random);
        }
        WriteItems(lista);
        static void WriteItems(List<int> list)
        {
            foreach (int elem in list)
            {
                Console.WriteLine(elem);
            }
        }
    }
     
    static void zadanie3()
        {
        Console.WriteLine();
        Console.WriteLine("Zadanie 3");
            string plik = @"wyrazy.txt";
            string wyrazy = "McWrap\nWieśmac\nMcRoyal\nCheeseburger\nKFC\nMcDonald\nBurgerKing\njestem\ngłodny\nmyślę\nooo\njedzeniu\nDrwal\nMcZestaw\nKubełek";
            File.WriteAllText(plik, wyrazy);
        Console.WriteLine("Wyrazy zostały pomyślnie zapisane do pliku wyrazy.txt");
        }
    static void zadanie4()
    {
        Console.WriteLine();
        Console.WriteLine("Zadanie 4");
        string plik = @"wyrazy.txt";
        List<string> list = new();
        List<string> listCopy = new();
        Console.WriteLine("Wyrazy w liście to: ");
        foreach (string ln in File.ReadAllLines(plik))
        {
            list.Add(ln);
            listCopy.Add(ln);
            Console.WriteLine(ln);
        }
        foreach (string elem in listCopy)
        {
            foreach (char ok in elem)
            {
                if (ok == 'S' || ok == 's')
                {
                    list.Remove(elem);
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("Wyrazy bez litery s to: ");
        foreach (string elem in list)
        {
            Console.WriteLine(elem);
        }

    }
    static void zadanie5()
    {
        Console.WriteLine();
        Console.WriteLine("Zadanie 5");
        int ok;
        Console.WriteLine("Podaj ok");
        ok = int.Parse(Console.ReadLine());
        Console.WriteLine(rekurencja(ok));
        static int rekurencja(int ok)
        {
            if (ok == 0 || ok < 0)
                return 1;
            if (ok % 2 == 0)
            {
                return ok - 1 * rekurencja(ok - 2);
            }
            else
            {
                return ok * rekurencja(ok - 2);
            }
        }
    }
}