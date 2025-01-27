using System;
using System.Collections.Generic;

var Tropa = new SortedDictionary<int, string>()
{   { 2, "Donvito" },
    { 1, "Yuri-san" },
    { 3, "fafs" }
};

//validando

Console.WriteLine("Verificando se chave do elemento que eu quero existe, caso nao exista, será adicionado");
if (Tropa.ContainsKey(77))
    Console.WriteLine("chave ja existe");
else
    Console.WriteLine("Adicionado com sucesso");
    Tropa.Add(77, "Kaua_vzk");

Console.WriteLine($"Numero de pares de chave/valor que existem no bagui - {Tropa.Count}");

//acessando elemento por chave

//var valor = Tropa[2];
//Console.WriteLine(valor);

foreach (var item in Tropa)
{
    Console.WriteLine($"\nId: {item.Key} - Nome: {item.Value}.");
}

Console.ReadKey();