//###metodos e parametros##
using System;

var Aluno = new Aluno();

Aluno.Consulta();


Console.ReadKey();
public class Aluno()
{
    public string? nome;
    public int idade;
    public string? sexo;
    public string? aprovado;

    public void Consulta()
    {
        var Aluno = new Aluno();
        var contexto = new Curso();
        Console.WriteLine("Escreva seu nome:");
        Aluno.nome = Console.ReadLine();

        Console.WriteLine("Escreva sua idade: ");
        Aluno.idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escreva se sexo: ");
        Aluno.sexo = Console.ReadLine();

        Console.WriteLine("Foi aprovado ? S or N");
        Aluno.aprovado = Console.ReadLine();

        contexto.boletim(Aluno);

    }
}

public class Curso()
{
    public void boletim(Aluno Aluno)
    {
        Console.WriteLine("OIIII, vamos ver seu boletim");
        Console.WriteLine($"O aluno {Aluno.nome} do sexo {Aluno.sexo} com {Aluno.idade} anos");
        if(Aluno.aprovado == "S")
        {
            Console.WriteLine("Foi aprovado");
        }
        else
        {
            Console.WriteLine("Foi reprovado");
        }
    }
}
