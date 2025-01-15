using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifySealed;

public class Cliente : Pessoa
{
    public string? Email { get; set; }
    public new void ExibirNome()
    {
        Console.WriteLine($"Olá meu nome é {Nome} e meu email é {Email}");
    }
}
