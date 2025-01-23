using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6;

internal class Triangulo : Forma
{
    public double Base { get; set; }
    public double Altura { get; set; }
    public override void CalcularArea()
    {
        Area = (Base * Altura) / 2;
        Console.WriteLine(Area);
    }
    public override void CalcularPerimetro()
    {
        Perimetro = Base * 3;
        Console.WriteLine(Perimetro);
    }
}
