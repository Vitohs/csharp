using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCinco;

public class Produtos
{
    public string? Nome { get; set; }
    public decimal Preco { get; set; }
    public static void Carrinho(List<Produtos> lista)
    {
        foreach (var produtos in lista)
        {
            Console.WriteLine($"Nome: {produtos.Nome} - Preço: R${produtos.Preco}");
        }
        var soma = lista.Sum(x => x.Preco);
        var media = Math.Round(lista.Average(x => x.Preco), 2);
        Console.WriteLine($"Preço total do carrinho: R${soma}, valor médio: R${media}, produtos totais: {lista.Count}");
    }
}
