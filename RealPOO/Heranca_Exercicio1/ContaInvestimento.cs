using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Exercicio1;

internal class ContaInvestimento : Banco
{
    private decimal taxaRemuneracao = 0.09m;
    public decimal TaxaRemuneracao { get; set; }
    private decimal taxaImposto = 0.01m;
    public decimal TaxaImposto { get; set; }
    public override void Depositar(decimal valor)
    {
        Saldo += valor;
        decimal remuneracao = Saldo * taxaRemuneracao;
        Saldo += remuneracao;
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
            decimal imposto = Saldo * taxaImposto;
            Console.WriteLine($"Voce sacou R${Saldo} reais");
            Saldo -= imposto;
        }
    }
}