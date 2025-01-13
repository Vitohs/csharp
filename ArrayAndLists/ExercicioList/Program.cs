using System.Collections.Generic;
using System;
using ExercicioList;
List<Aluno> alunos = new();

alunos.Add(new Aluno("Maria", 8.75));
alunos.Add(new Aluno("Manoel", 6.95));
alunos.Add(new Aluno("Amanda", 7.25));
alunos.Add(new Aluno("Carlos", 6.55));
alunos.Add(new Aluno("Debora", 5.95));
alunos.Add(new Aluno("Alicia", 9.25));
alunos.Add(new Aluno("Sandra", 5.55));
alunos.Add(new Aluno("Marta", 7.85));
alunos.Add(new Aluno("Sueli", 9.15));
alunos.Add(new Aluno("Bia", 7.75));
alunos.Add(new Aluno("Mario", 8.95));
 
alunos.Remove(alunos.Find(a => a.Nome == "Amanda"));
var listaOrdenada = alunos.OrderBy(a => a.Nome).ToList();//gerando uma nova lista ordenada

Aluno.Exibir(listaOrdenada);