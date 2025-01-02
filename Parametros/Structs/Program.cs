Console.WriteLine("Structs\n");

Pessoa vito = new("victor", 18);

Console.WriteLine($"Nome: {vito.Nome}\nIdade: {vito.Idade}");

Console.ReadKey();
public struct Pessoa
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public Pessoa(string? nome, int idade)
    {
        this.Nome = nome;
        this.Idade = idade;
    }
}
