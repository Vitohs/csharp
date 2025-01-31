using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
var Planetas = new List<string>()
{
    "Terra",
    "Marte",
    "Saturno",
    "Jupiter"
};
//criando a variavel de somente leitura
Planetas.Add("Netuno");
var ListaPlanetas = new ReadOnlyCollection<string>(Planetas);

Console.WriteLine("Jupiter ta na lista de planetas ?");
Console.WriteLine(ListaPlanetas.Contains("Jupiter") ? "Sim\n" : "Não\n");

foreach (var planeta in ListaPlanetas)
{
    Console.WriteLine(planeta);
}

Console.WriteLine("\nPlaneta do indice 2 : " + ListaPlanetas[2]);
Console.WriteLine("Indice do Planeta Terra : " + ListaPlanetas.IndexOf("Terra"));

Console.WriteLine("\nCopiando os elementos da readonly e jogando para um array simples");
string[] array = new string[ListaPlanetas.Count + 1];
ListaPlanetas.CopyTo(array, 0);
foreach (var planeta in array)
{
    Console.WriteLine(planeta);
}
Console.ReadKey();
