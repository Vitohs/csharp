using System;
using System.Collections;
Console.WriteLine("ARRAY LISTS");
//formas de criar
ArrayList lista = new(); // count 0 e capacidade 0
int[] array = { 1,2,3 };

//ArrayList lista2 = new ArrayList(); // count 0 e capacidade 0
//var lista3 = new ArrayList(); // count 0 e capacidade 0
//ArrayList lista4 = new(5);// count 0 e capacidade 5
//var lista5 = new ArrayList()
//{
//    "victor", 11, 10.00, true, 22
//}; // count 5 e capacidade 8

//formas de adicionar
lista.Add("bala no copo da gata"); // count 1 e capacidade 4 aumenta de 4 em 4 por padrao 
lista.Add(22);
lista.Add(171);
lista.Add("vetor");
//Console.WriteLine(lista[0]); //para vizualizar o valor nao é muito diferente de um array

//formas de adicionar valor na lista
//add adiciona no final da lista
// insert adiciona em uma posicao especifica parametros (posicao, valor/elemento)
lista.Insert(0, "chei, de ódio guardado, na porra do peito");
lista.AddRange(array); //adiciona uma colecao de elementos no final da lista
//insert range adiciona uma colecao de elementos em uma posicao especifica

//removendo elementos
//remove remove o primeiro elemento que encontrar
//remove at remove o elemento na posicao especifica
//remove range remove um numero definido de elemenos a partir de uma posicao (indice)

lista.Remove("vetor");
lista.RemoveAt(0);
lista.RemoveRange(0, 2); //tirar 2 elementos apartir do indice 0
//lista.Clear(); //limpa a lista

//verificar se contem um elemento
var res = lista.Contains("bala no copo da gata");
Console.WriteLine(res);
//usando o foreach
foreach (var elem in lista)
{
    Console.WriteLine(elem);
}

Console.ReadKey();