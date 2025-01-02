Console.WriteLine("Exercicio Struct");

Cliente cli = new("Victor", "vhs@gmail.com", 10);
Console.WriteLine(cli.Idade);
Cliente.ExibirInfo("Victor", "vhs@gmail.com",28);

Console.ReadKey();
public struct Cliente
{
    public string? Nome;
    public string? Email;
    private int _idade;
    public int Idade
    {
        get { return _idade; }
        set
        {
            if (value < 18)
            {
                _idade = 18;
            }
            else
            {
                _idade = value;
            }
        }
    }
    public Cliente(string nome, string email, int idade)
    {
        Nome = nome;
        Email = email;
        Idade = idade;
    }

    public static void ExibirInfo(string? nome, string? email, int idade = 18)
    {
        Console.WriteLine($"Nome: {nome}\nEmail: {email}\nIdade: {idade}");
    }
}