using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1;

internal interface iVeiculo
{
    public int Gasolina { get; set; }
    public void Dirigir();
    public bool Abastecer(int quantidade);
}
