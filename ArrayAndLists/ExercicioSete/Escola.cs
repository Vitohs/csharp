using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioSete;

public class Escola
{
    string?[] alunos = new string?[5];
    public string this[int i]
    {
        get
        {
            if (i >= 0 && i < alunos.Length)
            {
                return alunos[i];
            }
            else
            {
                return "ERRO";
            }
        }
        set
        {
            if (i >= 0 && i < alunos.Length)
            {
                alunos[i] = value;
            }
            else
            {
                Console.WriteLine("ERRO");
            }
        }
    }
}
