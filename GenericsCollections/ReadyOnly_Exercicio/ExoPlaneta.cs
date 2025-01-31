using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyOnly_Exercicio;

internal class ExoPlaneta
{
    public string? Nome { get; set; }
    public static List<ExoPlaneta> GetExoPlanetas()
    {
        return new List<ExoPlaneta>()
        {
            new ExoPlaneta() { Nome = "Nebulosa 68" },
            new ExoPlaneta() { Nome = "Centurion" },
            new ExoPlaneta() { Nome = "Ametista" }
        };
    }
}
