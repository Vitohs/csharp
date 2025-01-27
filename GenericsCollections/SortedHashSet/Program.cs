using System;
using System.Collections.Generic;
var numros = new SortedSet<int>() { 3, 1, 2, 4, 5 };
var fruta = new SortedSet<string>() { "Guarana","banana", "maça", "Amora", "uva", "pera" };
exibir(numros);
exibir(fruta);
Console.ReadKey();
static void exibir<T>(IEnumerable<T> colecao)
{
    foreach (var item in colecao)
    {
        Console.WriteLine(item + " ");
    }
}