using System;
using System.Collections.Generic;
using Exercicio4;
Pessoa[] pessoa = new Pessoa[3];
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Escreva o nome da pessoa " + i);
    pessoa[i] = new Pessoa(Console.ReadLine());
    Console.Clear();
}
foreach (Pessoa p in pessoa)
{
    Console.WriteLine(p.ToString());
}
Console.ReadKey();