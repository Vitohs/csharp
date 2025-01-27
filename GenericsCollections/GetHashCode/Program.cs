using System;
using System.Collections.Generic;
//caso eu queria comparar alguem com 2 cpf igual, iria dar false precisamos sobrescrever o metodo equals e gethashcode na class

Pessoa p1 = new Pessoa(123456789, "Vito");
Pessoa p2 = new Pessoa(123456789, "Yurisan");
Pessoa p3 = new Pessoa(1234, "Fafs");

Console.WriteLine("pessoa 1 - cpf : 123456789 - Nome: Donvito");
Console.WriteLine("pessoa 2 - cpf : 123456789 - Nome: Yurisan");
Console.WriteLine("pessoa 3 - cpf : 1234 - Nome: Fafs");

//usando gethashcode

Console.WriteLine("\ncomparando com GetHasCode");
Console.WriteLine("Pessoa1: " + p1.GetHashCode());
Console.WriteLine("Pessoa2: " + p2.GetHashCode());
Console.WriteLine("Pessoa3: " + p3.GetHashCode());

//equals

Console.WriteLine("\nComparando com equals");
Console.WriteLine("Pessoa1 equals pessoa2 = " + p1.Equals(p2));//true
Console.WriteLine("Pessoa2 equals pessoa3 = " + p2.Equals(p3));//false
Console.WriteLine("Pessoa1 equals pessoa3 = " + p1.Equals(p3));//false

Console.ReadKey();
public class Pessoa
{
    public int CPF { get; set; }
    public string? Nome { get; set; }
    public Pessoa(int CPF, string Nome)
    {
        this.CPF = CPF;
        this.Nome = Nome;
    }
    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
            return false;
        }
        if (!(obj is Pessoa))
        {
            return false;
        }
        var other = (Pessoa)obj;
        return this.CPF == other.CPF;
    }
    public override int GetHashCode()
    {
        return CPF.GetHashCode();
    }
}