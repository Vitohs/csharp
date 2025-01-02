Console.WriteLine("TIPOS ANONIMOS");

var aluno = new
{
    Id = 1,
    Nome = "Vitor",
    Idade = 18,
    Endereco = new
    {
        Id = 1,
        Rua = "Rua 1",
        Numero = 123
    }
};

Console.ReadKey();