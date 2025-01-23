using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1;

internal class Carro : iVeiculo
{
    public int Gasolina { get; set; }
    public Carro(int gasolina)
    {
        this.Gasolina = gasolina;
    }
    public void Dirigir()
    {
        if (this.Gasolina > 0)
        {
            Console.WriteLine("Dirigindo...");
            this.Gasolina -= 1;
        }
        else
        {
            Console.WriteLine("Sem gasolina");
        }
    }
    public bool Abastecer(int quantidade)
    {
       if (quantidade <= 0)
        {
            Console.WriteLine("Adicionou nada tio");
            return false;
        }
        else
        {
            Console.WriteLine("Adicionou gasolina");
            this.Gasolina += quantidade;
            return true;
        }
    }
}
