using System;
using System.Collections.Generic;

try
{
    Console.WriteLine("Informe o dividendo: ");
    var dividendo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Informe o divisor");
    var divisor = Convert.ToInt32(Console.ReadLine());

    int resultado = dividendo / divisor;
    Console.WriteLine($"\n{dividendo} / {divisor} = {resultado}");
}
catch (DivideByZeroException) when (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
{
    Console.WriteLine("Pai, primeiramente oq vc ta fazendo aqui em um sabado, segundo pq ce quer dividir por zero ?");
}
catch (Exception ex) when (ex.Message.Contains("format"))
{
    Console.WriteLine("Filtro de exceção com format");
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Filtro de exceção genericão");
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Fim do programa");
}
Console.ReadKey();