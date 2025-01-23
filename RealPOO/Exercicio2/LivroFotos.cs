using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2;

internal class LivroFotos
{
    private int _numeroPaginas;
    public void getNumeroPaginas()
    {
        Console.WriteLine($"Numero de paginas: {_numeroPaginas}");
    }
    public LivroFotos(int numeroPaginas)
    {
        _numeroPaginas = numeroPaginas;
    }
    public LivroFotos()
    {
        _numeroPaginas = 16;
    }
}
