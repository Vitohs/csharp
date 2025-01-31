using System;
using System.Collections.Generic;
//using ExercicioTres;
string[] fotos = { "Vito", "yurisan", "fafs", "Ney" };
var impressao = new Queue<string>(fotos);

while(impressao.Count > 0)
{
    var x = impressao.Peek();
    Console.WriteLine($"Estamos processando a foto do {x}");
    Thread.Sleep(5000);
    impressao.Dequeue();
    Console.WriteLine("Foto impressa\n");
}
if(impressao.Count == 0)
    Console.WriteLine("Obrigado pela preferencia");


Console.ReadKey();

static void Exibir<T>(IEnumerable<T> x)
{
    foreach (var item in x)
    {
        Console.WriteLine(item);
    }
}