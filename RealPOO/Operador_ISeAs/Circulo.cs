using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operador_ISeAs;

internal class Circulo : Forma
{
    public Circulo() { }
    public Circulo(int xpos, int ypos) : base(xpos, ypos) { }
    public override void Desenhar()
    {
        Console.WriteLine($"Desenhar Circulo na posição: ({xpos} , {ypos})");
    }
    public void PintarCirculo()
    {
        Console.WriteLine("Pintar Circulo");
    }
}
