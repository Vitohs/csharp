using System;
using System.Collections.Generic;
//formas de instanciar um HashSet
var numeros = new HashSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var fruta = new HashSet<string>() { "banana", "maça", "pera", "uva", "manga" };
List<int> lista = new List<int>() { 1, 2, 3 };
var nmr = new HashSet<int>(lista);

foreach (var item in numeros)
{
    Console.Write(item);
}

Console.ReadKey();