using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicionario_Exercicio;

internal class Alunos
{
    public int Notas { get; set; }
    public string? Nome { get; set; }
    public Alunos(int notas, string nome)
    {
        Notas = notas;
        Nome = nome;
    }
}
