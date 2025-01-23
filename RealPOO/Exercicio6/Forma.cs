using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6;

internal abstract class Forma
{
    public double Area { get; set; }
    public double Perimetro { get; set; }
    public abstract void CalcularArea();
    public abstract void CalcularPerimetro();
}
