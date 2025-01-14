Professor professor = new();
professor.Nome = "Jorge";
professor.Turma = 1;
Console.WriteLine(professor.saudacao());
Console.ReadKey();
public class Pessoa
{
    public string? Nome { get; set; }
    public string saudacao() => $"oii, eu sou o(a) {Nome}";//estou ocultando esse metodo na classe filha
}
public class Professor : Pessoa
{
    public string? Disciplina { get; set; }
    public int Turma { get; set; }
    //casp de fato quero ocultar o metodo da classe pai, preciso usar a palavra new veja abaixo
    public new string saudacao() => $"oii, eu sou o(a) {Nome}, da turma {Turma}";
    //     ai
}