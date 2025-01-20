using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao;

internal class Macaco : Animal
{
    private readonly Andar _andar; // variavel definida como apenas leitura para nao mudar após ser instanciada pelo construtor
    public Macaco()
    {
        _andar = new Andar(); // instanciando a classe Andar
    }
    public void Andar()
    {
        _andar.Andando(); // chamando o método Andando da classe Andar
    }
}