using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ReadyOnly_Exercicio;
var exo = new ReadOnlyCollection<ExoPlaneta>(ExoPlaneta.GetExoPlanetas());

foreach (var planeta in exo)
{
    Console.WriteLine(planeta.Nome);
}