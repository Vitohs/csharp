using System;
using System.Collections.Generic;
//inicializando
//os maiores de cada estado
var timesSP = new HashSet<string>() { "São Paulo", "Santos", "Palmeiras" };
var timesRJ = new HashSet<string>() { "Flamengo", "Vasco", "Fluminense" };
var timesMG = new HashSet<string>() { "Cruzeiro", "Atlético", "América" };
var TimesMundiais = new HashSet<string>() { "São Paulo", "Flamengo", "Santos","Vasco", "Palmeiras" };//retratação: 51 é pinga!
//operações com Hashset

//adicionando

Console.WriteLine("Adicionando um time de Sp\n");

if (timesSP.Contains("Corinthians"))
    Console.WriteLine("ja inserido");
else
    Console.WriteLine("Adicionado com sucesso");
    timesSP.Add("Corinthians");

//removendo o menor time

//var res = timesSP.Remove("Corinthians");

//Console.WriteLine($"Time removido: {res}");

//perguntando se um conjunto é subconjunto de outro

if (timesSP.IsSubsetOf(TimesMundiais))
    Console.WriteLine("Times de SP são subconjunto de times mundiais");
else
    Console.WriteLine("Times de SP não são subconjunto de times mundiais");

//perguntando se um conjunto é superconjunto de outro
if (TimesMundiais.IsSupersetOf(timesSP))
    Console.WriteLine("\nTimes mundiais são superconjunto de times de SP");
else
    Console.WriteLine("\nTimes mundiais não são superconjunto de times de SP");

//verificandp se um conjunto tem algo em comum com oto
if (timesSP.Overlaps(TimesMundiais))
    Console.WriteLine("\nNo minimo um time tem mundial, tirando o palmeiras");
else
    Console.WriteLine("\nnenhum time tem mundial");

//verificando se um conjunto possui os mesmo elementos que outro
if(timesSP.SetEquals(TimesMundiais))
    Console.WriteLine("\nTimes de SP tem os mesmos elementos que times mundiais");
else
    Console.WriteLine("\nTimes de SP não tem os mesmos elementos que times mundiais");

//Console.WriteLine("fazendo a uniao dos clubes\n");
//timesSP.UnionWith(timesRJ);
//timesSP.UnionWith(timesMG);

//pra quem nao sabe intersacao mostra o que tem em comum entre os conjuntos
//Console.WriteLine("Fazendo a intersação");
//timesSP.IntersectWith(TimesMundiais);//ele vai tirar os que nao tem nada em comum, e vai manter os que tem

//Console.WriteLine("Fazendo a diferença entre dois conjuntos");//ele vai tirar os que tem em comum!
//TimesMundiais.ExceptWith(timesSP);

//usando o simetrico, ele vai tirar os que tem em comum e vai manter os que nao tem, exemplo sp tem sp, santos e palmeiras em comum com times mundiais, entao ele vai tirar esses 3 e vai mostrar o flamengo e o vasco
//o corinthians tambem vai ser mostrado, pois ele nao tem em comum com times mundiais
timesSP.SymmetricExceptWith(TimesMundiais);

//oerdeando
var Ordenado = new SortedSet<string>(timesSP);

Exibir(timesSP);
Console.ReadKey();
static void Exibir<T>(IEnumerable<T> Colecao)
{
    foreach (var item in Colecao)
    {
        Console.WriteLine(item);
    }
}