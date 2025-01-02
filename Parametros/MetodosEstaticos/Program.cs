Console.WriteLine("METODOS ESTÁTICOS");

int soma = Calculadora.Somar(10, 20);
Console.WriteLine(soma);

Console.ReadKey();
public class Calculadora
{
    public static int Somar(int a, int b)
    {
        return a + b;
    }
    public static int Subtrair(int a, int b)
    {
        return a - b;
    }
    public static int dividir(int a, int b)
    {
        return a / b;
    }
    public static int Multiplicar(int a, int b)
    {
        return a * b;
    }
}