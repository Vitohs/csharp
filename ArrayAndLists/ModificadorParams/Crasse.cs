using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorParams;

public class Crasse
{
    public static int Somar(params int[] numeros)
    {
        int soma = 0;
        foreach (int numero in numeros)
        {
            soma += numero;
        }
        return soma;
    }
}
