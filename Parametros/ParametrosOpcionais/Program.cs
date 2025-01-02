Console.WriteLine("Argumentos nomeados\n");
Email email = new();

Console.WriteLine("\nPor favor informe o destinatario.");
string destino = Console.ReadLine();

Console.WriteLine($"\nPor favor informe o conteudo da carta que deseja enviar para o: {destino}");
string contexto = Console.ReadLine();

Console.WriteLine("\nPor favor insira o contexto");
Console.WriteLine("1-Urgente");
Console.WriteLine("2-Oii");
Console.WriteLine("3- Pode demorar pae");
string situacao = Console.ReadLine();
switch(situacao)
{
    case "1":
        situacao = "Urgente";
        break;
    case "2":
        situacao = "Oii";
        break;
    case "3":
        situacao = "Pode demorar pae";
        break;
    default:
        situacao = "Urgente";
        break;
}
email.Receba(destino);
Console.ReadKey();
public class Email
{
    public void Receba(string destino, string contexto = "sou gay", string situacao = "Urgente")
    {
        Console.WriteLine("Email enviado para: " + destino + " com o contexto: " + contexto + " e a situação: " + situacao);
    }
}