using System;
using System.Collections.Generic;
using Polimorfismo2;
//polimorfismo em tempo de compilação
Calcular calcular = new Calcular();

Console.WriteLine(calcular.Somar(40, 60));
Console.WriteLine(calcular.Somar(40, 60, 70));

Console.ReadKey();