using System.Collections.Generic;
using System;

List<string> Frutas = new()
{
    "Laranja", "Maca", "Banana", "Uva", "Pera"
};

//Metodo de busca sem lambda
var item = Frutas.Find(MandaBusca);
Console.WriteLine($"Find com predicato => {item}");

//metodo de busca com lambda
var fruta = Frutas.Find(f => f.Contains("U"));
Console.WriteLine($"Find => {fruta}");

//metodo de findlast com lambda
var fruta2 = Frutas.FindLast(g => g.Contains("a"));
Console.WriteLine($"Findlast => {fruta2}");

//metodo de findindex com lambda
var fruta3 = Frutas.FindIndex(f => f.Contains("M"));
Console.WriteLine($"FindIndex => {fruta3} item = {Frutas[fruta3]}");

//metodo de findlastindex com lambda
var fruta4 = Frutas.FindLastIndex(f => f.Contains("a"));
Console.WriteLine($"FindLastIndex => {fruta4} item = {Frutas[fruta4]}");

//metodo de findall com lambda
var frutas1 = Frutas.FindAll(f => f.Contains("a"));
foreach (var item1 in frutas1)
{
    Console.WriteLine($"FindAll => {item1}");
}

Console.ReadKey();
static bool MandaBusca(string item)
{
    return item.Contains("e");
}