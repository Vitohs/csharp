Console.WriteLine("Construtores");
Aluno aluno = new("Yurisan",77,"Sigma","S");


Console.ReadKey();
public class Aluno
{
    public Aluno(string nome, int idade, string sexo, string aprovado)
    {
        Nome = nome;
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }

    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
 }