
Console.WriteLine("oii");
Console.WriteLine("Digite seu login\n");
Console.WriteLine("escreva o usuario: ");
var usuario = Console.ReadLine();
Console.WriteLine("\n");
Console.WriteLine("escreva a senha: ");
var senha = Convert.ToInt32(Console.ReadLine());

var resposta = senha == 123 && usuario == "maria" || usuario == "admin" ? "Login feito com sucesso" : "deu ruim";

Console.WriteLine(resposta);

Console.ReadKey();
