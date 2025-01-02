Console.WriteLine("EXERCICIO 1- CAMPOS ESTATICOS");

ContaCorrente conta = new();

conta.conta = 123;
conta.nome = "Yuri";
//conta.juros = 3.99f;

ContaCorrente conta2 = new();

conta2.conta = 123;
conta2.nome = "Vitor";
//conta2.juros = 7.69f;

ContaCorrente.juros = 3.99f;

Console.WriteLine($"\nConta do {conta.nome}\n agencia: {conta.conta}\n juros: {conta.JurosAnual()}");
Console.WriteLine($"\nConta do {conta2.nome}\n agencia: {conta2.conta}\n juros: {conta2.JurosAnual()}");

Console.ReadKey();
public class ContaCorrente
{
    public int conta;
    public string? nome;
    public static float juros;

    public float JurosAnual()
    {
        return juros * 12;
    }
}