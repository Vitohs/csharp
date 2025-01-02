Console.WriteLine("Argumentos nomeados\n");
Email email = new();

//normalmente
//email.Receba("Yuri-san", "Caguei nas calças pai", "Urgente");

//Argumentos nomeados
email.Receba(situacao: "Urgente", destino: "Fafa@email.com", contexto: "Vh chefe");

Console.ReadKey();
public class Email
{
    public void Receba(string destino, string contexto, string situacao)
    {
        Console.WriteLine("Email enviado para: " + destino + " com o contexto: " + contexto + " e a situação: " + situacao);
    }
}