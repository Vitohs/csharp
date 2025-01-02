using System.ComponentModel;

Console.WriteLine("Digite o clima ai\n");
var temp = Convert.ToDouble (Console.ReadLine());

var resultado = temp > 27 ? "Quente em filho" : "Normal";

Console.WriteLine($"O tempo esta : {resultado}");

Console.WriteLine("#VAMOS ANINHAR??#\n");

Console.WriteLine("Digite o valor de x:");
var x = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Digite o valor de y:");
var y = Convert.ToInt32 (Console.ReadLine());

string resultado2 = x > y ? "X é maior que y" :
    x < y ? "X é menor que y" :
    x == y ? "X é igual a y" : "sem resultado";

Console.WriteLine(resultado2);

Console.ReadKey(); 

