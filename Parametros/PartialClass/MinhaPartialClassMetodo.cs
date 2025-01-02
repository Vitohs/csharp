using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass;

public partial class MinhaPartialClass
{
    public TimeSpan CalcularIdade(DateTime DataNasc)
    {
        return (DateTime.Now.Date - DataNasc);
    }

    public TimeSpan DiferencaEntreDatas(DateTime Data1, DateTime Data2)
    {
       var diferenca = Data1.Subtract(Data2);
       return diferenca;
    }
}
