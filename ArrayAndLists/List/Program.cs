using System;
using System.Collections.Generic;
Console.WriteLine("LIST");

//declarando a list<t>
List<string> Lista = new();
string[] array = { "Victor", "Fafas", "Yuri san" };

//forma de adicionar
Lista.AddRange(array);
//Lista.InsertRange(1, array);
Lista.Add("bala no copo da gata");
Lista.Insert(2,"Don vito");

//formas de remover
//Lista.Remove("bala no copo da gata");
//Lista.RemoveAt(0);
//Lista.RemoveRange(0, 2);//a partir da posicao 0, elimine 2 elementos

//ORDENANDO
Lista.Sort();

//LIMPANDO
//Lista.Clear();

//CONTAINS
Console.WriteLine("Digite algo ai");
var res = Console.ReadLine();
bool oi = Lista.Contains(res);

if (oi)
{
    Console.WriteLine($"Achei a palavra {res} no indice: {Lista.FindIndex(f => f.Contains(res))}");
}
else
{
    Console.WriteLine("Nao achei");
}

//interacao com for count é um length

//for (int i = 0; i < Lista.Count; i++)
//{
//    Console.WriteLine(Lista[i]);
//}
//interacao com foreach
foreach (var elem in Lista)
{
    Console.WriteLine(elem);
}

Console.ReadKey();