using System;
using System.Collections.Generic;
using ExercicioUm;
var ListaAlunos = new List<Aluno>()
{
    new Aluno("Vito", 18, "M"),
    new Aluno("Yuri san",16, "M"),
    new Aluno("Fafs", 19, "M")

};

Aluno.Exibir(ListaAlunos);

Console.ReadKey();