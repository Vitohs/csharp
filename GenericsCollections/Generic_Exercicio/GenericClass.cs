using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Exercicio;

internal class GenericClass<T>
{
    T[] array = new T[3];
    int i = 0;
    public T this[int index]
    {
        get { return array[index]; }
        set { array[index] = value; }
    }
    public void Add(T oi)
    {
        if (i < 3)
        {
            array[i] = oi;
        }
        i++;
    }
}
