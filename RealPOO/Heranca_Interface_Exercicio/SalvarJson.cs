using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Interface_Exercicio;

internal class SalvarJson : ArquivoBase, iSalvar
{
    public override void Nome()
    {
        Console.WriteLine("Tem brinquedo novo na comunidade, playground dos loco, ta feita a distração dos drake");
    }
    public void Salvar()
    {
        Console.WriteLine("Salvando arquivo em JSON");
    }
    public void compactar()
    {
        Console.WriteLine("Compactando arquivo");
    }
}
