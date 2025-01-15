using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifySealed;
//desejo selar a classe pessoa, para ninguem poder herdar dela
//sealed
//ela tambem é usada em metodos ou propriedades
public class Pessoa
{
    public string? Nome { get; set; }
    public void ExibirNome()
    {
        Console.WriteLine($"Olá meu nome é {Nome}");
    }
}
