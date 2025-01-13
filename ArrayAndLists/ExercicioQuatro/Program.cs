using System;
using System.Collections.Generic;
using ExercicioQuatro;
List<Pessoa> pessoas = new();
var x = 3;
for (int i = 0; i < x; i++)
{
    Console.WriteLine("Porfavor, digite a idade Da pessoa");
    var nome = Console.ReadLine();
    Console.WriteLine($"Por favor digite a idade do {nome}");
    var idade = Convert.ToInt32(Console.ReadLine());

    pessoas.Add(new Pessoa { Nome = nome, Idade = idade });
    Console.Clear();
}
pessoas.Add(new Pessoa {Nome = "Garcia", Idade = 20 } );
pessoas.Add(new Pessoa {Nome = "Alan", Idade = 20 } );
pessoas.RemoveAt(x - 1);
Console.WriteLine("Gostaria de vizualizar a lista de nomes ?");
var res = Console.ReadLine();

if (res == "s" || res == "S")
{
    Pessoa.Exibir(pessoas);
}
else
{
    Console.WriteLine("Obrigado por usar o programa");
}
Console.ReadKey();