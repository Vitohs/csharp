using System;

try
{
    Console.WriteLine("Informe o dividendo: ");
    var dividendo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Informe o divisor");
    var divisor = Convert.ToInt32(Console.ReadLine());

    int resultado = dividendo / divisor;
    Console.WriteLine($"\n{dividendo} / {divisor} = {resultado}");
}
catch (FormatException e)
{
    Console.WriteLine("Informe um valor inteiro ai sagaizão");
}
catch (OverflowException)
{
    Console.WriteLine("Numero muito grande vai fazer oq com isso ???");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Vai querer dividir por zero memo ???????");
}
finally
{
    Console.WriteLine("Fim do programa");
}
Console.ReadKey();