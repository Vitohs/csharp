Console.WriteLine("Passagem de parametros out");

Console.WriteLine("\nInforme pra mim o raio do circulo chefe");
double raio =Convert.ToDouble(Console.ReadLine());

Circulo circulo = new();
//CONTEXTO
//aqui irei criar 2 variaveis, circunferenciaa, que pegara o return da funcao, e a area, que descera até a função e ira receber seu valor ali
double circunferencia = circulo.CalculaAreaPerimetro(raio, out double area);

Console.WriteLine($"\nArea da circunferencia {area}");
Console.WriteLine($"Perimetro da circunferencia {circunferencia}");

Console.ReadKey();
public class Circulo
{
    //                                            variavel area caiu aqui
    public double CalculaAreaPerimetro(double raio, out double area)//ai ó
    {
        //ai ela desce aqui, e ganha seu valor direto no metodo.
        area = Math.PI * Math.Pow(raio, 2);
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }
}