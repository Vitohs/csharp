Console.WriteLine("oii, vamos ver se voce passou no semestre\n");

Console.WriteLine("informe seu nome:");
string nome = Console.ReadLine();

Console.WriteLine($"certo {nome}, informe sua primeira nota:");
var nota1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("boa, agora a segunda nota:");
var nota2 = Convert.ToInt32(Console.ReadLine());

var resultado = (nota1 + nota2) / 2;

if (resultado > 5)
{
    Console.WriteLine($"Boa {nome}, voce passou pohaaa");
}
else
{
    Console.WriteLine("se fudeu");
}
Console.ReadKey();
