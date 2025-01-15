using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Exercicio1;
//to usando protected para que as classes filhas possam acessar os atributos
public class Banco
{
    protected int Numero { get; set; }
    private decimal Saldo_;
    protected decimal Saldo {
        get { return Saldo_; }
        set { Saldo_ = value; } 
    }
    protected string? Nome { get; set; }
    //Metodos
    public virtual void Depositar(decimal valor)
    {
        Saldo += valor;
        Console.WriteLine($"Voce Depositou R${valor} reais");
    }
    public virtual void Sacar(decimal valor)
    {
        Saldo -= valor;
        Console.WriteLine($"Voce sacou R${valor} reais");
    }
    public virtual void ExibirSaldo()
    {
        Console.WriteLine($"Seu saldo é de R${Saldo} reais");
    }
}