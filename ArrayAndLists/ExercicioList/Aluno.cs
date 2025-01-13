using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioList;
public class Aluno
{
    public string? Nome { get; set; }
    public double Nota { get; set; }
    public Aluno(string nome, double nota)
    {
        Nome = nome;
        Nota = nota;
    }
    public static void Exibir(List<Aluno> lista)
    {
        double media = 0;
        foreach (var aluno in lista)
        {
            if (aluno.Nota >= 8)
            {
                media = lista.Average(a => a.Nota);
                Console.WriteLine($"Nome: {aluno.Nome} - Nota: {aluno.Nota}");
            }
        }
        Math.Round(media, 2);
        Console.WriteLine($"Média dos alunos: {media} - quantidade de alunos: {lista.Count}");
    }
}
