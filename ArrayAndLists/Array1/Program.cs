using System;
Console.WriteLine("APRESENTANDO.... ARRAY");
//sintaxes de criação de array
int[] numeros = new int[5] { 3, 0, 1, 2, 4 };
string[] nomes = { "victor", "yurisan", "fafa", "efraim", "Ace" };
var i = 0;
//percorrendo em um while
while (i < numeros.Length)
{
    if (i == 4)
    {
        Console.WriteLine($"Nome {nomes[i]}, numero preferido: {numeros[i]}.");
    }
    else
    {
        Console.WriteLine($"Nome {nomes[i]}, numero preferido: {numeros[i]},\n");
    }
    i++;
}
//percorrendo em um foreach
foreach (int nmr in numeros)
{
    Console.WriteLine(nmr);
}

//classes de array
//clear - limpa o array
//Array.Clear(numeros, 0, 5); //saida: 0, 0, 0, 0, 0

//Reverse - inverte a ordem dos elementos
//Array.Reverse(nomes); //saida: Ace, efraim, fafa, yurisan, victor

//sort - ordena os elementos
Array.Sort(numeros); //saida: 0, 1, 2, 3, 4
Array.Sort(nomes); //saida: Ace, efraim, fafa, victor, yurisan
//bynariSearch - busca um elemento dentro do array, um adendo, precisa estar em ordem o array para funcionar a busca binaria!
Console.WriteLine("localizando");
Console.WriteLine("insira um nome");
string nome = Console.ReadLine();
var indice = Array.BinarySearch(nomes, nome);
if (indice >= 0)
{
    Console.WriteLine($"achamos o {nome} no indice {indice}");
}
else
{
    Console.WriteLine("Nao encontramos");
}
Console.WriteLine(indice);
Console.ReadKey();