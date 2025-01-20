using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Interface_Exercicio;

internal class SalvarXML : ArquivoBase, iSalvar
{
    public override void Nome()
    {
        Console.WriteLine("Ela, cansou de playboy quer, vir falar com nois, na hora h nois tem");
    }
    public void Salvar()
    {
        Console.WriteLine("Salvando arquivo em Xml");
    }
    public void compactar()
    {
        Console.WriteLine("Compactando arquivo");
    }
}