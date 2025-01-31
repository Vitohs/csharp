using System;
using System.Collections.Generic;
//instancia
//aqui seria  na forma do metodo estatico, veja otro jeito ai paps
GenericClass<int, int>.Comparar(10, 10);
GenericClass<float, float> oii = new(); //kk corta, achei que era pra inicializar os numeros direto no objeto, so era pra especificar os tipos na classe, chapei
//inteiros
int a = 10;
int b = 10;
//floats
float c = 10.5f;
float d = 10.5f;
//strings
string e = "teste";
string f = "teste";

//comparando
Teste.Comparar(a, b);
Teste.Comparar(c, d);
//Teste.Comparar(e, f);
//novo metodo
Teste.Comparar2(a, c);
//se eu quiser comparar 2 strings ja nao iria dar, eu precisaria fazer sobrecarga do metodo
//porem ira poluir nossa aplicacao, vamos usar generics para resolver isso
Console.ReadKey();
public class Teste
{
    //aqui eu posso comparar qualquer tipo de dado, o T representa qualquer tipo, por ser generico.
    //vamos pras constrants
    public static void Comparar<T>(T a, T b) where T : struct//aqui to falando que só pode passar aqui tipos por valor (int, decimal, float), se vier string, vai dar erro
    {
        var res = a.Equals(b);
        Console.WriteLine($"{a} e {b} são iguais ? : {res}");
    }
    //vou fazer uma ""sobrecarga"" representando o metodo acima, passando 2 tipos distintos para comparar
    public static void Comparar2<T,T2>(T a, T2 b)
    {
        var res = a.Equals(b);
        Console.WriteLine($"{a} e {b} são iguais ? : {res}");
    }
}
//com a classe generica nao preciso ficar especificando qual metodo precisa ser generico, porem tenho que passar os parametros logo ao inicializar um objeto
//semelhante a um constructo
public class GenericClass<T1,T2>
{
    public static void Comparar(T1 a, T2 b)
    {
        var res = a.Equals(b);
        Console.WriteLine($"{a} e {b} são iguais ? : {res}");
    }
}
