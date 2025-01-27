using System;
using System.Collections.Generic;
//dicionario (chave/valor)
Dictionary<int,string> dicionario = new Dictionary<int,string>();
//add no braço
dicionario.Add(1, "vito");
dicionario.Add(2, "yurisan");
dicionario.Add(3, "fafs");

try
{
    dicionario.Add(1, "nobruzera");
}
catch (Exception e)
{

    Console.WriteLine("genio, a chave ja ta sendo usada");
}//chave 1 ja tem dono irmao
var res = dicionario.TryAdd(1, "martelin nao te da bola");
Console.WriteLine(res);//mais curto que o trycath

//verificar se a chave existe no bagui
if(!dicionario.ContainsKey(6))
    dicionario.Add(6, "martelin nao te da bola");
else
    Console.WriteLine("vai dar nao kk");
//if bonito em donvito
//se liga, pergunto se NAO existe a chave x, se nao existir da true e eu adiciono.

Console.WriteLine("\n vendo se existe um valor no bagui");
if(dicionario.ContainsValue("martelin nao te da bola"))
    Console.WriteLine("oii");
else
    Console.WriteLine("nao tem nao");

//alterando valores
Console.WriteLine("\n alterando valor na chave 6");

if (dicionario.ContainsValue("martelin nao te da bola"))
    dicionario[6] = "martelin te da bola";
else
    Console.WriteLine("nao tem nao");

//roletando
foreach (var item in dicionario)
{
    Console.WriteLine($"\nChave: {item.Key} - Valor: {item.Value}");
}

Console.ReadKey();