using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioUm;

internal class Aluno
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public string? Sexo { get; set; }

    public Aluno(string nome, int idade, string sexo)
    {
        Nome = nome;
        Idade = idade;
        Sexo = sexo;
    }
    public Aluno()
    {}
    public static void Exibir(List<Aluno> alunos)
    {
        foreach (var aluno in alunos)
        {
            Console.WriteLine($"Nome: {aluno.Nome}, Idade: {aluno.Idade}, Sexo: {aluno.Sexo}");
        }
    }
}
