
Calculadora yuri = new Calculadora();


//feio em
Console.WriteLine(yuri.Somar(700, 200));

var oie = yuri.Somar(90, 30);
Console.WriteLine(oie);

Console.ReadKey();          

public class Calculadora
{
    public float Somar(float x, float y)
    {
        return x + y;
    }
}