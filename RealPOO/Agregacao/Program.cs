//agregacao
using System;
using System.Collections.Generic;
using Agregacao;
Professor professor = new("Victor", "Inglês");
Professor professor2 = new("YuriSan", "Português");
Departamento departamento = new("Linguística");
departamento.GerarProfessor(professor);
departamento.GerarProfessor(professor2);
departamento.Listar();
Console.ReadKey();
