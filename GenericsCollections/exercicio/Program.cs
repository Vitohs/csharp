var pacoteFigurinha = 0.80m;
var albumvazio = 5.00m;
var ficurinhapacote = 6;
var repetido = 2;
var totalfigurinhas = 0;
var total = 0.0m;

var pacotes = 63;

while (pacotes > 0)
{
    totalfigurinhas += ficurinhapacote - repetido;
    pacotes--;
}
Console.WriteLine(totalfigurinhas);
Console.ReadKey();