do
{
    Console.WriteLine("Oii, bem vindo ao prototipo, veja as opcoes");
    Console.WriteLine("1- Entrar");
    Console.WriteLine("0- Sair");
    int bb = Convert.ToInt32(Console.ReadLine());
    if (bb == 0)
    {
        break;
               }
    if (bb == 1)
    {
        Console.Clear();
        int numero;
        int numero2;
        int numero3;
        
        Console.WriteLine("Digite um numero");
        numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("digite outro");
        numero2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("digite outro");
        numero3 = Convert.ToInt32(Console.ReadLine());

        if (numero > numero2 && numero > numero3)
        {
            int opium;
            opium = numero;
            Console.WriteLine($"O maior numero é {opium}");
        }

        if (numero2 > numero && numero2 > numero3)
        {
            int opium;
            opium = numero2;
            Console.WriteLine($"O maior numero é {opium}");
        }

        if (numero3 > numero && numero3 > numero2)
        {
            int opium;
            opium = numero3;
            Console.WriteLine($"O maior numero é {opium}");
        }
    }
    if (bb != 1 && bb != 2)
    {
        Console.Clear();
        Console.WriteLine("lembrei daquela sexta feira");
    }
   
}
while (true);
Console.ReadKey();