using System;
using Heranca;
Console.WriteLine("##\tHERANÇA      ##");
Console.WriteLine("##\tAluno e Professor     ##");
Aluno aluno = new();
Professor professor = new();

aluno.Nome = "Victor";
aluno.Email = "ninjadejau@gmail.com";
aluno.View();

professor.Nome = "Jorge";
professor.Email = "algo@orkut.com";
professor.View();

Console.ReadKey();