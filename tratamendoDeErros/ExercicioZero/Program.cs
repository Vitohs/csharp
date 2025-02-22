using System;
using System.Collections.Generic;

try
{
    Console.WriteLine("Acessando o arquivo: poesia.txt em https://macoratti.net/dados\n");
    Console.WriteLine("Informe o nome do arquivo para ser acessado");
    var arquivo = Console.ReadLine();
    Console.WriteLine("Informe a url do site");
    var url = Console.ReadLine();
    Console.WriteLine("\n Aguarde um momento...");

    HttpClient client = new HttpClient();
    HttpResponseMessage response = client.GetAsync(url + "/" + arquivo).Result;

    if(response.IsSuccessStatusCode)
    {
        Console.WriteLine("Acesso concedido com sucesso");
        Console.WriteLine("Códico de status: " + response.StatusCode);//deve retornar 200
    }
    else
    {
        throw new HttpRequestException("Erro: " + (int)response.StatusCode);
    }
}
catch (HttpRequestException ex) when (ex.Message.Contains("404"))
{
    Console.WriteLine("Pagina não encontrada");
}
catch(HttpRequestException ex) when (ex.Message.Contains("400"))
{
    Console.WriteLine("Solicitação inválida");
}
catch (HttpRequestException ex) when (ex.Message.Contains("401"))
{
    Console.WriteLine("Acesso não autorizado");
}
catch (HttpRequestException ex) when (ex.Message.Contains("403"))
{
    Console.WriteLine("Acesso proibido");
}
catch (HttpRequestException ex) when (ex.Message.Contains("500"))
{
    Console.WriteLine("Erro interno do servidor");
}
catch (Exception ex)
{
    Console.WriteLine("Erro: " + ex.Message);
}
finally
{
    Console.WriteLine("Fim do programa");
}
Console.ReadKey();