// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// tabuadinha so pra controle XD
var i = 1;
var a = 1;
var result = 0;
Console.WriteLine("oie, escreva o numero que tu quer fazer a tabuada");
a = Convert.ToInt32(Console.ReadLine());
if (a > 0)
{ // basicamnete um enquanto
    while (i <= 10)
    {
        result = a * i;
        Console.WriteLine($"{a} x {i} = {result}");
        i++;
    };
}
else
{ Console.WriteLine("Usuario ja cadastrado com esse numero"); }
Console.WriteLine("FIM");
Console.ReadKey();
