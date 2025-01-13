using System.Collections.Generic;
using System;
Console.WriteLine("Digite a quantidade do Array");
var x = Convert.ToInt32(Console.ReadLine());
int[] numeros = new int[x];
for (int i = 0; i < x; i++)
{
    Console.WriteLine("Digite o valor");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
}
for (int i = 0; i < x; i++)
{
    Console.WriteLine("Digite um numero ai.");
    var y = Convert.ToInt32(Console.ReadLine());
    if (numeros.Contains(y))
    {
        Console.WriteLine($"O numero {y} esta no array");
    }
    else
    {
        Console.WriteLine("Nao achei");
    }
    if (i == x - 1)
    {
        Console.WriteLine("FIM");
    }
}
Console.ReadKey();