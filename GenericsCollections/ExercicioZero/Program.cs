using System;
using System.Collections.Generic;

Matematico<int>.Soma(17, 22);

Console.ReadKey();
class Matematico<T> where T : struct
{
    public static void Soma(T a, T b)
    {
        dynamic x = a;
        dynamic y = b;

        Console.WriteLine($"A soma de {a} + {b} é igual a : {x + y}");
    }
}