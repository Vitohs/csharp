using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregacao;

internal class Departamento
{
    public Departamento(string? Nome)
    {
        this.Nome = Nome;
        Professores = new List<Professor>();
    }
    public string? Nome { get; set; }
    private List<Professor>? Professores { get; set; }
    public void GerarProfessor(Professor professor)
    {
        Professores?.Add(professor);
    }
    public void Listar()
    {
        Console.WriteLine($"Departamento de {Nome}");
        foreach (var professor in Professores)
        {
            Console.WriteLine($"Professor: {professor.Nome} - Disciplina: {professor.Disciplina}");
        }
    }
}