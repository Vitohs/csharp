using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5;

internal class SQLserver : DataBase
{
    public SQLserver()
    {
        base.Connect();
    }
    public override void Config()
    {
        Console.WriteLine("Configurando o SQL Server...");
    }
}
