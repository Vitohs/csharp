Console.WriteLine("BLOCO TRY CATCH");
Console.WriteLine("divisao entre x / y\n");

Console.WriteLine("Por favor, informe o valor de x:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Por favor, informe o valor de x:");
int y = Convert.ToInt32(Console.ReadLine());

try
{
    int z = x / y;
    Console.WriteLine($"\n{x} / {y} = {z}");
}
catch(Exception e)
{
    Console.WriteLine($"<< ERRO :{e.Message} >>");
    Console.WriteLine($"MOMENTO DO ERRO :{e?.StackTrace?.ToString()}");
}
finally
{
    Console.WriteLine("Fim do bloco try catch");
}
Console.ReadKey();