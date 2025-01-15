using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Exercicio1;

public class ContaPoupanca : Banco
{
    private decimal juros = 0.05m;
    decimal TaxaDeJuros { 
        get { return juros; }
        set { if (value >= 0) juros = value; }
    }
    public override void Depositar(decimal valor)
    {
        Saldo += valor;
        juros = Saldo * TaxaDeJuros;
        Saldo += juros;
        Console.WriteLine($"Voce Depositou R${Saldo} reais");
    }
    public override void Sacar(decimal valor)
    {
        if (Saldo < valor)
        {
            Console.WriteLine("Saldo insuficiente");
        }
        else
        {
            Saldo -= valor;
            Console.WriteLine($"Voce sacou R${valor} reais");
        }
    }
}