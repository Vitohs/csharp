using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6;

internal class Circulo : Forma
{
    public double Raio { get; set; }
    public void CalcularRaio()
    {
        Console.WriteLine("Digite o raio do círculo:");
        Raio = double.Parse(Console.ReadLine());
    }
    public override void CalcularArea()
    {
        Area = Math.PI * Math.Pow(Raio, 2);
        Console.WriteLine(Area);
    }
    public override void CalcularPerimetro()
    {
        Perimetro = 2 * Math.PI * Raio;
        Console.WriteLine(Perimetro);
    }
}
