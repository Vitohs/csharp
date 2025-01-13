using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores;

public class Times
{
    //definindo limites do array
    string?[] valor = new string?[3];
    public string this[int i]
    {
        get
        {
            if (i >= 0 && i < valor.Length)
            {
                return valor[i];
            }
            else
            {
                return "Indice fora dos limites";
            }
        }
        set
        {
            if (i >= 0 && i < valor.Length)
            {
                valor[i] = value;
            }
            else
            {
                Console.WriteLine("Indice fora dos limites");
            }
        }
    }
}
