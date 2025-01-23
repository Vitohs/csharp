using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3;

internal class Professor : Pessoa
{
    public Professor(string nome) : base(nome)
    { }
    public void Ensinar()
    {
        Console.WriteLine($"{Nome} está ensinando.");
    }
}
