using System;

class Overload
{
    public int LilleLommeregner(int a, int b)
    {
        int summen = a + b;
        return summen;
    }

    public int LilleLommeregner(int a, int b, int c)
    {
        int summen = a + b + c;
        return summen;
    }

    public static void Main(string[] args)
    {
        Overload lommeregner = new Overload();

        int f�rsteSum = lommeregner.LilleLommeregner(1, 10000000);
        Console.WriteLine("Summen af de to f�rste v�rdier: " + f�rsteSum);

        int andenSum = lommeregner.LilleLommeregner(2, 20000000);
        Console.WriteLine("Summen af de to sidste v�rdier: " + andenSum);
    }
}