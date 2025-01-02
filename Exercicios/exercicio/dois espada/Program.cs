int natural = 1;
int controle = 0;
Console.WriteLine("Dose de salu");
Console.WriteLine("Certo, os 10 primeiros numeros pares são\n");
for  (int i = 1; i <=10; i++, natural++)
{
    Console.Write(natural);
    controle = controle + natural;
    int res = controle;
    if (i == 10)
    {
        Console.WriteLine("\n");
        Console.WriteLine($"logo, a soma desses numeros naturais da: {res}");
        
    }
    
}
Console.ReadKey();