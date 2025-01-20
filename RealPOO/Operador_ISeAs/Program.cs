using System;
using Operador_ISeAs;
Console.WriteLine("Operadores IS e AS");
object carroobj = new Carro();
//as é usado para fazer um cast seguro, sem precisar depender de try catch, tornando downcasting mais seguro, e um codigo 'mar' limpo né
var x = carroobj as string;
if (x != null)
{
    Console.WriteLine("boa");
}
else
{
    Console.WriteLine("deu ruim");
}

Circulo circulo = new Circulo(10, 20);
Forma forma = circulo; //upcasting

Circulo c = forma as Circulo; //downcasting com AS
if (c != null)
{
    c.PintarCirculo();
}
else
{
    Console.WriteLine("Forma não é um Circulo");
}

//operador IS
//is verifica se o objeto é do tipo especificado, se for retorna true, se não false
Console.WriteLine(c is Forma);//true
Console.WriteLine(forma is Forma);//true
Console.WriteLine(forma is int);//false

Console.ReadKey();
class Carro
{   }