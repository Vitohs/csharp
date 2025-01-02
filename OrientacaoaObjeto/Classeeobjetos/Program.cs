//oie vamos de classe

Pessoa p1 = new Pessoa();
p1.nome = "Donvito";
p1.idade = 18;
p1.sexo = "Sigma";

Pessoa p2 = new Pessoa();
p2.nome = "fafá";
p2.idade = 18;
p2.sexo = "Chad";

Console.WriteLine("RELATORIO DOS MAIS BRABO");
Console.WriteLine($"Nome: {p1.nome}, idade: {p1.idade} anos, sexo: {p1.sexo}");
Console.WriteLine($"Nome: {p2.nome}, idade: {p2.idade} anos, sexo: {p2.sexo}");

Console.ReadKey();
class Pessoa()
{
    public string? nome;
    public int idade;
    public string? sexo;
}