using System;
using System.Collections.Generic;
using Polimorfismo;
//polimorfismo em tempo de execução
var figura = new List<Figura>
{
    new Triangulo(),
    new Circulo()
};

foreach (var fig in figura)
{
    fig.Desenhar();
}
Console.ReadKey();