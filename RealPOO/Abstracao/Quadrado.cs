using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao;

internal class Quadrado : Forma
{
    public double Lado { get; set; }

    public override void CalcularArea()
    {
        this.Area = Lado * Lado;
        Console.WriteLine($"Area do quadrado : {Area}");
    }
    public override void CalcularPerimetro()
    {
        this.Perimetro = 4 * Lado;
        Console.WriteLine($"Perimetro: {Perimetro}");
    }
}
