using System;
using System.Collections.Generic;
//formas de iniciar uma stack (pilha)
var pilha = new Stack<int>();
pilha.Push(1);
pilha.Push(2);
pilha.Push(3);
//peek retorna o ultimo elemento da pilha
//pop remove o ultimo elemento da pilha e retorna o valor

//propriedades
contem(pilha, 22);

exibir(pilha);

Console.WriteLine($"A pilha contem - {pilha.Count} valores");

var array = pilha.ToArray();//gerando uma copia da pilha

exibir(array);

pilha.Clear();//limpa a pilha

Console.ReadKey(); 
static void exibir<T>(IEnumerable<T> colecao)
{
    foreach (var item in colecao)
    {
        Console.Write(item + " ");
    }
}
static void contem<T>(Stack<T> pilha, T valor)
{
    if (pilha.Contains(valor))
    {
        Console.WriteLine("Ja ta na stack pai");
    }
    else
    {
        Console.WriteLine("certo ja vai ser adicionado");
        pilha.Push(valor);
    }
}