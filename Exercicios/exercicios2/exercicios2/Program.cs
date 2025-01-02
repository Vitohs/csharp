//Contexto: 1 - Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato : 
//Aluno<nome> tem<idade> anos e nota<nota> usando a concatenação e a interpolação de strings.
using Microsoft.Win32;

string nome = "Paulo";
int idade = 17;
decimal nota = 7.5m;
Console.WriteLine($"eai meu nome é {nome}, tenho {idade} anos, e minha nota é {nota}.");
Console.WriteLine("");

Console.WriteLine("Parte 2 here \n");
//Contexto: 2 - Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de 
//escapes
//To usando concatenaçao, mas n gosto muito
Console.WriteLine("meu nome é " + nome + "\n");
//Nao aguentei
Console.WriteLine($"Tenho {idade} anos de idade \n ");
Console.WriteLine($"minha nota foi {nota} na prova \n");


Console.ReadKey();
