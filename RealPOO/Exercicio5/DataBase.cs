using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5;

internal abstract class DataBase
{
    public virtual void Connect()
    {
        Console.WriteLine("Conectando ao banco...");
    }
    public abstract void Config();
}
