using System;
using System.Collections.Generic;
int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
string[] nomes = { "Vito", "yurisan", "fafs", "Ney" };
double[] decimais = { 1.1, 2.2, 3.3, 4.4, 5.5 };
//inteiros
Teste.ReverteArray(numeros);

//strings
Teste.ReverteArray(nomes);

//decimais
Teste.ReverteArray(decimais);

Console.ReadKey();
class Teste
{
    public static void ReverteArray<T>(T[] array)
    {
        Array.Reverse(array);
        foreach (var item in array)
        {
            Console.Write(item + " -> ");
        }
        Console.WriteLine("\n");
    }
}