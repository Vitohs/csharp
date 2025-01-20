using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao;

internal class Homem : Animal
{
    private readonly Andar _andar;
    public Homem()
    {
        _andar = new Andar();
    }
    public void Andar()
    {
        _andar.Andando();
    }
}
