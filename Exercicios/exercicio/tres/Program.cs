using System.Diagnostics;
string certu;
while (true)
{
    Console.WriteLine("menu");
    Console.WriteLine("para sair desse loop, digite a resposta certa");
    Console.WriteLine("a- quit");
    Console.WriteLine("b- essas mina ai");
    Console.WriteLine("c- eu acho é poco");
    Console.WriteLine("d- amostradin");
    Console.WriteLine("x- calma calabreso receba");
    certu = Console.ReadLine();
    if (certu == "x")
    {
        Console.Clear();
        Console.WriteLine("boa, saiu");
        break;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("vai continuar kk");
    }
}
Console.ReadKey();