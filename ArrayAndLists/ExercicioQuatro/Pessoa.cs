using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioQuatro;

public class Pessoa
{
    public string? Nome { get; set; }
    public int Idade { get; set; }

    public static void Exibir(List<Pessoa> lista)
    {
        foreach (var pessoa in lista)
        {
            Console.WriteLine($"Nome: {pessoa.Nome} Idade: {pessoa.Idade}");
        }
    }
}
