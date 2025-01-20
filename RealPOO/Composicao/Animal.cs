using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao;

internal class Animal
{
    public int Idade { get; set; }
    public void Comer()
    {
        Console.WriteLine("O animal está comendo");
    }
    public void Dormir()
    {
        Console.WriteLine("O animal está dormindo");
    }
}
