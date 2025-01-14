Console.WriteLine("TOCA NO CALLERI QUE É GOLL");
Aluno aluno0 = new();
Aluno aluno = new("Donvito");
Console.ReadKey();
public class Pessoa
{
    public Pessoa()
    {
        Console.WriteLine("construtor de pessoa");
    }
    public Pessoa(string nome)
    {
        Console.WriteLine($"construtor de pessoa com parametro");
    }
}
public class Aluno : Pessoa
{
    public Aluno() : base()//chama o construtor da classe base, no caso Pessoa sem parametros
    {
        Console.WriteLine("construtor de aluno");
    }
    public Aluno(string nome) : base(nome)//chama o construtor da classe base, no caso Pessoa com parametros
    {
        Console.WriteLine($"construtor de aluno com nome {nome}");
    }
}