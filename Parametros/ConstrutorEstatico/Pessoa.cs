
public class Pessoa
{
    public static int idademinima;

    public int idade { get; set; }
    public string nome { get; set; } = string.Empty;

    public Pessoa(int idade, string nome)
    {
        Console.WriteLine("\n executando constructor parametrizado");
        this.idade = idade;
        this.nome = nome;
    }

    public Pessoa()
    {}

    static Pessoa()
    {
        Console.WriteLine("executando construtor estatico");
        Console.WriteLine("inicializando idademinima");
        idademinima = 18;
    }
}