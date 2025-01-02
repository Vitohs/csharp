//oiiiii
int x = 20;
Console.WriteLine($"\n valor do método x antes de passar pela função de dobrar: {x}");
var oi = new Calculo();

oi.Dobrar(ref x);

Console.WriteLine($"\n Valor do metodo X depois após passar pelo metodo de dobrar: {x}");

Console.ReadKey();
public class Calculo
{
    public void Dobrar(ref int y)
    {
        y *= 2;
        Console.WriteLine($"\n Valor do metodo y no metodo dobrar: {y}");
    }
}