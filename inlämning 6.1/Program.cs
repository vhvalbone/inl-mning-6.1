﻿using System;

class Program
{
    static void Main(string[] args)
    {
        int summa = Addera(5, 10, 15);
        Console.WriteLine("Summan är: " + summa);
    }

    static int Addera(int tal1, int tal2, int tal3)
    {
        return tal1 + tal2 + tal3;
    }
}
