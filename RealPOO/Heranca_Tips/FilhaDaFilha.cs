using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Tips;

internal class FilhaDaFilha : Filha
{
    public void Falar()
    {
        Console.WriteLine("Filha da Filha falando...");
    }
}
