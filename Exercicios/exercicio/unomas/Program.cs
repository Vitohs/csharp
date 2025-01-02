while (true)
{
    Console.WriteLine("Digite um número:");
    var n = Convert.ToInt32(Console.ReadLine());

    if (n > 0)
    {
        int fatorial = 1;
        for (int i = 1; i <= n; i++)
        {
            fatorial *= i;
        }
        Console.WriteLine($"O fatorial de {n} é {fatorial}");
    }
    else
    {
        Console.WriteLine("di pião na sul");
        break;
    }
}

Console.ReadKey();
