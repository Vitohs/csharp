using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6;

internal class Quadrado : Forma
{
    public double Lado { get; set; }
    public void CalcularLado()
    {
        Console.WriteLine("Digite o lado do quadrado:");
        Lado = double.Parse(Console.ReadLine());
    }
    public override void CalcularArea()
    {
        Area = Math.Pow(Lado, 2);
        Console.WriteLine(Area);
    }
    public override void CalcularPerimetro()
    {
        Perimetro = 4 * Lado;
        Console.WriteLine(Perimetro);
    }
}
