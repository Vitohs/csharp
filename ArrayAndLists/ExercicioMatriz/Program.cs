string[,] nomes = new string[2,5];

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.WriteLine("Por favor digite os nomes");
        nomes[i, j] = Console.ReadLine();
        Console.Clear();
    }
}
Console.WriteLine("Deseja ver os nomes cadastrados ? s/n");
var resposta = Console.ReadLine();
if (resposta == "s" || resposta == "S")
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            Console.WriteLine(nomes[i, j]);
        }
    }
}
else
{
    Console.WriteLine("Obrigado por usar o programa");
}
Console.ReadKey();