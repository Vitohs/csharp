using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExercicio;

internal class Pedido
{
    public int Numero { get; set; }
    public double Valor { get; set; }

    public Pedido(int numero, double valor)
    {
        Numero = numero;
        Valor = valor;
    }
    public Pedido(){}
}
