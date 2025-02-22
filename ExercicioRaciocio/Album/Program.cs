decimal pacoteFigurinha = 0.80m;
decimal albumvazio = 5.00m;
var ficurinhapacote = 6;
var repetido = 2;
var totalfigurinhas = 0;
decimal total = 0.0m;

var pacotes = 63;

while (pacotes > 0)
{
    totalfigurinhas += ficurinhapacote - repetido;
    pacotes--;
}
total = 63.00m * 0.80m + 5.00m;
Console.WriteLine(totalfigurinhas);
Console.WriteLine(total);
Console.ReadKey();