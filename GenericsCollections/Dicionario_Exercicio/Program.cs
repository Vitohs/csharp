using System;
using System.Collections.Generic;
using Dicionario_Exercicio;
Dictionary<int, Alunos> alunos = new()
{
    { 1, new Alunos(10, "João") },
    { 2, new Alunos(9, "Maria") },
    { 3, new Alunos(8, "Augusto") }
};

//ordenando
var ordenado = alunos.OrderBy(x => x.Value.Nome);//vai gerar o dicionário ordenado pelo nome (alfabetico)

//alterando
Console.WriteLine("Deseja alterar a nota de qual aluno, digite o codigo");
var res1 = int.Parse(Console.ReadLine());
if (alunos.ContainsKey(res1))
{
    Console.WriteLine("qual nota");
    var nota1 = int.Parse(Console.ReadLine());
    alunos[res1] = new Alunos(nota1, "João");//alterando o valor da chave x
}
else
    Console.WriteLine("Não existe o aluno com essa chave ");

//removendo
Console.WriteLine("Deseja tirar alguem ?, qual codigo");
var res = int.Parse(Console.ReadLine());
if (alunos.Remove(res))
    Console.WriteLine("Aluno removido com sucesso");
else
    Console.WriteLine("Aluno não encontrado");

//adicionando
Console.WriteLine("Deseja adicionar alguem ? s/n");
var res2 = Console.ReadLine();
if(res2 == "s" || res2 == "S")
{
    Console.WriteLine("Qual o nome do meliante");
    var nome = Console.ReadLine();
    Console.WriteLine("sua nota");
    var nota = int.Parse(Console.ReadLine());
    alunos.Add(4, new Alunos(nota, nome));
    Console.WriteLine($"ALuno: {nome} Adicionado com sucesso");
}
else
    Console.WriteLine("ok, fim do programa");

//vizualiando

foreach (var aluno in alunos)
{
    Console.WriteLine($"Número: {aluno.Key} - Nome: {aluno.Value.Nome} - Nota: {aluno.Value.Notas}");
}
Console.ReadKey();