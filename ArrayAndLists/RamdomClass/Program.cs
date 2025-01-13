using System;
using System.Collections;
Console.WriteLine("CRASSE RAMDOM");
Random vasco = new();
int[] numeros = new int[6];
int[] mega = new int[6];
int i = 0;
int acertos = 0;
//byte[] array = new byte[10];
//vasco.NextBytes(array);
//foreach (var item in array)
//{
//    Console.Write(item + " ");
//}
//Console.WriteLine(vasco.Next(1, 10));
//Console.WriteLine(Math.Round(vasco.NextDouble(),2));
while (i < 6)
{
    Console.WriteLine("SORTEIO DA MEGASENA");
    Console.WriteLine("digite 6 numeros ai");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
    i++;
    Console.Clear();
}
for (int j = 0 ; j < 6 ; j++)
{
    mega[j] = vasco.Next(1, 100);
    i++;
}
for (i = 0 ; i < 6 ; i++)
{
    Console.WriteLine($"Seu numero: {numeros[i]} - Numero sorteado: {mega[i]}");
    if (numeros[i] == mega[i])
    {
        acertos++;
    }
}
if (acertos == 6)
{
    Console.WriteLine("Parabens voce ganhou");
}
else
{
    Console.WriteLine("Ela nunca te amou.");
}
Console.ReadKey();