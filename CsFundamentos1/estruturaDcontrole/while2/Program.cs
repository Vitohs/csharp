//while (true)
//{
//    Console.WriteLine("fala algum numero ae (pra sair digite 69)");
//    var numero = Convert.ToInt32(Console.ReadLine());

//    if (numero == 69)
//    {
//        break;
//    }
//    Console.Clear();
//    if (numero % 2 == 0)
//    { Console.WriteLine($"{numero} é par"); }
//    else if (numero % 2 != 0)
//    { Console.WriteLine($"{numero} é impar"); }
//    else
//    {
//        Console.WriteLine("Boa mano, acha qie eu sou paiaço");
//    }
//}

while (true)
{
    Console.WriteLine("Digite um número (para sair, digite 69):");
    var input = Console.ReadLine();

    if (input == "69")
    {
        break;
    }

    if (int.TryParse(input, out int numero))
    {
        if (numero % 2 == 0)
        {
            Console.WriteLine($"{numero} é par");
        }
        else
        {
            Console.WriteLine($"{numero} é ímpar");
        }
    }
    else
    {
        Console.WriteLine("Boa mano, acha que eu sou palhaço?");
    }
}

