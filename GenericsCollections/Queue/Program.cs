using System;
using System.Collections.Generic;
//formas de inicializar uma lista
//primeira forma
//int[] par = new int[5] { 2, 4, 6, 8, 10 };
//var NumerosPares = new Queue<int>(par);
//segunda forma
//Queue<string> DiasDaSemana = new Queue<string>();
//DiasDaSemana.Enqueue("Segunda");
//DiasDaSemana.Enqueue("Terça");
//vislumbrou?
string[] time = { "São Paulo", "Santos", "Palmeiras", "Flamengo"};
var times = new Queue<string>(time);

Console.WriteLine($"Primeiro item da fila : {times.Peek()}");

Console.WriteLine($"Tamo com {times.Count} times no momento\n");

Console.WriteLine($"\nusando metodo dequeue para retirar o primeiro item atual da fila\n");
times.Dequeue();

exibir(times);

if (times.Contains("São Paulo"))
    Console.WriteLine("\nSão Paulo está na fila");
else
    Console.WriteLine($"\nSão Paulo não está na fila, agora temos {times.Count()} times a disposição");

//metodos e propriedades da queue
Console.ReadKey();
static void exibir<T>(IEnumerable<T> colecao)
{
    foreach (var item in colecao)
    {
        Console.WriteLine(item);
    }
}