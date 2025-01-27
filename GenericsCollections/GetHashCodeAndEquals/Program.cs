using System;
using System.Collections.Generic;
string? a = "donvito";
string? b = "donvito";

int A = 1;
int B = 1;

Console.WriteLine(a.Equals(b));
Console.WriteLine(A.Equals(B));

Pessoa p1 = new Pessoa(1, "Vito");
Pessoa p2 = new Pessoa(1, "Vito");

Console.WriteLine(p1.Equals(p2));//por mais que possuam o mesmo valor, vai ser falso pois o equals compara o tipo de referencia desses objetos (na memoria)

//gethashcode retorna um valor inteiro com base nas informacoes do objeto
//vamo pegar essa vizao do procede
Console.WriteLine(a.GetHashCode());
Console.WriteLine(b.GetHashCode());//objetos diferentes mas com o mesmo valor, vao ter o mesmo codiguin
Console.WriteLine(p1.GetHashCode());
Console.WriteLine(A.GetHashCode());//daora que os inteiros tem o hashcode de si mesmo
//parece que retona numeor do tipo ulong, que brisa
Console.ReadKey();
public class Pessoa
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public Pessoa(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }
}