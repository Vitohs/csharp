using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2;

internal class SuperLivroFotos : LivroFotos
{
    public SuperLivroFotos() : base(64) //chama o construtor da classe base, no caso LivroFotos com parametros
    {
        Console.WriteLine("Super livro de fotos gerado");
    }
}
