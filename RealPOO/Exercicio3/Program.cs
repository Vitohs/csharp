using System;
using System.Collections.Generic;
using Exercicio3;
Pessoa[] pessoa = new Pessoa[3];
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Digite o nome da pessoa:");
    if (i % 2 == 0)
    {
        pessoa[i] = new Aluno(Console.ReadLine());
    }
    else
    {
        pessoa[i] = new Professor(Console.ReadLine());
    }
    Console.Clear();
}
for (int j = 0; j < 3; j++)
{
    if (j % 2 == 0)
    {
        ((Aluno)pessoa[j]).Estudar();
    }
    else
    {
        ((Professor)pessoa[j]).Ensinar();
    }
}
Console.ReadKey();