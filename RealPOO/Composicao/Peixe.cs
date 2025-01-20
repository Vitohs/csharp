using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao;

internal class Peixe : Animal
{
    private Nadar _nadar;
    public Peixe()
    {
        _nadar = new Nadar();
    }
    public void Nadar()
    {
        _nadar.Nadando();
    }
}
